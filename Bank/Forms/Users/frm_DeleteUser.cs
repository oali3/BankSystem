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
    public partial class frm_DeleteUser : Form
    {
        public frm_DeleteUser()
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

                btnDelete.Enabled = true;
                pnlInfo.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this User", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (clsUser.DeleteUser(tbUserName.Text))
            {
                MessageBox.Show("User deleted successfully");
                tbUserName.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPassword.Text = "";
            tbPermissions.Text = "";
        }

        private void frm_DeleteUser_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
            btnDelete.BackColor = clsGlobalSettings.color;
        }
    }
}
