using HotelManagement.views.BookingsController;
using HotelManagement.views.RoomsController;
using HotelManagement.views.UsersController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views
{
    public delegate void CallBack(object obj, string path);
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        private List<Room> rooms = new List<Room>();
        private List<User> users = new List<User>();
        List<Booking> bookings = new List<Booking>();
        private const string roomsPath = "rooms.bin";
        private const string usersPath = "users.bin";
        private const string bookingsPath = "rezervari.bin";
        public Dashboard()
        {
            InitializeComponent();
       
            try
            {
                this.users = (List<User>)Deserialize(usersPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.rooms = (List<Room>)Deserialize(roomsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.bookings = (List<Booking>)Deserialize(bookingsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hideSubMenu()
        {
            panel_subMenu_camere_btns.Visible = false;
            panel_subMenu_clienti_btns.Visible = false;
            panel_subMenu_rezervari_btns.Visible = false;
        }

        private void toggleSubMenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {

                submenu.Visible = false;
            }
        }

        private void btn_camere_dropdown_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_camere_btns);
        }

        private void btn_bookings_dropdown_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_rezervari_btns);
        }

        private void btn_user_dropdown_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panel_subMenu_clienti_btns);
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childForm.Controls.Add(childForm);
            panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_add_camere_Click(object sender, EventArgs e)
        {
            AddRoom form = new AddRoom(rooms, roomsPath);
            form.SaveRooms += Serialize;
            openChildForm(form);
        }


        private void btn_show_camere_Click(object sender, EventArgs e)
        {
            listView_showRoom form = new listView_showRoom(rooms, roomsPath, bookings, bookingsPath);
            form.SaveObjects += Serialize;
            openChildForm(form);
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser(users, usersPath);
            form.SaveUsers += Serialize;
            openChildForm(form);
        }

        private void btn_show_clients_Click(object sender, EventArgs e)
        {
            ShowUsers form = new ShowUsers(users, usersPath, bookings, bookingsPath, rooms, roomsPath);
            form.SaveObjects += Serialize;
            openChildForm(form);
        }

        private void btn_show_bookings_Click(object sender, EventArgs e)
        {
            ShowBookings form = new ShowBookings(bookings, users, rooms, bookingsPath, roomsPath);
            form.SaveObjects += Serialize;
            openChildForm(form);
        }

        private void btn_add_booking_Click(object sender, EventArgs e)
        {
            AddBooking form = new AddBooking(bookings, users, rooms, usersPath, bookingsPath, roomsPath);
            form.SaveObjects += Serialize;
            openChildForm(form);
        }

        //public static bool Serialize(object value, string path)
        //{
        //    try
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();

        //        using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        //        {
        //            formatter.Serialize(fStream, value);
        //        }
        //        return true;
        //    } catch (Exception ex)
        //    {
        //        return false;
        //    }
            
        //}

        public static void Serialize(object value, string path)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static object Deserialize(string path)
        {
            if (!System.IO.File.Exists(path)) { throw new NotImplementedException(); }

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(path))
            {
                return formatter.Deserialize(fStream);
            }
        }

        private void btn_save_rooms_Click(object sender, EventArgs e)
        {
            Statistics form = new Statistics(bookings);
            form.ShowDialog();
        }

        private void btn_saveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Salvare clienti?", "Salveaza clienti", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Serialize(users, usersPath);
                    MessageBox.Show("Clienti salvati in fisierul " + usersPath + "!");
                }
                if (activeForm != null)
                {
                    activeForm.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_saveBookings_Click(object sender, EventArgs e)
        {
            DeleteBookings form = new DeleteBookings(bookings, users, bookingsPath);
            form.SaveObjects += Serialize;
            form.ShowDialog();
        }

        private void cameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom form = new AddRoom(rooms, roomsPath);
            form.SaveRooms += Serialize;
            openChildForm(form);
        }

        private void rezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooking form = new AddBooking(bookings, users, rooms, usersPath, bookingsPath, roomsPath);
            form.SaveObjects += Serialize;
            openChildForm(form);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser(users, usersPath);
            form.SaveUsers += Serialize;
            openChildForm(form);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xt");
        }
    }
}

