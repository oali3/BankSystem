using BankBusinessLayer;
using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        short Failed = 3;
        bool IsUserClosing = true;

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please enter your username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Failed > 1)
            {
                clsUser user = clsUser.FindByUserNameAndPassword(tbUserName.Text, tbPassword.Text);

                if (user != null)
                {
                    clsGlobalSettings.user = user;

                    IsUserClosing = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Failed--;
                    lbFailed.Text = "You have [ " + Failed + " ] Tries";
                }

            }
            else
            {
                MessageBox.Show("You have enteded a wrong UserName and Password 3 times ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsUserClosing)
                Application.Exit();
        }


        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
