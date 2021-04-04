using HotelManagement.views.UsersController;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.views.BookingsController
{

    public partial class AddBooking : Form
    {
        List<Booking> bookings = new List<Booking>();
        List<User> users = new List<User>();
        List<Room> rooms = new List<Room>();
        string usersPath;
        string bookingsPath;
        string roomsPath;

        ArrayList roomSelects = new ArrayList();

        public event CallBack SaveObjects;

        public AddBooking(List<Booking> bookings, List<User> users, List<Room> rooms, string usersPath, string bookingsPath, string roomsPath)
        {
            InitializeComponent();
            this.users = users;
            this.bookings = bookings;
            this.rooms = rooms;
            this.usersPath = usersPath;
            this.bookingsPath = bookingsPath;
            this.roomsPath = roomsPath;
            roomSelects.Add(this.select_camera);
            loadUserSelect();
            loadRoomSelect(this.select_camera);
            loadDates();
        }

        private void loadUserSelect()
        {
            this.Select_user.Items.Clear();
            foreach (User user in users)
            {
                this.Select_user.Items.Add(new Item(user.Cnp, user.getFullName()));
            }
            this.Select_user.Sorted = true;

        }

        private void loadRoomSelect(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (Room room in rooms)
            {
                cb.Items.Add(room.Id);
            }
            cb.Sorted = true;
        }

        private void loadDates()
        {
            this.select_checkIn.Value = DateTime.Now;
            this.select_checkOut.Value = DateTime.Now.AddDays(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(users, usersPath);
            addUser.FormBorderStyle = FormBorderStyle.FixedDialog;
            addUser.SaveUsers += SaveObjects;
            addUser.ShowDialog();
            loadUserSelect();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Add_Booking_Click(object sender, EventArgs e)
        {
            List<int> roomValues = new List<int>();

            int userIndex = this.Select_user.SelectedIndex;
            DateTime startDate = this.select_checkIn.Value.Date;
            DateTime endDate = this.select_checkOut.Value.Date;
           // int roomIndex = this.select_camera.SelectedIndex;
            bool isValid = true;

            if (userIndex == -1)
            {
                isValid = false;
                errorProvider1.SetError(Select_user, "Nu ati selectat clientul!");
            }

            else if ((startDate - DateTime.Now.Date).Days < 0)
            {
                isValid = false;
                errorProvider1.SetError(select_checkIn, "Data de checkin nu poate fi mai mica decat data de astazi!");
            }

            else if ((startDate - endDate).Days >= 0)
            {
                isValid = false;
                errorProvider1.SetError(select_checkOut, "Data de checkout trebuie sa fie mai mare decat data de check in!");
            }

            //else if (roomIndex == -1)
            //{
            //    isValid = false;
            //    errorProvider1.SetError(select_camera, "Nu ati selectat camera!");
            //}

            //else if (bookings.FindAll((b) => b.RoomId.ToString() == this.select_camera.Text).Any(b => (b.EndDate - startDate).Days > 0))
            //{
            //    isValid = false;
            //    MessageBox.Show("Camera este deja rezervata in acea perioada!\n");
            //}

            if (isValid)
            {

                for(int i = 0; i < roomSelects.Count; i++)
                {
                    ComboBox cb = ((ComboBox)roomSelects[i]);

                    if (cb.SelectedIndex == -1)
                    {
                        errorProvider1.SetError(cb, "Nu ati completat campul de camera!");
                        return;
                    } else if (roomValues.Contains((int)cb.SelectedItem)) {
                        errorProvider1.SetError(cb, "Camera deja selectata!");
                    }

                    roomValues.Add((int)cb.SelectedItem);
                }

                List<Booking> temp = new List<Booking>();

                foreach(int value in roomValues)
                {
                    foreach(Booking b in bookings)
                    {
                        if(b.Rooms.Contains(value) && !temp.Contains(b))
                        {
                            temp.Add(b);
                        }
                    }
                }

                if(temp.Any(b => (b.EndDate - startDate).Days > 0))
                {
                    MessageBox.Show("Nu toate camerele sunt disponibile in aceasta perioada!\n");
                    return;
                }

                try
                {
                    Item selected = this.Select_user.SelectedItem as Item;
                    User user = users.Find((u) => u.Cnp == selected.cnp);
                    Room room = rooms.Find((r) => r.Id.ToString() == this.select_camera.SelectedItem.ToString());

                    if ((startDate - DateTime.Now).Hours <= 0)
                    {
                        room.IsBooked = true;
                        SaveObjects?.Invoke(rooms, roomsPath);
                    }

                    Booking newBooking = new Booking(user.Cnp, room.Id, startDate, endDate, roomValues.ToArray());
                    bookings.Add(newBooking);
                    Console.WriteLine(newBooking);
                    SaveObjects?.Invoke(bookings, bookingsPath);

                    MessageBox.Show("Rezervare adaugata cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.select_camera.SelectedIndex = -1;
                    this.Select_user.SelectedIndex = -1;
                    errorProvider1.Clear();
                }
            }

        }

        private void AddBooking_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            int x = ((ComboBox)roomSelects[0]).Location.X;
            int y = ((ComboBox)roomSelects[roomSelects.Count - 1]).Location.Y;

            ComboBox cb = new ComboBox();
            cb.Location = new Point(x, y + 30);
            cb.Size = new System.Drawing.Size(198, 50);
            roomSelects.Add(cb);
            loadRoomSelect(cb);
            this.Controls.Add(cb);
        }

        private void btn_remove_room_Click(object sender, EventArgs e)
        {
            if (this.roomSelects.Count > 1)
            {
                this.Controls.Remove((ComboBox)this.roomSelects[roomSelects.Count - 1]);
                this.roomSelects.RemoveAt(roomSelects.Count - 1);
            }
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
