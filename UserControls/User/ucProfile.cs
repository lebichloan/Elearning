using Elearning.Entities;
using Elearning.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Elearning.UserControls.User
{
    public partial class ucProfile : UserControl
    {
        public ucProfile()
        {
            InitializeComponent();
            currentAccount = fLogin.currentAccount;
            InitUI();
        }

        private Account currentAccount;

        private void btnYourAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {

        }

        private void btnYourCertificate_Click(object sender, EventArgs e)
        {

        }

        private void InitUI()
        {
            picAvatar.Image = Image.FromFile(Program.AVARTAR_PATH + currentAccount.avatar);
            lblName.Text = currentAccount.fullname;

            txtFullName.Text = currentAccount.fullname;
            txtUserName.Text = currentAccount.username;
            txtEmail.Text = currentAccount.email;
            txtPassword.Text = currentAccount.user_password;

            List<Register> allCoursesRegister = (
                from course in Program.provider.Courses
                join register in Program.provider.Registers on course.course_id equals register.course_id
                join account in Program.provider.Accounts on register.learner_id equals account.acc_id
                select register
            ).ToList();

            lblTotalCourse.Text = allCoursesRegister.Count().ToString();

            int countComplete = 0;
            int countStudying = 0;
            int countPending = 0;
            foreach( Register register in allCoursesRegister)
            {
                if (register.register_status == 0)
                {
                    countPending++;
                }
                else if (register.register_status == 1)
                {
                    countStudying++;
                }
                else if (register.register_status == 2)
                {
                    countComplete++;
                }
            }
            lblTotalCetiificate.Text = countComplete.ToString();
            lblStudying.Text = countStudying.ToString();
            lblPending.Text = countPending.ToString();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string newFilePath = Program.AVARTAR_PATH + currentAccount.avatar;
                //Khong ghi de duoc. nho sua doan nay
                File.Copy(selectedFilePath, newFilePath, true);
                picAvatar.Image = Image.FromFile(selectedFilePath);
            }
        }
    }
}
