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

        private void Btn_Add_Room_Click(object sender, EventArgs e)
        {
            int number = -1;
            double price = -1;
            int capacitate = -1;
            bool isValid = true;


            if (!Int32.TryParse(this.tb_numar.Text, out number))
            {
                isValid = false;
                errorProvider1.SetError(tb_numar, "Numar invalid");
            }

            else if (rooms.Any(r => r.Id == number))
            {
                isValid = false;
                errorProvider1.SetError(tb_numar, "Exista o camera cu acest numar!");

            }

            else if (!Double.TryParse(this.tb_pret.Text, out price))
            {
                isValid = false;
                errorProvider1.SetError(tb_pret, "Pret invalid!");

            }

            else if (!Int32.TryParse(this.Select_capacitate.Text, out capacitate))
            {
                isValid = false;
                errorProvider1.SetError(Select_capacitate, "Capacitate invalida!");

            }

            else if (capacitate > 3)
            {
                isValid = false;
                errorProvider1.SetError(Select_capacitate, "Capacitate invalida!");
            }

            if (isValid)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void numberKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '.');
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
