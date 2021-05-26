using HotelManagement.views.UsersController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        string bookingsPath;
        string roomsPath;

        public event CallBack SaveObjects;

        public EditBooking(List<Booking> bookings, List<User> users, List<Room> rooms, Booking booking, string bookingsPath, string roomsPath)
        {
            InitializeComponent();
            this.bookings = bookings;
            this.users = users;
            this.rooms = rooms;
            this.booking = booking;
            this.bookingsPath = bookingsPath;
            this.roomsPath = roomsPath;
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
                if (users[i].Cnp == booking.UserCNP)
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
                if(rooms[i].Id == booking.RoomId)
                {
                    this.select_camera.SelectedIndex = i;
                }
            }
        }

        private void Btn_Edit_Booking_Click(object sender, EventArgs e)
        {
            int userIndex = this.Select_user.SelectedIndex;
            DateTime startDate = this.select_checkIn.Value.Date;
            DateTime endDate = this.select_checkOut.Value.Date;
            int roomIndex = this.select_camera.SelectedIndex;
            bool isValid = true;
            List<Booking> temp = new List<Booking>();

            temp = bookings.FindAll(b => b.CompareTo(booking) == 0);

            if (userIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Nu ati selectat clientul!\n");
            }

            else if ((startDate - DateTime.Now.Date).Days < 0)
            {
                isValid = false;
                MessageBox.Show("Data de checkin nu poate fi mai mica decat data de astazi!\n");
            }

            else if ((startDate - endDate).Days >= 0)
            {
                isValid = false;
                MessageBox.Show("Data de checkout trebuie sa fie mai mare decat data de checkin!\n");
            }

            else if (roomIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Nu ati selectat camera!\n");
            }

            else if (temp.FindAll((b) => b.RoomId.ToString() == this.select_camera.Text).Any(b => (b.EndDate - startDate).Days > 0))
            {
                isValid = false;
                MessageBox.Show("Camera este deja rezervata in acea perioada!\n");
            }

            if (isValid)
            {
                try
                {
                   



                    try
                    {
                        string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DB.accdb";
                        using (var conn = new OleDbConnection(connStr))
                        using (var myCommand = conn.CreateCommand())
                        {
                            Item selected = this.Select_user.SelectedItem as Item;
                            User user = users.Find((u) => u.Cnp == selected.cnp);
                            Room room = rooms.Find((r) => r.Id.ToString() == this.select_camera.SelectedItem.ToString());

                            var oldCnp = booking.UserCNP;
                            var oldStartDate = booking.StartDate;
                            var oldRoomNumber = booking.RoomId;

                            booking.UserCNP = user.Cnp;
                            booking.RoomId = room.Id;
                            booking.StartDate = startDate;
                            booking.EndDate = endDate;

                            SaveObjects?.Invoke(bookings, bookingsPath);
            
                            string query = "Update bookings SET userCNP = @userCNP, roomId = @roomId, startdDate = @startDate, endDate = @endDate where userCNP = @oldCnp and roomId= @oldRoomNumber and startDate = @oldStartDate;";
                            myCommand.CommandText = query;

                            myCommand.Parameters.AddWithValue("@userCNP", user.Cnp);
                            myCommand.Parameters.AddWithValue("@roomId", room.Id);
                            myCommand.Parameters.AddWithValue("@startDate", startDate);
                            myCommand.Parameters.AddWithValue("@endDate", endDate);
                            myCommand.Parameters.AddWithValue("@oldCnp", oldCnp);
                            myCommand.Parameters.AddWithValue("@oldRoomNumber", oldRoomNumber);
                            myCommand.Parameters.AddWithValue("@oldStartDate", oldStartDate);
                            conn.Open();
                            myCommand.ExecuteNonQuery();

                            MessageBox.Show("Datele clientului au fost editate cu succes! Toate rezervarile au fost reatribuite!");
                            this.Dispose();

                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
