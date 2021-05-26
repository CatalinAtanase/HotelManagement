using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.RoomsController
{
    public partial class EditRoom : Form
    {
        public List<Room> rooms;
        public Room room;
        string roomsPath;
        List<Booking> bookings;
        string bookingsPath;

        public event CallBack SaveObjects;
        public EditRoom(List<Room> rooms, Room room, string roomsPath, List<Booking> bookings, string bookingsPath)
        {
            this.room = room;
            this.rooms = rooms;
            this.roomsPath = roomsPath;
            this.bookings = bookings;
            this.bookingsPath = bookingsPath;
            InitializeComponent();
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            this.tb_numar.Text = room.Id.ToString();
            this.tb_pret.Text = room.Price.ToString();
            this.CB_camera_premium.Checked = room.IsPremium;
            this.Select_capacitate.SelectedIndex = room.Capacity - 1;
        }

        private void Btn_FinishEdit_Room_Click(object sender, EventArgs e)
        {
            int number = -1;
            double price = -1;
            int capacitate = -1;
            bool isValid = true;

            if (!Int32.TryParse(this.tb_numar.Text, out number))
            {
                isValid = false;
                MessageBox.Show("Numar invalid!");
            }

            if (rooms.Any(r => r.Id == number && r.CompareTo(room) != 0))
            {
                isValid = false;
                MessageBox.Show("Exista o camera cu acest numar!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!Double.TryParse(this.tb_pret.Text, out price))
            {
                isValid = false;
                MessageBox.Show("Pret invalid!");
            }

            if (!Int32.TryParse(this.Select_capacitate.Text, out capacitate))
            {
                isValid = false;
                MessageBox.Show("Capacitate invalida!");
            }

            if (capacitate > 3)
            {
                isValid = false;
                MessageBox.Show("Capacitate invalida!");
            }

            if (isValid)
            {
                try
                {
                    List<Booking> tempBookings;
                    tempBookings = bookings.FindAll((b) => b.RoomId == room.Id);

                    room.Id = number;
                    room.Price = price;
                    room.Capacity = capacitate;
                    room.IsPremium = this.CB_camera_premium.Checked;

                    SaveObjects?.Invoke(rooms, roomsPath);

                    foreach (Booking booking in bookings)
                    {
                        if (tempBookings.Contains(booking))
                        {
                            booking.RoomId = room.Id;
                        }
                    }
                    SaveObjects?.Invoke(bookings, bookingsPath);

                    MessageBox.Show("Camera editata cu succes! Toate rezervarile au fost reatribuite!");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void numberKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '.');
        }
    }
}
