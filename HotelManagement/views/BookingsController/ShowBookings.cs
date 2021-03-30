using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.BookingsController
{
    public partial class ShowBookings : Form
    {
        public List<Booking> bookings = new List<Booking>();
        public ShowBookings(List<Booking> bookings)
        {
            InitializeComponent();
            this.bookings = bookings;
            displayList();
        }

        public void displayList()
        {
            this.dgv_bookings.Rows.Clear();
            bookings.Sort((a, b) => DateTime.Compare(a.StartDate, b.StartDate));
            foreach(Booking b in bookings)
            {
                int index = this.dgv_bookings.Rows.Add(b.User.getFullName(), b.StartDate.ToShortDateString(), b.EndDate.ToShortDateString(), b.Room.Id);
                this.dgv_bookings.Rows[index].Tag = b;
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            if (dgv_bookings.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_bookings.SelectedRows[0];
                Booking booking = (Booking)selectedRow.Tag;
                bookings.Remove(booking);
                MessageBox.Show("Rezervare stearsa cu succes!");
                displayList();
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (dgv_bookings.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_bookings.SelectedRows[0];
                Booking booking = (Booking)selectedRow.Tag;
               // Form editRoom = new EditRoom(rooms, room);
               // editRoom.ShowDialog();
                displayList();
            }
        }
    }
}
