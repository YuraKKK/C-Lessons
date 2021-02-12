using PhonebookForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhonebookForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void RefreshGrid() 
        {
            dgvPhonebook.Rows.Clear();
            MyContext context = new MyContext();
            var people = context.People.AsQueryable();
            PeopleSearch search = new PeopleSearch();
            search.Name = txtName.Text;
            search.Surname = txtSurname.Text;
            string temp = txtPhoneNumber.Text;
            if (!string.IsNullOrEmpty(search.Name))
                people = people.Where(x => x.Name.Contains(search.Name));
            if (!string.IsNullOrEmpty(search.Surname))
                people = people.Where(x => x.Surname.Contains(search.Surname));
            if (!string.IsNullOrEmpty(search.PhoneNumber))
                people = people.Where(x => x.PhoneNumber.Contains(search.PhoneNumber));
            foreach (var people1 in people)
            {
                object[] row = {
                                $"{people1.Name}",
                                $"{people1.Surname}",
                                $"{people1.PhoneNumber}",
                        };
                dgvPhonebook.Rows.Add(row);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm dlg = new AddForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            context.Database.EnsureCreated();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhonebook.SelectedRows.Count > 0)
            {

            }
        }
    }


}




