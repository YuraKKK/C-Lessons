
namespace DirectoryForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchAge = new System.Windows.Forms.TextBox();
            this.btnAddGirl = new System.Windows.Forms.Button();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtSearchWeight = new System.Windows.Forms.TextBox();
            this.btnDeleteGirl = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGirls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirls)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(236, 107);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 59);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchName.Location = new System.Drawing.Point(12, 45);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(302, 34);
            this.txtSearchName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(335, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вік";
            // 
            // txtSearchAge
            // 
            this.txtSearchAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchAge.Location = new System.Drawing.Point(335, 45);
            this.txtSearchAge.Name = "txtSearchAge";
            this.txtSearchAge.Size = new System.Drawing.Size(302, 34);
            this.txtSearchAge.TabIndex = 2;
            // 
            // btnAddGirl
            // 
            this.btnAddGirl.Location = new System.Drawing.Point(12, 107);
            this.btnAddGirl.Name = "btnAddGirl";
            this.btnAddGirl.Size = new System.Drawing.Size(139, 59);
            this.btnAddGirl.TabIndex = 4;
            this.btnAddGirl.Text = "Додати";
            this.btnAddGirl.UseVisualStyleBackColor = true;
            this.btnAddGirl.Click += new System.EventHandler(this.btnAddGirl_Click);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.ForeColor = System.Drawing.Color.Blue;
            this.lbWeight.Location = new System.Drawing.Point(657, 21);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(51, 28);
            this.lbWeight.TabIndex = 1;
            this.lbWeight.Text = "Вага";
            // 
            // txtSearchWeight
            // 
            this.txtSearchWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchWeight.Location = new System.Drawing.Point(657, 45);
            this.txtSearchWeight.Name = "txtSearchWeight";
            this.txtSearchWeight.Size = new System.Drawing.Size(302, 34);
            this.txtSearchWeight.TabIndex = 2;
            // 
            // btnDeleteGirl
            // 
            this.btnDeleteGirl.Location = new System.Drawing.Point(454, 107);
            this.btnDeleteGirl.Name = "btnDeleteGirl";
            this.btnDeleteGirl.Size = new System.Drawing.Size(139, 59);
            this.btnDeleteGirl.TabIndex = 5;
            this.btnDeleteGirl.Text = "Видалити";
            this.btnDeleteGirl.UseVisualStyleBackColor = true;
            this.btnDeleteGirl.Click += new System.EventHandler(this.btnDeleteGirl_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(690, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 59);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(837, 470);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(175, 81);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Робота з користувачем\r\n";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // colId
            // 
            this.colId.HeaderText = "MyId";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Ім\'я";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Вік";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAge.Width = 125;
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Вага";
            this.colWeight.MinimumWidth = 6;
            this.colWeight.Name = "colWeight";
            this.colWeight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWeight.Width = 125;
            // 
            // dgvGirls
            // 
            this.dgvGirls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGirls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colWeight});
            this.dgvGirls.Location = new System.Drawing.Point(12, 202);
            this.dgvGirls.Name = "dgvGirls";
            this.dgvGirls.RowHeadersWidth = 51;
            this.dgvGirls.Size = new System.Drawing.Size(817, 349);
            this.dgvGirls.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 587);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteGirl);
            this.Controls.Add(this.btnAddGirl);
            this.Controls.Add(this.dgvGirls);
            this.Controls.Add(this.txtSearchWeight);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.txtSearchAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Довідник";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGirls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchAge;
        private System.Windows.Forms.DataGridView dgvGirls;
        internal System.Windows.Forms.Button btnAddGirl;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtSearchWeight;
        private System.Windows.Forms.Button btnDeleteGirl;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
    }
}

