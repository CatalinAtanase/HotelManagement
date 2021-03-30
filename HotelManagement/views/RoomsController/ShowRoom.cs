using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.RoomsController
{
    public partial class listView_showRoom : Form
    {
        List<Room> rooms;
        public listView_showRoom(List<Room> r)
        {
            InitializeComponent();
            this.rooms = r;
            displayList();
        }

        private void displayList()
        {
            dgv_showRooms.Rows.Clear();
            rooms.Sort((a,b)=>a.Id < b.Id ? 0 : 1);
            foreach (Room r in rooms)
            {
                int rowIndex = this.dgv_showRooms.Rows.Add(r.Id, r.Capacity, r.IsPremium, r.Price, r.IsBooked);
                this.dgv_showRooms.Rows[rowIndex].Tag = r;
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if(dgv_showRooms.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_showRooms.SelectedRows[0];
                Room room = (Room)selectedRow.Tag;
                Form editRoom = new EditRoom(rooms, room);
                editRoom.ShowDialog();
                displayList();
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            if (dgv_showRooms.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_showRooms.SelectedRows[0];
                Room room = (Room)selectedRow.Tag;
                rooms.Remove(room);
                MessageBox.Show("Camera stersa cu succes!");
                displayList();
            }
        }
    }

   
}
