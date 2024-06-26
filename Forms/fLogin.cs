﻿using Elearning.Entities;
using OnlineChat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fLogin : Form
    {
        public static Account currentAccount = null;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // check if username and password are filled
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // search account in database using Program.provider.Accounts
            var account = Program.provider.Accounts.FirstOrDefault(a => a.username == tbUsername.Text && a.user_password == tbPassword.Text);
            if (account != null)
            {
                currentAccount = account;
                if (account.user_role == Program.ROLE_ADMIN)
                {
                    this.Hide();
                    // open admin form
                    fAdminMain f = new fAdminMain(account);
                    f.FormClosed += CloseMainForm;
                    f.ShowDialog();
                }
                else
                {
                    this.Hide();
                    // open student form
                    fMain f = new fMain();
                    f.FormClosed += CloseMainForm;
                    f.ShowDialog();
                }
            }
            else
            {
                // show error message
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

        }

        private void CloseMainForm(object sender, EventArgs e)
        {
            //this.Close();
            //this.Hide();
            //tbUsername.Text = null;
            //tbPassword.Text = null;
            //this.Show();
            //fLogin fLogin = new fLogin();
            //fLogin.ShowDialog();

            //fLogin login = new fLogin();
            //login.ShowDialog();
            //this.Close();

            this.Show();
            tbPassword.Text = "";
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check if username and password are filled
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // search account in database using Program.provider.Accounts
                var account = Program.provider.Accounts.FirstOrDefault(a => a.username == tbUsername.Text && a.user_password == tbPassword.Text);
                if (account != null)
                {
                    currentAccount = account;
                    if (account.user_role == Program.ROLE_ADMIN)
                    {
                        this.Hide();
                        // open admin form
                        fAdminMain f = new fAdminMain(account);
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        // open student form
                        fMain f = new fMain();
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                    }
                }
                else
                {
                    // show error message
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
            this.Close();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsername;
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();
            this.Close();
        }

        private void linkForgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();
            this.Close();
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check if username and password are filled
                if (tbUsername.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // search account in database using Program.provider.Accounts
                var account = Program.provider.Accounts.FirstOrDefault(a => a.username == tbUsername.Text && a.user_password == tbPassword.Text);
                if (account != null)
                {
                    currentAccount = account;
                    if (account.user_role == Program.ROLE_ADMIN)
                    {
                        this.Hide();
                        // open admin form
                        fAdminMain f = new fAdminMain(account);
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        // open student form
                        fMain f = new fMain();
                        f.FormClosed += CloseMainForm;
                        f.ShowDialog();
                    }
                }
                else
                {
                    // show error message
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
