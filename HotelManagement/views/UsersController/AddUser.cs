using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.UsersController
{
    public partial class AddUser : Form
    {
        List<User> users;
        public AddUser(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void Btn_Add_User_Click(object sender, EventArgs e)
        {
            string firstName = this.tb_prenume.Text.Trim(); 
            string lastName = this.tb_nume.Text.Trim();
            string phone = this.tb_telefon.Text.Trim();
            string cnp = this.tb_cnp.Text.Trim();
            string email = this.tb_email.Text.Trim();
            bool isValid = true;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (String.IsNullOrEmpty(lastName))
            {
                isValid = false;
                errorProvider1.SetError(tb_nume, "Nu ati completat corect campul de nume!");
            }

            else if (String.IsNullOrEmpty(firstName))
            {
                isValid = false;
                errorProvider1.SetError(tb_prenume, "Nu ati completat corect campul de prenume!");
            }

            else if (String.IsNullOrEmpty(cnp) || cnp.Length != 13)
            {
                isValid = false;
                errorProvider1.SetError(tb_cnp, "Nu ati completat corect campul de CNP!");
            }

            else if(users.Any(u => u.Cnp == cnp))
            {
                isValid = false;
                MessageBox.Show("Exista un client cu acest cnp!");
            }

            else if (String.IsNullOrEmpty(email) || !match.Success)
            {
                isValid = false;
                errorProvider1.SetError(tb_email, "Nu ati completat corect campul de email!");
            }
            
            else if (String.IsNullOrEmpty(phone))
            {
                isValid = false;
                errorProvider1.SetError(tb_telefon, "Nu ati completat corect campul de telefon!");
            }

            if (isValid)
            {
                try
                {
                    users.Add(new User(firstName, lastName, cnp, email, phone));
                    this.tb_nume.Clear();
                    this.tb_prenume.Clear();
                    this.tb_email.Clear();
                    this.tb_cnp.Clear();
                    this.tb_telefon.Clear();

                    MessageBox.Show("Client adaugat cu succes!");
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
