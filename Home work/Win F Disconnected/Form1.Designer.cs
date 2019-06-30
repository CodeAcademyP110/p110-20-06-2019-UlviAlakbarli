namespace Win_F_Disconnected
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numsalary = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.Label();
            this.newPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 165);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(800, 285);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmployees_CellContentDoubleClick);
            this.dataGridViewEmployees.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewEmployees_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newPos);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbpos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numsalary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.Firstname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 159);
            this.panel1.TabIndex = 1;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(161, 119);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 23);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Lime;
            this.btnedit.Location = new System.Drawing.Point(19, 119);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(120, 23);
            this.btnedit.TabIndex = 10;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Position";
            // 
            // cmbpos
            // 
            this.cmbpos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpos.FormattingEnabled = true;
            this.cmbpos.Location = new System.Drawing.Point(161, 78);
            this.cmbpos.Name = "cmbpos";
            this.cmbpos.Size = new System.Drawing.Size(121, 21);
            this.cmbpos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salary";
            // 
            // numsalary
            // 
            this.numsalary.DecimalPlaces = 2;
            this.numsalary.Location = new System.Drawing.Point(19, 78);
            this.numsalary.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numsalary.Name = "numsalary";
            this.numsalary.Size = new System.Drawing.Size(120, 20);
            this.numsalary.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lastname";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(295, 20);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(108, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(161, 20);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(121, 20);
            this.txtlastname.TabIndex = 2;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(19, 20);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(120, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(16, 4);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(52, 13);
            this.Firstname.TabIndex = 0;
            this.Firstname.Text = "Firstname";
            // 
            // newPos
            // 
            this.newPos.Location = new System.Drawing.Point(533, 20);
            this.newPos.Name = "newPos";
            this.newPos.Size = new System.Drawing.Size(172, 23);
            this.newPos.TabIndex = 12;
            this.newPos.Text = "New Position";
            this.newPos.UseVisualStyleBackColor = true;
            this.newPos.Click += new System.EventHandler(this.NewPos_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numsalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpos;
        private System.Windows.Forms.Button newPos;
    }
}

