using HotelManagement.views.UsersController;
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
    public partial class EditBooking : Form
    {
        List<Booking> bookings = new List<Booking>();
        List<User> users = new List<User>();
        List<Room> rooms = new List<Room>();
        Booking booking;
        public EditBooking(List<Booking> bookings, List<User> users, List<Room> rooms, Booking booking)
        {
            InitializeComponent();
            this.bookings = bookings;
            this.users = users;
            this.rooms = rooms;
            this.booking = booking;
        }

        private void EditBooking_Load(object sender, EventArgs e)
        {
            loadUserSelect();
            loadRoomSelect();
            this.select_checkIn.Value = booking.StartDate; 
            this.select_checkOut.Value = booking.EndDate;
        }

        public void loadUserSelect()
        {
            this.Select_user.Items.Clear();
            for (int i = 0; i < users.Count; i++)
            {
                this.Select_user.Items.Add(new Item(users[i].Cnp, users[i].getFullName()));
                if (users[i].Cnp == booking.User.Cnp)
                {
                    this.Select_user.SelectedIndex = i;
                }
            }
        }

        public void loadRoomSelect()
        {
            this.select_camera.Items.Clear();
            for(int i = 0; i < rooms.Count; i++)
            {
                this.select_camera.Items.Add(rooms[i].Id);
                if(rooms[i].Id == booking.Room.Id)
                {
                    this.select_camera.SelectedIndex = i;
                }
            }
        }

        private void Btn_Edit_Booking_Click(object sender, EventArgs e)
        {
            int userIndex = this.Select_user.SelectedIndex;
            DateTime startDate = this.select_checkIn.Value;
            DateTime endDate = this.select_checkOut.Value;
            int roomIndex = this.select_camera.SelectedIndex;
            bool isValid = true;

            if (userIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Nu ati selectat clientul!\n");
            }

            else if (DateTime.Compare(startDate, DateTime.Now) < -1)
            {
                isValid = false;
                MessageBox.Show("Data de checkin nu poate fi mai mica decat data de astazi!\n");
            }

            else if (DateTime.Compare(startDate, endDate) > 0)
            {
                isValid = false;
                MessageBox.Show("Data de checkout trebuie sa fie mai mare decat data de checkin!\n");
            }

            else if (roomIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Nu ati selectat camera!\n");
            }

            else if (bookings.FindAll((b) => b.Room.Id.ToString() == this.select_camera.Text && b.Room.Id != booking.Room.Id).Any(b => DateTime.Compare(b.EndDate, startDate) > 0))
            {
                isValid = false;
                MessageBox.Show("Camera este deja rezervata in acea perioada!\n");
            }

            if (isValid)
            {
                try
                {
                    Item selected = this.Select_user.SelectedItem as Item;
                    User user = users.Find((u) => u.Cnp == selected.cnp);
                    Room room = rooms.Find((r) => r.Id.ToString() == this.select_camera.SelectedItem.ToString());

                    Console.WriteLine(user);
                    Console.WriteLine(room);
                    Console.WriteLine(startDate);
                    Console.WriteLine(endDate);

                    booking.User = user;
                    booking.Room = room;
                    booking.StartDate = startDate;
                    booking.EndDate = endDate;

                    MessageBox.Show("Rezervare editata cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
