namespace Bank.Forms.Users
{
    partial class frm_AddNewUser
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCurrency = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(443, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 53);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(72, 359);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(209, 26);
            this.tbPhone.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(72, 299);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(209, 26);
            this.tbLastName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Last Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(72, 236);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(209, 26);
            this.tbPassword.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(72, 173);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(209, 26);
            this.tbEmail.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(72, 110);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(209, 26);
            this.tbFirstName.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "First Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(72, 47);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(209, 26);
            this.tbUserName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "UserName";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(339, 50);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(107, 28);
            this.chkAll.TabIndex = 53;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCurrency);
            this.groupBox1.Controls.Add(this.chkTransactions);
            this.groupBox1.Controls.Add(this.chkManageClients);
            this.groupBox1.Controls.Add(this.chkManageUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(339, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 166);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkCurrency
            // 
            this.chkCurrency.AutoSize = true;
            this.chkCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrency.Location = new System.Drawing.Point(187, 93);
            this.chkCurrency.Name = "chkCurrency";
            this.chkCurrency.Size = new System.Drawing.Size(156, 22);
            this.chkCurrency.TabIndex = 58;
            this.chkCurrency.Text = "Currency Exchange";
            this.chkCurrency.UseVisualStyleBackColor = true;
            this.chkCurrency.Click += new System.EventHandler(this.chkManageUsers_Click);
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransactions.Location = new System.Drawing.Point(24, 93);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(113, 22);
            this.chkTransactions.TabIndex = 57;
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = true;
            this.chkTransactions.Click += new System.EventHandler(this.chkManageUsers_Click);
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageClients.Location = new System.Drawing.Point(187, 42);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(129, 22);
            this.chkManageClients.TabIndex = 56;
            this.chkManageClients.Text = "Manage Clients";
            this.chkManageClients.UseVisualStyleBackColor = true;
            this.chkManageClients.Click += new System.EventHandler(this.chkManageUsers_Click);
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.Location = new System.Drawing.Point(24, 42);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(124, 22);
            this.chkManageUsers.TabIndex = 55;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            this.chkManageUsers.Click += new System.EventHandler(this.chkManageUsers_Click);
            // 
            // frm_AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddNewUser";
            this.Text = "frm_AddNewUser";
            this.Load += new System.EventHandler(this.frm_AddNewUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkCurrency;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkManageClients;
    }
}