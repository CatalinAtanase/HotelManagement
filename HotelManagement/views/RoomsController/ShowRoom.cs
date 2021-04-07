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
        string roomsPath;
        List<Booking> bookings;
        string bookingsPath;

        public event CallBack SaveObjects;

        public listView_showRoom(List<Room> r, string roomsPath, List<Booking> bookings, string bookingsPath)
        {
            InitializeComponent();
            this.rooms = r;
            this.roomsPath = roomsPath;
            this.bookings = bookings;
            this.bookingsPath = bookingsPath;
            displayList();
        }

        private void displayList()
        {
            dgv_showRooms.Rows.Clear();
            rooms.Sort((a, b) => a.Id < b.Id ? 0 : 1);
            foreach (Room r in rooms)
            {
                int rowIndex = this.dgv_showRooms.Rows.Add(r.Id, r.Capacity, r.IsPremium, r.Price, r.IsBooked);
                this.dgv_showRooms.Rows[rowIndex].Tag = r;
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (dgv_showRooms.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_showRooms.SelectedRows[0];
                Room room = (Room)selectedRow.Tag;
                EditRoom editRoom = new EditRoom(rooms, room, roomsPath, bookings, bookingsPath);
                editRoom.SaveObjects += SaveObjects;
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

                bookings.RemoveAll((b) => b.RoomId == room.Id);
                SaveObjects?.Invoke(bookings, bookingsPath);


                rooms.Remove(room);
                SaveObjects?.Invoke(rooms, roomsPath);

                MessageBox.Show("Camera stersa cu succes!");
                displayList();
            }
            else
            {
                MessageBox.Show("Prea multe linii selectate!");
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCol = dgv_showRooms.SelectedCells[0];

            if (dgv_showRooms.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = selectedCol.OwningRow;
                Room room = (Room)selectedRow.Tag;
                EditRoom editRoom = new EditRoom(rooms, room, roomsPath, bookings, bookingsPath);
                editRoom.SaveObjects += SaveObjects;
                editRoom.ShowDialog();
                displayList();
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCol = dgv_showRooms.SelectedCells[0];

            if (dgv_showRooms.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = selectedCol.OwningRow;
                Room room = (Room)selectedRow.Tag;

                bookings.RemoveAll((b) => b.RoomId == room.Id);
                SaveObjects?.Invoke(bookings, bookingsPath);


                rooms.Remove(room);
                SaveObjects?.Invoke(rooms, roomsPath);

                MessageBox.Show("Camera stersa cu succes!");
                displayList();
            }
        }

        private void marestrePretCu100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCol = dgv_showRooms.SelectedCells[0];

            if (dgv_showRooms.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = selectedCol.OwningRow;
                Room room = (Room)selectedRow.Tag;

                room = room + 100;
                SaveObjects?.Invoke(rooms, roomsPath);
                displayList();
            }
        }

        private void scadePretCu100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCol = dgv_showRooms.SelectedCells[0];

            if (dgv_showRooms.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = selectedCol.OwningRow;
                Room room = (Room)selectedRow.Tag;

                room = room + (-100);
                SaveObjects?.Invoke(rooms, roomsPath);
                displayList();
            }
        }
    }
}
