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
    public partial class DeleteBookings : Form
    {
        List<Booking> bookings = new List<Booking>();
        List<User> users = new List<User>();
        string bookingsPath;
        public event CallBack SaveObjects;

        public DeleteBookings(List<Booking> bookings, List<User> users, string bookingsPath)
        {
            InitializeComponent();
            this.bookings = bookings;
            this.users = users;
            this.bookingsPath = bookingsPath;
            displayList();
        }

        public void displayList()
        {
            this.dgv_bookings.Rows.Clear();
            bookings.Sort((a, b) => DateTime.Compare(a.StartDate, b.StartDate));
            foreach (Booking b in bookings)
            {
                try
                {
                    User rowUser = users.Find((u) => u.Cnp == b.UserCNP);
                    int index = this.dgv_bookings.Rows.Add(rowUser.getFullName(), b.StartDate.ToShortDateString(), b.EndDate.ToShortDateString(), b.RoomId);
                    this.dgv_bookings.Rows[index].Tag = b;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgv_bookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_bookings_MouseDown(object sender, MouseEventArgs e)
        {
            Booking booking = (Booking)dgv_bookings.CurrentRow.Tag;
            dgv_bookings.DoDragDrop(booking, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            Booking b = (Booking)e.Data.GetData(typeof(Booking));
            bookings.Remove(b);
            SaveObjects?.Invoke(bookings, bookingsPath);
            displayList();
        }
    }
}
