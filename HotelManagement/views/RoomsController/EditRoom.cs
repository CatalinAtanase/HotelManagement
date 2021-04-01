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
        public EditRoom(List<Room> rooms, Room room)
        {
            this.room = room;
            this.rooms = rooms;
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

            if (rooms.Any(r => r.Id == number && r.Id != room.Id))
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

                    room.Id = number;
                    room.Price = price;
                    room.Capacity = capacitate;
                    room.IsPremium = this.CB_camera_premium.Checked;

                    MessageBox.Show("Camera editata cu succes!");
                    this.Dispose();
                } catch (Exception ex)
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
