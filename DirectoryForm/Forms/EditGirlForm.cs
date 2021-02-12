using DirectoryForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryForm
{
    public partial class EditGirlForm : Form
    {
        private int _id;
        public EditGirlForm(int id)
        { 
            _id = id;
            InitializeComponent();
            MyContext context = new MyContext();
            Girl girl = context.Girls.SingleOrDefault(x => x.Id == id);
            txtName.Text = girl.Name;
            txtAge.Text = girl.Age.ToString();
            txtWeight.Text = girl.Weight.ToString();
        }

        private void btnAddGirl_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            Girl girl = context.Girls.SingleOrDefault(x => x.Id == _id);
            girl.Name = txtName.Text;
            girl.Age = int.Parse(txtAge.Text);
            girl.Weight = int.Parse(txtWeight.Text);
            context.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
