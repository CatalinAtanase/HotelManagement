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
        List<User> users = new List<User>();
        List<Room> rooms = new List<Room>();
        string bookingsPath;
        string roomsPath;

        public event CallBack SaveObjects;

        public ShowBookings(List<Booking> bookings, List<User> users, List<Room> rooms, string bookingsPath, string roomsPath)
        {
            InitializeComponent();
            this.users = users;
            this.bookings = bookings;
            this.rooms = rooms;
            this.bookingsPath = bookingsPath;
            this.roomsPath = roomsPath;
            displayList();
        }

        public void displayList()
        {
            this.dgv_bookings.Rows.Clear();
            bookings.Sort((a, b) => DateTime.Compare(a.StartDate, b.StartDate));
            foreach(Booking b in bookings)
            {
                try
                {
                    User rowUser = users.Find((u) => u.Cnp == b.UserCNP);
                    int index = this.dgv_bookings.Rows.Add(rowUser.getFullName(), b.StartDate.ToShortDateString(), b.EndDate.ToShortDateString(), b.RoomId);
                    this.dgv_bookings.Rows[index].Tag = b;
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            if (dgv_bookings.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_bookings.SelectedRows[0];
                Booking booking = (Booking)selectedRow.Tag;

                rooms.Find((r) => r.Id == booking.RoomId).IsBooked = false;
                SaveObjects?.Invoke(rooms, roomsPath);

                bookings.Remove(booking);
                SaveObjects?.Invoke(bookings, bookingsPath);
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
                EditBooking editBooking = new EditBooking(bookings, users, rooms, booking, bookingsPath, roomsPath);
                editBooking.SaveObjects += SaveObjects;
                editBooking.ShowDialog();
                displayList();
            }
        }
    }
}
