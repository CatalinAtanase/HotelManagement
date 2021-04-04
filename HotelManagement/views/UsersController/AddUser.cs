﻿using System;
using System.Collections;
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
        string savePath;
        ArrayList emails = new ArrayList();

        public event CallBack SaveUsers;

        public AddUser(List<User> users, string savePath)
        {
            InitializeComponent();
            this.users = users;
            this.savePath = savePath;
            this.emails.Add(this.tb_email);
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
            string[] emailValues = new string[emails.Count];


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

            else if (String.IsNullOrEmpty(phone))
            {
                isValid = false;
                errorProvider1.SetError(tb_telefon, "Nu ati completat corect campul de telefon!");
            }

            if (isValid)
            {

                for(int i = 0; i < emails.Count; i++)
                {
                    TextBox tb = (TextBox)emails[i];

                    if(String.IsNullOrEmpty(tb.Text) || !match.Success)
                    {
                        errorProvider1.SetError(tb, "Nu ati completat corect campul de email");
                        return;
                    }
                }

                try
                {
                    User newUser = new User(firstName, lastName, cnp, phone);
                    for(int i = 0; i < emailValues.Length; i++)
                    {
                        if(emailValues.Contains(((TextBox)emails[i]).Text))
                        {
                            MessageBox.Show("Adresa de mail deja exista!");
                            return;
                        }
                        emailValues[i] = ((TextBox)emails[i]).Text;
                    }
                    newUser.Emails = new string[emailValues.Length];
                    emailValues.CopyTo(newUser.Emails, 0);

                    users.Add(newUser);
                    SaveUsers?.Invoke(users, savePath);

                    MessageBox.Show("Client adaugat cu succes!");

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    this.tb_nume.Clear();
                    this.tb_prenume.Clear();
                    this.tb_cnp.Clear();
                    this.tb_telefon.Clear();
                    for (int i = 0; i < emails.Count; i++)
                    {
                        ((TextBox)emails[i]).Clear();
                    }
                    errorProvider1.Clear();
                }
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_add_email_Click(object sender, EventArgs e)
        {
            if (this.emails.Count < 3)
            {

                int x = ((TextBox)emails[0]).Location.X;
                int y = ((TextBox)emails[emails.Count - 1]).Location.Y;

                TextBox tb = new TextBox();
                tb.Location = new Point(x, y + 50);
                tb.Size = new System.Drawing.Size(198, 50);
                emails.Add(tb);
                this.Controls.Add(tb);
            }
        }

        private void btn_remove_email_Click(object sender, EventArgs e)
        {
            if(this.emails.Count > 1) {
                this.Controls.Remove((TextBox)this.emails[emails.Count - 1]);
                this.emails.RemoveAt(emails.Count - 1);
            }
        }
    }
}
