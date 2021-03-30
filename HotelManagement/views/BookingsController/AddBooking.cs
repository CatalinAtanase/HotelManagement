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
    public partial class AddBooking : Form
    {
        List<Booking> bookings = new List<Booking>();
        List<User> users = new List<User>();
        List<Room> rooms = new List<Room>();
        public AddBooking(List<Booking> bookings, List<User> users, List<Room> rooms)
        {
            InitializeComponent();
            this.users = users;
            this.bookings = bookings;
            this.rooms = rooms;
            loadUserSelect();
            loadRoomSelect();
        }

        class Item
        {
            public string cnp { get; set; }
            public string fullName { get; set; }

            public override string ToString()
            {
                return fullName;
            }

            public Item(string cnp, string fullName)
            {
                this.cnp = cnp;
                this.fullName = fullName;
            }
        }

        public void loadUserSelect()
        {
            this.Select_user.Items.Clear();
            foreach (User user in users)
            {
                this.Select_user.Items.Add(new Item(user.Cnp, user.getFullName()));
                this.Select_user.Sorted = true;
            }
        }

        public void loadRoomSelect()
        {
            this.select_camera.Items.Clear();
            foreach (Room room in rooms)
            {
                this.select_camera.Items.Add(room.Id);
                this.select_camera.Sorted = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addUser = new AddUser(users);
            addUser.FormBorderStyle = FormBorderStyle.FixedDialog;
            addUser.ShowDialog();
            loadUserSelect();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Add_User_Click(object sender, EventArgs e)
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

            if(DateTime.Compare(startDate, DateTime.Now) < 0)
            {
                isValid = false;
                MessageBox.Show("Data de checkin nu poate fi mai mica decat data de astazi!\n");
            }

            if (DateTime.Compare(startDate, endDate) > 0)
            {
                isValid = false;
                MessageBox.Show("Data de checkin nu poate fi mai mare decat data de checkout!\n");
            }

            if (roomIndex == -1)
            {
                isValid = false;
                MessageBox.Show("Nu ati selectat camera!\n");
            }

            if(isValid)
            {
                Item selected = this.Select_user.SelectedItem as Item;
               // User user = users.Find((u) => u.Cnp == selected.cnp);
                //bookings.Add(new Booking())
                //int u = rooms.Max((Room r) => r.Id);
                //Console.WriteLine(u);

            }

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {

        }
    }
}
