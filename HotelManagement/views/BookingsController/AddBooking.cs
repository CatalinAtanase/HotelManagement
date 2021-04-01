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

        public void loadUserSelect()
        {
            this.Select_user.Items.Clear();
            foreach (User user in users)
            {
                this.Select_user.Items.Add(new Item(user.Cnp, user.getFullName()));
            }
            this.Select_user.Sorted = true;

        }

        public void loadRoomSelect()
        {
            this.select_camera.Items.Clear();
            foreach (Room room in rooms)
            {
                this.select_camera.Items.Add(room.Id);
            }
            this.select_camera.Sorted = true;
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

        private void Btn_Add_Booking_Click(object sender, EventArgs e)
        {
            int userIndex = this.Select_user.SelectedIndex;
            DateTime startDate = this.select_checkIn.Value;
            DateTime endDate = this.select_checkOut.Value;
            int roomIndex = this.select_camera.SelectedIndex;
            bool isValid = true;

            if (userIndex == -1)
            {
                isValid = false;
                errorProvider1.SetError(Select_user, "Nu ati selectat clientul!");
            }

            else if(DateTime.Compare(startDate, DateTime.Now) < -1)
            {
                isValid = false;
                errorProvider1.SetError(select_checkIn, "Data de checkin nu poate fi mai mica decat data de astazi!");
            }

            else if (DateTime.Compare(startDate, endDate) > 0)
            {
                isValid = false;
                errorProvider1.SetError(select_checkOut, "Data de checkin nu poate fi mai mica decat data de astazi!");
            }

            else if (roomIndex == -1)
            {
                isValid = false;
                errorProvider1.SetError(select_camera, "Nu ati selectat camera!");
            }

            else if(bookings.FindAll((b) => b.Room.Id.ToString() == this.select_camera.Text).Any(b => DateTime.Compare(b.EndDate, startDate) > 0))
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

                    bookings.Add(new Booking(user, room, startDate, endDate));
                    MessageBox.Show("Rezervare adaugata cu succes!");
                    
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    this.select_camera.SelectedIndex = -1;
                    this.Select_user.SelectedIndex = -1;
                }
            }

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {

        }
    }
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
