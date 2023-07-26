using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms.Users
{
    public partial class frm_FindUser : Form
    {
        public frm_FindUser()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                MessageBox.Show("Enter User Name First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser User = clsUser.Find(tbUserName.Text);


            if (User == null)
            {
                MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbFirstName.Text = User.FirstName;
                tbLastName.Text = User.LastName;
                tbPhone.Text = User.Phone;
                tbEmail.Text = User.Email;
                tbPassword.Text = User.Password;
                tbPermissions.Text = User.Permissions.ToString();

                pnlInfo.Enabled = true;
            }
        }

        private void frm_FindUser_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
        }
    }
}
