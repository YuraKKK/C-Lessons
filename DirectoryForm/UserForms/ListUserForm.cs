using DirectoryForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DirectoryForm.UserForms
{
    public partial class ListUserForm : Form
    {
        public ListUserForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm dlg = new AddUserForm();
            dlg.ShowDialog();
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            MyContext context = new MyContext();
            dgvUsers.Rows.Clear();
            var users = context.Users;
            foreach (var user in users)
            {
                object[] row = {
                                $"{user.FirstName}",
                                $"{user.LastName}",

                        };
                dgvUsers.Rows.Add(row);
            }
        }
    }
}
