namespace Bank.Forms.Client
{
    partial class frm_DeleteClient
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindDeleteClient = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.updownBalance = new System.Windows.Forms.NumericUpDown();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPinCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(552, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 53);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindDeleteClient
            // 
            this.btnFindDeleteClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnFindDeleteClient.Location = new System.Drawing.Point(377, 68);
            this.btnFindDeleteClient.Name = "btnFindDeleteClient";
            this.btnFindDeleteClient.Size = new System.Drawing.Size(135, 53);
            this.btnFindDeleteClient.TabIndex = 41;
            this.btnFindDeleteClient.Text = "Find";
            this.btnFindDeleteClient.UseVisualStyleBackColor = false;
            this.btnFindDeleteClient.Click += new System.EventHandler(this.btnFindDeleteClient_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.updownBalance);
            this.pnlInfo.Controls.Add(this.tbPhone);
            this.pnlInfo.Controls.Add(this.label9);
            this.pnlInfo.Controls.Add(this.tbLastName);
            this.pnlInfo.Controls.Add(this.label10);
            this.pnlInfo.Controls.Add(this.tbPinCode);
            this.pnlInfo.Controls.Add(this.label11);
            this.pnlInfo.Controls.Add(this.label12);
            this.pnlInfo.Controls.Add(this.tbEmail);
            this.pnlInfo.Controls.Add(this.label13);
            this.pnlInfo.Controls.Add(this.tbFirstName);
            this.pnlInfo.Controls.Add(this.label14);
            this.pnlInfo.Enabled = false;
            this.pnlInfo.Location = new System.Drawing.Point(114, 153);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(562, 274);
            this.pnlInfo.TabIndex = 52;
            // 
            // updownBalance
            // 
            this.updownBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownBalance.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownBalance.Location = new System.Drawing.Point(23, 207);
            this.updownBalance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownBalance.Name = "updownBalance";
            this.updownBalance.ReadOnly = true;
            this.updownBalance.Size = new System.Drawing.Size(205, 26);
            this.updownBalance.TabIndex = 29;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(299, 127);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(209, 26);
            this.tbPhone.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(299, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Phone";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(299, 57);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(209, 26);
            this.tbLastName.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Last Name";
            // 
            // tbPinCode
            // 
            this.tbPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinCode.Location = new System.Drawing.Point(303, 206);
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.ReadOnly = true;
            this.tbPinCode.Size = new System.Drawing.Size(209, 26);
            this.tbPinCode.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Pin Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Balance";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(19, 127);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(209, 26);
            this.tbEmail.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Email";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(19, 57);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(209, 26);
            this.tbFirstName.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "First Name";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber.Location = new System.Drawing.Point(128, 95);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(209, 26);
            this.tbAccountNumber.TabIndex = 51;
            this.tbAccountNumber.TextChanged += new System.EventHandler(this.tbAccountNumber_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(128, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Account Number";
            // 
            // frm_DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFindDeleteClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DeleteClient";
            this.Text = "frm_DeleteClient";
            this.Load += new System.EventHandler(this.frm_DeleteClient_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindDeleteClient;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.NumericUpDown updownBalance;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPinCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label label16;
    }
}