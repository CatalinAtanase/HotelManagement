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
    public partial class ShowUsers : Form
    {
        List<User> users;
        string usersPath;
        string bookingsPath;
        List<Booking> bookings;
        List<Room> rooms;
        string roomsPath;

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

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_users.SelectedRows[0];
                User user= (User)selectedRow.Tag;


                rooms.Find(r => r.Id == bookings.Find(b => b.UserCNP == user.Cnp).RoomId).IsBooked = false;
                SaveObjects?.Invoke(rooms, roomsPath);

                bookings.RemoveAll((b) => b.UserCNP == user.Cnp);
                SaveObjects?.Invoke(bookings, bookingsPath);

                users.Remove(user);
                SaveObjects?.Invoke(users, usersPath);

                MessageBox.Show("Client sters cu succes! Rezervarile acestuia au fost sterse!");
                displayList();
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_users.SelectedRows[0];
                User user = (User)selectedRow.Tag;
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

                    List<Booking> bookingsFound = bookings.FindAll(b => b.UserCNP == user.Cnp);
                    if (bookingsFound.Count != 0)
                    {
                        List<Room> roomsFound = rooms.FindAll(r => r.Id == bookings.Find(b => b.UserCNP == user.Cnp).RoomId);
                        foreach (Room r in roomsFound)
                        {
                            r.IsBooked = false;
                        }
                    }
                    SaveObjects?.Invoke(rooms, roomsPath);

                    bookings.RemoveAll((b) => b.UserCNP == user.Cnp);
                    SaveObjects?.Invoke(bookings, bookingsPath);

                    users.Remove(user);
                    SaveObjects?.Invoke(users, usersPath);

                    MessageBox.Show("Client sters cu succes! Rezervarile acestuia au fost sterse!");
                    displayList();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Nu exista rezervari");
            }

        }
    }
}
