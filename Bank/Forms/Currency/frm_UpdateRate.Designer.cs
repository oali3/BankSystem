namespace Bank.Forms.Currency
{
    partial class frm_UpdateRate
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
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updownRate = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRate
            // 
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(551, 122);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(209, 26);
            this.tbRate.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Current Rate";
            // 
            // rbCountry
            // 
            this.rbCountry.AutoSize = true;
            this.rbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountry.Location = new System.Drawing.Point(291, 69);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(89, 24);
            this.rbCountry.TabIndex = 77;
            this.rbCountry.Text = "Country";
            this.rbCountry.UseVisualStyleBackColor = true;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Checked = true;
            this.rbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCode.Location = new System.Drawing.Point(214, 69);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(69, 24);
            this.rbCode.TabIndex = 76;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "Code";
            this.rbCode.UseVisualStyleBackColor = true;
            this.rbCode.CheckedChanged += new System.EventHandler(this.rbCode_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(93, 247);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(209, 53);
            this.btnFind.TabIndex = 75;
            this.btnFind.Text = "Find Currency";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(93, 185);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(209, 26);
            this.tbInput.TabIndex = 74;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(89, 162);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(47, 20);
            this.lbInput.TabIndex = 73;
            this.lbInput.Text = "Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Find Currency by : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "New Rate";
            // 
            // updownRate
            // 
            this.updownRate.Enabled = false;
            this.updownRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownRate.Location = new System.Drawing.Point(551, 185);
            this.updownRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownRate.Name = "updownRate";
            this.updownRate.Size = new System.Drawing.Size(209, 29);
            this.updownRate.TabIndex = 80;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(551, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 53);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Update Rate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frm_UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updownRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbCountry);
            this.Controls.Add(this.rbCode);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_UpdateRate";
            this.Text = "frm_UpdateRate";
            this.Load += new System.EventHandler(this.frm_UpdateRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbCode;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updownRate;
        private System.Windows.Forms.Button btnUpdate;
    }
}