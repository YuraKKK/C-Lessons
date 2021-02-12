using DirectoryForm.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace DirectoryForm
{
    public partial class AddForm : Form
    {
        string fileGirls = "girls.txt";
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAddGirl_Click(object sender, EventArgs e)
        {
            Girl girl = new Girl();
            girl.Name = txtName.Text;
            girl.Age = int.Parse(txtAge.Text);
            girl.Weight = int.Parse(txtWeight.Text);
            try
            {
                MyContext context = new MyContext();
                context.Girls.Add(girl);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            //try
            //{
            //    Girl girl = new Girl();

            //    girl.Name = txtName.Text;
            //    girl.Age = int.Parse(txtAge.Text);
            //    girl.Weight = int.Parse(txtWeight.Text);
            //    using (StreamWriter sw = new StreamWriter(fileGirls, true))
            //    {

            //        sw.WriteLine(girl.Name);
            //        sw.WriteLine(girl.Age);
            //        sw.WriteLine(girl.Weight);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Проблема при створені {0}", ex.Message);
            //}
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
