using HotelManagement.views.BookingsController;
using HotelManagement.views.RoomsController;
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

namespace HotelManagement.views
{
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        private List<Room> rooms = new List<Room>();
        private List<User> users = new List<User>();
        List<Booking> bookings = new List<Booking>();
        public Dashboard(List<Room> r, List<User> users, List<Booking> bookings)
        {
            InitializeComponent();
            this.rooms = r;
            this.users = users;
            this.bookings = bookings;
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
            openChildForm(new AddRoom(rooms));
        }

        private void panel_childForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_show_camere_Click(object sender, EventArgs e)
        {
            openChildForm(new listView_showRoom(rooms));
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            openChildForm(new AddUser(users));
        }

        private void btn_show_clients_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowUsers(users));
        }

        private void btn_show_bookings_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowBookings(bookings, users, rooms));
        }

        private void btn_add_booking_Click(object sender, EventArgs e)
        {
            openChildForm(new AddBooking(bookings, users, rooms));
        }
    }
}
