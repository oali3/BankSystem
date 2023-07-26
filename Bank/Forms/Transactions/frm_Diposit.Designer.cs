namespace Bank.Forms.Transactions
{
    partial class frm_Diposit
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPinCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.updownDiposit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updownDiposit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(511, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(205, 53);
            this.btnDeposit.TabIndex = 53;
            this.btnDeposit.Text = "Diposi";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber.Location = new System.Drawing.Point(190, 59);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.ReadOnly = true;
            this.tbAccountNumber.Size = new System.Drawing.Size(209, 26);
            this.tbAccountNumber.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Account Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(190, 151);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(209, 26);
            this.tbFirstName.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(190, 289);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(209, 26);
            this.tbEmail.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Pin Code";
            // 
            // tbPinCode
            // 
            this.tbPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinCode.Location = new System.Drawing.Point(190, 105);
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.ReadOnly = true;
            this.tbPinCode.Size = new System.Drawing.Size(209, 26);
            this.tbPinCode.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(190, 197);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(209, 26);
            this.tbLastName.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(190, 243);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(209, 26);
            this.tbPhone.TabIndex = 28;
            // 
            // tbBalance
            // 
            this.tbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.Location = new System.Drawing.Point(190, 335);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(209, 26);
            this.tbBalance.TabIndex = 56;
            // 
            // updownDiposit
            // 
            this.updownDiposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownDiposit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownDiposit.Location = new System.Drawing.Point(511, 137);
            this.updownDiposit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownDiposit.Name = "updownDiposit";
            this.updownDiposit.Size = new System.Drawing.Size(205, 29);
            this.updownDiposit.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Diposit Ammount";
            // 
            // frm_Diposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updownDiposit);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbPinCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Diposit";
            this.Text = "frm_Diposit";
            this.Load += new System.EventHandler(this.frm_Diposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownDiposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPinCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.NumericUpDown updownDiposit;
        private System.Windows.Forms.Label label1;
    }
}