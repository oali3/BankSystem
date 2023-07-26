namespace Bank.Forms.Users
{
    partial class frm_UpdateUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCurrency = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCurrency);
            this.groupBox1.Controls.Add(this.chkTransactions);
            this.groupBox1.Controls.Add(this.chkManageClients);
            this.groupBox1.Controls.Add(this.chkManageUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(371, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 166);
            this.groupBox1.TabIndex = 70;
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
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(371, 32);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(107, 28);
            this.chkAll.TabIndex = 69;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.Click += new System.EventHandler(this.chkAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(606, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 53);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.tbPhone);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.tbLastName);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.tbPassword);
            this.pnlInfo.Controls.Add(this.chkAll);
            this.pnlInfo.Controls.Add(this.groupBox1);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.tbEmail);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.tbFirstName);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Enabled = false;
            this.pnlInfo.Location = new System.Drawing.Point(6, 115);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(963, 311);
            this.pnlInfo.TabIndex = 75;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(105, 142);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(209, 26);
            this.tbPhone.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(105, 81);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(209, 26);
            this.tbLastName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Last Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(105, 264);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(209, 26);
            this.tbPassword.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(105, 203);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(209, 26);
            this.tbEmail.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(105, 20);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(209, 26);
            this.tbFirstName.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "First Name";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(377, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(173, 53);
            this.btnFind.TabIndex = 74;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(111, 51);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(209, 26);
            this.tbUserName.TabIndex = 72;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 71;
            this.label16.Text = "User Name";
            // 
            // frm_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_UpdateUser";
            this.Text = "frm_UpdateUser";
            this.Load += new System.EventHandler(this.frm_UpdateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCurrency;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkManageClients;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label16;
    }
}