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
    public partial class frm_AddNewUser : Form
    {
        public frm_AddNewUser()
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



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)
                   || string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrWhiteSpace(tbLastName.Text)
                   || string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("Please fill all the information first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            clsUser User = new clsUser();

            User.UserName = tbUserName.Text;
            User.Password = tbPassword.Text;
            User.FirstName = tbFirstName.Text;
            User.LastName = tbLastName.Text;
            User.Phone = tbPhone.Text;
            User.Email = tbEmail.Text;
            User.Permissions = _GetPermissions();

            if (User.Save())
            {
                MessageBox.Show($"User Added Sucessfully with ID = {User.UserID}", "Saved");
            }
            else
            {
                MessageBox.Show("Failed to Add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

        private void frm_AddNewUser_Load(object sender, EventArgs e)
        {
            btnSave.BackColor = clsGlobalSettings.color;
        }
    }
}
