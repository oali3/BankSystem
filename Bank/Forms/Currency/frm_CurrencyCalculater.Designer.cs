namespace Bank.Forms.Currency
{
    partial class frm_CurrencyCalculater
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
            this.btnExchange = new System.Windows.Forms.Button();
            this.updownAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.tb2Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb2Rate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb2Country = new System.Windows.Forms.TextBox();
            this.tb2Code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn2Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExchange.Enabled = false;
            this.btnExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.White;
            this.btnExchange.Location = new System.Drawing.Point(315, 229);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(209, 53);
            this.btnExchange.TabIndex = 93;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // updownAmount
            // 
            this.updownAmount.Enabled = false;
            this.updownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownAmount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownAmount.Location = new System.Drawing.Point(315, 167);
            this.updownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.updownAmount.Name = "updownAmount";
            this.updownAmount.Size = new System.Drawing.Size(209, 29);
            this.updownAmount.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Exchange Amount";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(69, 363);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(209, 53);
            this.btnFind.TabIndex = 88;
            this.btnFind.Text = "Find Currency";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(69, 100);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(209, 26);
            this.tbCode.TabIndex = 87;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(65, 77);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(47, 20);
            this.lbInput.TabIndex = 86;
            this.lbInput.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 94;
            this.label2.Text = "First Country";
            // 
            // tbRate
            // 
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(69, 302);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(209, 26);
            this.tbRate.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 98;
            this.label3.Text = "Rate";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(69, 229);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(209, 26);
            this.tbName.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Country";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(69, 165);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(209, 26);
            this.tbCountry.TabIndex = 99;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(348, 343);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 20);
            this.lbResult.TabIndex = 94;
            // 
            // tb2Name
            // 
            this.tb2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2Name.Location = new System.Drawing.Point(581, 231);
            this.tb2Name.Name = "tb2Name";
            this.tb2Name.ReadOnly = true;
            this.tb2Name.Size = new System.Drawing.Size(209, 26);
            this.tb2Name.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 107;
            this.label7.Text = "Name";
            // 
            // tb2Rate
            // 
            this.tb2Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2Rate.Location = new System.Drawing.Point(581, 304);
            this.tb2Rate.Name = "tb2Rate";
            this.tb2Rate.ReadOnly = true;
            this.tb2Rate.Size = new System.Drawing.Size(209, 26);
            this.tb2Rate.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 104;
            this.label8.Text = "Second Country";
            // 
            // tb2Country
            // 
            this.tb2Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2Country.Location = new System.Drawing.Point(581, 167);
            this.tb2Country.Name = "tb2Country";
            this.tb2Country.ReadOnly = true;
            this.tb2Country.Size = new System.Drawing.Size(209, 26);
            this.tb2Country.TabIndex = 109;
            // 
            // tb2Code
            // 
            this.tb2Code.Enabled = false;
            this.tb2Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2Code.Location = new System.Drawing.Point(581, 102);
            this.tb2Code.Name = "tb2Code";
            this.tb2Code.Size = new System.Drawing.Size(209, 26);
            this.tb2Code.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Code";
            // 
            // btn2Find
            // 
            this.btn2Find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2Find.Enabled = false;
            this.btn2Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Find.ForeColor = System.Drawing.Color.White;
            this.btn2Find.Location = new System.Drawing.Point(581, 365);
            this.btn2Find.Name = "btn2Find";
            this.btn2Find.Size = new System.Drawing.Size(209, 53);
            this.btn2Find.TabIndex = 103;
            this.btn2Find.Text = "Find Currency";
            this.btn2Find.UseVisualStyleBackColor = false;
            this.btn2Find.Click += new System.EventHandler(this.btn2Find_Click);
            // 
            // frm_CurrencyCalculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 483);
            this.Controls.Add(this.btn2Find);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updownAmount);
            this.Controls.Add(this.tb2Code);
            this.Controls.Add(this.tb2Country);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb2Rate);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.tb2Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CurrencyCalculater";
            this.Text = "frm_CurrencyCalculater";
            this.Load += new System.EventHandler(this.frm_CurrencyCalculater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.NumericUpDown updownAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tb2Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb2Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb2Country;
        private System.Windows.Forms.TextBox tb2Code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn2Find;
    }
}