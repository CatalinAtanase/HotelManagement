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
        string usersPath;
        string bookingsPath;
        List<Booking> bookings;

        public event CallBack SaveObjects;
        public EditUser(List<User> users, User user, string usersPath, List<Booking> bookings, string bookingsPath)
        {
            InitializeComponent();
            this.user = user;
            this.users = users;
            this.usersPath = usersPath;
            this.bookings = bookings;
            this.bookingsPath = bookingsPath;
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

            else if (String.IsNullOrEmpty(firstName))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de prenume!");
            }

            else if (String.IsNullOrEmpty(cnp) || cnp.Length != 13)
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de CNP!");
            }

            else if (users.Any(u => u.Cnp == cnp && u.CompareTo(user) != 0))
            {
                isValid = false;
                MessageBox.Show("Exista un client cu acest cnp!");
            }

            else if (String.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de email!");
            }

            else if (String.IsNullOrEmpty(phone))
            {
                isValid = false;
                MessageBox.Show("Nu ati completat corect campul de telefon!");
            }

            if (isValid)
            {
                try
                {
                    List<Booking> tempBookings;
                    tempBookings = bookings.FindAll((b) => b.UserCNP == user.Cnp);

                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.Phone = phone;
                    user.Email = email;
                    user.Cnp = cnp;

                    SaveObjects?.Invoke(users, usersPath);

                    foreach (Booking booking in bookings)
                    {
                        if (tempBookings.Contains(booking))
                        {
                            booking.UserCNP = user.Cnp;
                        }
                    }
                    SaveObjects?.Invoke(bookings, bookingsPath);

                    MessageBox.Show("Datele clientului au fost editate cu succes! Toate rezervarile au fost reatribuite!");
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
