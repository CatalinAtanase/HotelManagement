using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.views.UsersController
{
    public partial class ShowUsers : Form
    {
        List<User> users;
        string usersPath;
        string bookingsPath;
        List<Booking> bookings;
        List<Room> rooms;
        string roomsPath;
        string connStr;

        public event CallBack SaveObjects;

        public ShowUsers(List<User> users, string usersPath, List<Booking> bookings, string bookingsPath, List<Room> rooms, string roomsPath)
        {
            InitializeComponent();
            this.users = users;
            this.usersPath = usersPath;
            this.roomsPath = roomsPath;
            this.bookings = bookings;
            this.rooms = rooms;
            this.bookingsPath = bookingsPath;
            displayList();
            //displayListFromDb();
            connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DB.accdb";

        }

        private void displayList()
        {
            dgv_users.Rows.Clear();
            users.Sort((a, b) => String.Compare(a.LastName, b.LastName));
            foreach (User u in users)
            {
                string emails = string.Join(", ", u.Emails);
                int rowIndex = this.dgv_users.Rows.Add(u.LastName, u.FirstName, emails, u.Cnp, u.Phone);
                this.dgv_users.Rows[rowIndex].Tag = u;
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                try
                {
                    using (var conn = new OleDbConnection(connStr))
                    using (var myCommand = conn.CreateCommand())
                    {
                        var cnpParam = new OleDbParameter("@CNP", dgv_users.SelectedRows[0].Cells[3].Value.ToString());
                        string query = "DELETE FROM users WHERE (CNP) = @CNP;";
                        myCommand.CommandText = query;
                        myCommand.Parameters.Add(cnpParam);

                        conn.Open();
                        myCommand.ExecuteNonQuery();

                        User user = (User)dgv_users.SelectedRows[0].Tag;
                        bookings.RemoveAll((b) => b.UserCNP == user.Cnp);
                        users.Remove(user);

                        MessageBox.Show("Client sters cu succes! Rezervarile acestuia au fost sterse!");
                        displayList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_users.SelectedRows[0];
                User user = (User)selectedRow.Tag;
                MessageBox.Show(user.ToString());
                EditUser editUser = new EditUser(users, user, usersPath, bookings, bookingsPath);
                editUser.SaveObjects += SaveObjects;
                editUser.ShowDialog();
                displayList();
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCol = dgv_users.SelectedCells[0];

            if (dgv_users.SelectedCells.Count == 1)
            {
                DataGridViewRow selectedRow = selectedCol.OwningRow;
                User user = (User)selectedRow.Tag;
                EditUser editUser = new EditUser(users, user, usersPath, bookings, bookingsPath);
                editUser.SaveObjects += SaveObjects;
                editUser.ShowDialog();
                displayList();
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewCell selectedCol = dgv_users.SelectedCells[0];

                if (dgv_users.SelectedCells.Count == 1)
                {
                    DataGridViewRow selectedRow = selectedCol.OwningRow;
                    User user = (User)selectedRow.Tag;

                    try
                    {
                        using (var conn = new OleDbConnection(connStr))
                        using (var myCommand = conn.CreateCommand())
                        {
                            var cnpParam = new OleDbParameter("@CNP", dgv_users.SelectedRows[0].Cells[3].Value.ToString());
                            string query = "DELETE FROM users WHERE (CNP) = @CNP;";
                            myCommand.CommandText = query;
                            myCommand.Parameters.Add(cnpParam);

                            conn.Open();
                            myCommand.ExecuteNonQuery();

                            bookings.RemoveAll((b) => b.UserCNP == user.Cnp);
                            users.Remove(user);

                            MessageBox.Show("Client sters cu succes! Rezervarile acestuia au fost sterse!");
                            displayList();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    displayList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nu exista rezervari");
            }

        }
    }
}
