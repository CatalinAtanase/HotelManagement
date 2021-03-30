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
        public ShowUsers(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            displayList();
        }

        private void displayList()
        {
            dgv_users.Rows.Clear();
            users.Sort((a, b) => String.Compare(a.LastName, b.LastName));
            foreach (User u in users)
            {
                int rowIndex = this.dgv_users.Rows.Add(u.LastName, u.FirstName, u.Email, u.Cnp, u.Phone);
                this.dgv_users.Rows[rowIndex].Tag = u;
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_users.SelectedRows[0];
                User user= (User)selectedRow.Tag;
                users.Remove(user);
                MessageBox.Show("Client sters cu succes!");
                displayList();
            }
        }

        private void Btn_Edit_Room_Click(object sender, EventArgs e)
        {
            if (dgv_users.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgv_users.SelectedRows[0];
                User user = (User)selectedRow.Tag;
                Form editUser = new EditUser(users, user);
                editUser.ShowDialog();
                displayList();
            }
        }
    }
}
