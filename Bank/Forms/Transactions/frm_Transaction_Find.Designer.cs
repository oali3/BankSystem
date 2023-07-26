namespace Bank.Forms.Transactions
{
    partial class frm_Transaction_Find
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
            this.btnFindDeleteClient = new System.Windows.Forms.Button();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindDeleteClient
            // 
            this.btnFindDeleteClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnFindDeleteClient.Location = new System.Drawing.Point(104, 124);
            this.btnFindDeleteClient.Name = "btnFindDeleteClient";
            this.btnFindDeleteClient.Size = new System.Drawing.Size(190, 45);
            this.btnFindDeleteClient.TabIndex = 56;
            this.btnFindDeleteClient.Text = "Find";
            this.btnFindDeleteClient.UseVisualStyleBackColor = false;
            this.btnFindDeleteClient.Click += new System.EventHandler(this.btnFindDeleteClient_Click);
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountNumber.Location = new System.Drawing.Point(193, 73);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(171, 26);
            this.tbAccountNumber.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Account Number";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(45, 31);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(81, 20);
            this.lbMessage.TabIndex = 57;
            this.lbMessage.Text = "Message";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Transaction_Find
            // 
            this.AcceptButton = this.btnFindDeleteClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 181);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnFindDeleteClient);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.label16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Transaction_Find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Transaction_Find_FormClosing);
            this.Load += new System.EventHandler(this.frm_Transaction_Find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDeleteClient;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbMessage;
    }
}