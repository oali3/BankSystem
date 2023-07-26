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
    public partial class frm_UpdateUser : Form
    {
        public frm_UpdateUser()
        {
            InitializeComponent();
        }

        int _GetPermissions()
        {
            if (chkAll.Checked == true)
                return -1;

            int permissions = 0;

            if (chkManageUsers.Checked == true)
                permissions += 1;
            if (chkManageClients.Checked == true)
                permissions += 2;
            if (chkTransactions.Checked == true)
                permissions += 4;
            if (chkCurrency.Checked == true)
                permissions += 8;


            return permissions;
        }

        void _SetPermissions(int perm)
        {
            if (perm == -1)
            {
                chkAll.Checked = true;
                chkCurrency.Checked = true;
                chkManageClients.Checked = true;
                chkManageUsers.Checked = true;
                chkTransactions.Checked = true;
                return;
            }

            if ((perm & 1) == 1)
            {
                chkManageUsers.Checked = true;
            }
            if ((perm & 2) == 2)
            {
                chkManageClients.Checked = true;
            }
            if ((perm & 4) == 4)
            {
                chkTransactions.Checked = true;
            }
            if ((perm & 8) == 8)
            {
                chkCurrency.Checked = true;
            }

            
        }



        private void chkManageUsers_Click(object sender, EventArgs e)
        {
            if (chkManageUsers.Checked == true && chkManageClients.Checked == true &&
                chkTransactions.Checked == true && chkCurrency.Checked == true)
            {
                chkAll.Checked = true;
            }
            else
                chkAll.Checked = false;
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                chkManageClients.Checked = true;
                chkManageUsers.Checked = true;
                chkTransactions.Checked = true;
                chkCurrency.Checked = true;
            }
            else
            {
                chkManageClients.Checked = false;
                chkManageUsers.Checked = false;
                chkTransactions.Checked = false;
                chkCurrency.Checked = false;
            }
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
                

                btnUpdate.Enabled = true;
                pnlInfo.Enabled = true;

                _SetPermissions(User.Permissions);
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPassword.Text = "";

            chkAll.Checked = false;
            chkManageClients.Checked = false;
            chkManageUsers.Checked = false;
            chkTransactions.Checked = false;
            chkCurrency.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)
                || string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
                || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please fill all the information first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser User = clsUser.Find(tbUserName.Text);

            User.FirstName = tbFirstName.Text;
            User.LastName = tbLastName.Text;
            User.Phone = tbPhone.Text;
            User.Email = tbEmail.Text;
            User.Password = tbPassword.Text;
            User.Permissions = _GetPermissions();



            if (User.Save())
            {
                MessageBox.Show("User Updated successfully");
                tbUserName.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_UpdateUser_Load(object sender, EventArgs e)
        {
            btnFind.BackColor = clsGlobalSettings.color;
            btnUpdate.BackColor = clsGlobalSettings.color;
        }
    }
}
