using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestPDR.Entities;

namespace TestPDR
{
    public partial class MainForm : Form
    {
        Answer[] results;
        private EFContext eFContext;
        List<Question> questions;
        int currentQuestionIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            eFContext = new EFContext();
            SeederDb.Seed(eFContext);
            questions = eFContext.Questions.Include(x => x.Answers).ToList();
            results = new Answer[questions.Count];
            loadQuestion();
        }
        private void loadQuestion()
        {
            lbTextQuestion.Text = questions[currentQuestionIndex].Text;
            lblCurrentQuestion.Text = $"{currentQuestionIndex + 1}/{questions.Count}";
            gbAnswers.Controls.Clear();
            int y = 37, dy = 20;
            foreach (var item in questions[currentQuestionIndex].Answers)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Location = new System.Drawing.Point(15, y);
                radioButton.Name = "radioButton1";
                radioButton.Size = new System.Drawing.Size(117, 24);
                radioButton.TabIndex = 2;
                radioButton.Tag = item;
                radioButton.TabStop = true;
                radioButton.Text = item.Text;
                radioButton.UseVisualStyleBackColor = true;
                this.gbAnswers.Controls.Add(radioButton);
                y = y + dy;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
           //Читаємо відповідь користувача
            var listRadioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (var rb in listRadioButtons)
            {
                if (rb.Checked)
                {
                    var answer = rb.Tag as Answer;
                    //MessageBox.Show(answer.IsTrue.ToString());
                    results[currentQuestionIndex] = answer;
                }
            }
            //Якщо ми дійшли до кінця тесту
            if (currentQuestionIndex == questions.Count - 1)
            {
                int count = questions.Count;
                int countTrue = 0;
                foreach (var item in results)
                {
                    if (item!=null)
                    {
                        if (item.IsTrue)
                        {
                            countTrue++;
                        }
                    }
                  
                }
                double mark = (100F * countTrue) / (double)count;
                MessageBox.Show("Ваша оцінка: " + mark.ToString());
                return;
            }
            else
            {
                currentQuestionIndex++;
                loadQuestion();
                if (currentQuestionIndex == questions.Count - 1)
                {
                    btnNext.Text = "Завершити тест";
                }
                else
                {
                    btnNext.Text = "Далі >>";
                }
            }
        }

        private void lbTextQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex == 0)
            {
                return;
            }
            currentQuestionIndex--;
            loadQuestion();
            if (currentQuestionIndex == questions.Count - 1)
            {
                btnNext.Text = "Завершити тест";
            }
            else
            {
                btnNext.Text = "Далі >>";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
    