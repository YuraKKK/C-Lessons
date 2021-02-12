using DirectoryForm.Entities;
using DirectoryForm.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryForm
{
    public partial class MainForm : Form
    {
        string fileGirls = "girls.txt";
        public MainForm()
        {
            InitializeComponent();
            string folder = Directory.GetCurrentDirectory();
            RefreshGrid();
            fileGirls = Path.Combine(folder, fileGirls);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnAddGirl_Click(object sender, EventArgs e)
        {
            AddForm dlg = new AddForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }

        }

        private void RefreshGrid()
        {
            dgvGirls.Rows.Clear();
            MyContext context = new MyContext();
            var girls = context.Girls.AsQueryable();
            GirlSearch search = new GirlSearch();
            search.Name = txtSearchName.Text;
            string temp = txtSearchAge.Text;
            if (!string.IsNullOrEmpty(temp))
                search.Age = int.Parse(temp);
            temp = txtSearchWeight.Text;
            if (!string.IsNullOrEmpty(temp))
                search.Weight = int.Parse(temp);
            if (!string.IsNullOrEmpty(search.Name))
                girls = girls.Where(x => x.Name.Contains(search.Name));
            if(search.Age != 0)
                girls = girls.Where(x => x.Age == search.Age);
            if(search.Weight !=0)
                girls = girls.Where(x => x.Weight ==search.Weight);
            foreach (var girl in girls)
            {
                object[] row = {
                                $"{girl.Id}", 
                                $"{girl.Name}",
                                $"{girl.Age}",
                                $"{girl.Weight}"
                        };
                dgvGirls.Rows.Add(row);
            }
            //dgvGirls.Rows.Clear();
            //GirlSearch search = new GirlSearch();
            //search.Name = txtSearchName.Text;
            //string temp = txtSearchAge.Text;
            //if (!string.IsNullOrEmpty(temp))
            //    search.Age = int.Parse(temp);
            //using (StreamReader sw = new StreamReader(fileGirls))
            //{
            //    Girl girl = new Girl();
            //    while (true)
            //    {
            //        try
            //        {
            //            girl.Name = sw.ReadLine();
            //            girl.Age = int.Parse(sw.ReadLine());
            //            girl.Weight = int.Parse(sw.ReadLine());
            //            bool isFind = false;
            //            if (!string.IsNullOrEmpty(search.Name))
            //            {
            //                if (search.Age != 0)
            //                {
            //                    if (search.Name.Contains(girl.Name) && search.Age == girl.Age)
            //                        isFind = true;
            //                }
            //                else if (search.Name.Contains(girl.Name))
            //                    isFind = true;

                //            }
                //            else if (search.Age != 0)
                //            {
                //                if (search.Age == girl.Age)
                //                    isFind = true;
                //            }
                //            else isFind = true;
                //            if (isFind)

                //            {
                //                object[] row = {
                //                    $"{girl.Name}",
                //                    $"{girl.Age}",
                //                    $"{girl.Weight}"
                //            };
                //                dgvGirls.Rows.Add(row);
                //                //Console.WriteLine($"{girl.Name} {girl.Age} - {girl.Weight}");
                //            }
                //        }
                //        catch
                //        {
                //            break;
                //        }
                //    }
                //}

            }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext(); 
            context.Database.EnsureCreated();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ListUserForm dlg = new ListUserForm();
            dlg.ShowDialog();
        }

        private void btnDeleteGirl_Click(object sender, EventArgs e)
        {
            if (dgvGirls.SelectedRows.Count>0)
            {
                int id = int.Parse(dgvGirls.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(id.ToString());
                MyContext context = new MyContext();
                Girl girl = context.Girls.SingleOrDefault(x => x.Id == id);
                context.Girls.Remove(girl);
                context.SaveChanges();
                RefreshGrid();
            }
        
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvGirls.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvGirls.SelectedRows[0].Cells[0].Value.ToString());
                EditGirlForm dlg = new EditGirlForm(id);
                //MessageBox.Show(id.ToString());
                //RefreshGrid();
                if (dlg.ShowDialog() == DialogResult.OK)
                    RefreshGrid();
            }
        }
    }
}

