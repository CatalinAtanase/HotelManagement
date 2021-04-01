using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.UsersController
{
    public partial class EditUser : Form
    {
        List<User> users;
        User user;
        public EditUser(List<User> users, User user)
        {
            InitializeComponent();
            this.user = user;
            this.users = users;
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Edit_User_Click(object sender, EventArgs e)
        {


            string firstName = this.tb_prenume.Text.Trim();
            string lastName = this.tb_nume.Text.Trim();
            string phone = this.tb_telefon.Text.Trim();
            string cnp = this.tb_cnp.Text.Trim();
            string email = this.tb_email.Text.Trim();
            bool isValid = true;

            if (String.IsNullOrEmpty(lastName))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de nume!");
            }

            if (String.IsNullOrEmpty(firstName))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de prenume!");
            }

            if (String.IsNullOrEmpty(cnp) || cnp.Length != 13)
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de CNP!");
            }

            if (users.Any(u => u.Cnp == cnp && user.Cnp != u.Cnp))
            {
                isValid = false;
                MessageBox.Show("Exista un client cu acest cnp!");
            }

            if (String.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de email!");
            }

            if (String.IsNullOrEmpty(phone))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de telefon!");
            }

            if (isValid)
            {
                try
                {

                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.Phone = phone;
                    user.Email = email;
                    user.Cnp = cnp;

                    MessageBox.Show("Datele clientului au fost editate cu succes!");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            this.tb_prenume.Text = user.FirstName;
            this.tb_nume.Text = user.LastName;
            this.tb_telefon.Text = user.Phone;
            this.tb_cnp.Text = user.Cnp;
            this.tb_email.Text = user.Email;
        }
    }
}
