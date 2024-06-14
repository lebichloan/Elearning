using Elearning;
using Elearning.Entities;
using Elearning.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineChat
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void butSignup_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string username = tbUsername.Text;
            string password = tbMatKhau.Text;
            string confirmPassword = tbXNMK.Text;

            // check if password and confirm password are the same
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and confirm password are not the same!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the email is in valid format by checking if the lbEmailValid.Text is 'Email is valid'
            if (lbEmailValid.Text != "Email is valid")
            {
                MessageBox.Show("The entered email has wrong format!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the username is unique
            if (Program.provider.Accounts.FirstOrDefault(a => a.username == username) != null)
            {
                MessageBox.Show("Username is already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // create a new account with the entered information
            Account account = new Account();
            account.fullname = tbHoTen.Text;
            account.email = email;
            account.username = username;
            account.user_password = password;
            account.user_role = Program.ROLE_LEARNER;

            string source = tbPath.Text != "" ? tbPath.Text : Program.AVARTAR_PATH + "default.png";

            // copy the choosen image to the images/avatar folder in the project directory, change the filename to the username plus the extension
            string filename = username + System.IO.Path.GetExtension(source);
            string destination = Program.AVARTAR_PATH + filename;
            System.IO.File.Copy(source, destination, true);

            account.avatar = filename;

            Program.provider.Accounts.Add(account);
            Program.provider.SaveChanges();

            MessageBox.Show("Account created successfully! Please login using your new account!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void butLoadImage_Click(object sender, EventArgs e)
        {
            // open file dialog to choose an image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // resize the image to fit the picture box and then display it
                Image img = Image.FromFile(ofd.FileName);
                picPreview.Image = img;

            }
            // show the path of the chosen image in the text box
            tbPath.Text = ofd.FileName;
        }

        private void tbHoTen_Validating(object sender, CancelEventArgs e)
        {
            // check if the fullname is empty
            if (tbHoTen.Text == "")
            {
                lbHoTenValid.Text = "Fullname cannot be empty!";
                lbHoTenValid.ForeColor = Color.Red;
            }
            else
            {
                lbHoTenValid.Text = "";
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            // check if the username is empty
            if (tbUsername.Text == "")
            {
                lbUsernameValid.Text = "Username cannot be empty!";
                lbUsernameValid.ForeColor = Color.Red;
                return;
            }

            // check if the username contains any special characters or spaces
            if (System.Text.RegularExpressions.Regex.IsMatch(tbUsername.Text, "[^a-zA-Z0-9]"))
            {
                lbUsernameValid.Text = "Username cannot contain special characters or spaces!";
                lbUsernameValid.ForeColor = Color.Red;
                return;
            }

            lbUsernameValid.Text = "";
        }

        private void Signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
            this.Close();
        }
    }
}
