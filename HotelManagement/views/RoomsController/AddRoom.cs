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
    public partial class AddRoom : Form
    {
        List<Room> rooms;
        public AddRoom(List<Room> r)
        {
            InitializeComponent();
            rooms = r;
        }

        private void tb_numar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_Add_Room_Click(object sender, EventArgs e)
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

            if (rooms.Any(r => r.Id == number))
            {
                isValid = false;
                MessageBox.Show("Exista o camera cu acest numar!");
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
                rooms.Add(new Room(number, Int32.Parse(this.Select_capacitate.Text), price, this.CB_camera_premium.Checked, false));
                foreach (Room room in rooms)
                {
                    Console.WriteLine(room);
                }
                tb_numar.Clear();
                tb_pret.Clear();
                Select_capacitate.SelectedIndex = -1;
                CB_camera_premium.Checked = false;
                MessageBox.Show("Camera adaugata cu succes!");
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
