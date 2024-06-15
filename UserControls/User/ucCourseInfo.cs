using Elearning.Entities;
using Elearning.Forms;
using Elearning.UserControls.User;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.UserControls
{
    public partial class ucCourseInfo : UserControl
    {
        public EventHandler backHomeClicked;
        private Course course;
        private Account currentAccount = fLogin.currentAccount;
        private Register register;
        public ucCourseInfo()
        {
            InitializeComponent();
        }

        private List<CourseReview> listCourseReview;
        public ucCourseInfo(Course course)
        {
            InitializeComponent();
            this.course = course;
            register = Program.provider.Registers.FirstOrDefault(
                x => x.course_id == course.course_id && x.learner_id == currentAccount.acc_id
                );
            InitUI(course);

            cmbRating.Items.Add("All");
            for (int i = 5; i > 0; i--)
            {
                cmbRating.Items.Add(i.ToString());
            }
            cmbRating.SelectedIndex = 0;

            listCourseReview = Program.provider.CourseReviews.ToList();
            LoadAllReview(listCourseReview);
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (course.price == 0)
            {
                try
                {
                    Register newRegister = new Register();
                    newRegister.learner_id = currentAccount.acc_id;
                    newRegister.course_id = course.course_id;
                    newRegister.registered_date = DateTime.Now;
                    newRegister.register_status = 1;
                    newRegister.completion_score = 0;
                    newRegister.course_certificate = null;
                    Program.provider.Registers.Add(newRegister);
                    Program.provider.SaveChanges();

                    DialogResult result = MessageBox.Show(
                        "Đăng ký khóa học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                    if (result == DialogResult.OK)
                    {
                        backHomeClicked?.Invoke(this, e);
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
            else
            {
                RegisterPayment registerPayment = new RegisterPayment(course);
                registerPayment.backHomeClicked += backHomeClicked;
                registerPayment.ShowDialog();
            }
        }

        private void InitUI(Course course)
        {
            if (register == null)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }

            picCourseImage.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            
            lblCourseName.Text = course.course_name;
            lblCourseName1.Text = course.course_name;

            lblLecturerName.Text = course.lecturer;
            lblLecturerName1.Text = course.lecturer;

            lblDifficulty.Text = course.difficulty;
            lblDifficulty1.Text = course.difficulty;

            lblCategory.Text = course.category;
            lblCategory1.Text = course.category;

            lblDescription.Text = course.course_description;

            if (course.stars != null)
            {
                lblStar.Text = course.stars.ToString();
            }
            else
            {
                lblStar.Text = "No rating";
            }

            lblPrice.Text = String.Format("{0} VNĐ", course.price.ToString());

            LoadModuleOfCourse(course);
        }

        private void LoadModuleOfCourse(Course course)
        {
            layoutModule.AutoScroll = true;
            layoutModule.VerticalScroll.Visible = true;
            layoutModule.VerticalScroll.Enabled = true;
            layoutModule.HorizontalScroll.Visible = false;
            layoutModule.HorizontalScroll.Enabled = false;
            layoutModule.RowCount = 0;
            layoutModule.RowStyles.Clear();
            layoutModule.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            int count = 0;
            List<CourseModule> allModule = Program.provider.CourseModules.ToList();
            foreach (CourseModule module in allModule)
            {
                if (module.course_id == course.course_id)
                {
                    count++;
                    ucCourseModule uc = new ucCourseModule();
                    uc.Dock = DockStyle.Top;
                    uc.moduleOrdinal = string.Format("Module {0}:", count);
                    uc.moduleName = module.module_name;
                    uc.courseModuleClick += ucCourseModule_Click;
                    layoutModule.Controls.Add(uc);
                }
            }

            lblTotalModule.Text = String.Format("{0} moudules", count.ToString());
        }

        private void ucCourseModule_Click(object sender, EventArgs e)
        {

        }

        private void LoadAllReview(List<CourseReview> listReviews)
        {
            tbAllReview.Controls.Clear();
            tbAllReview.AutoScroll = true;
            tbAllReview.VerticalScroll.Visible = true;
            tbAllReview.VerticalScroll.Enabled = true;
            tbAllReview.HorizontalScroll.Visible = false;
            tbAllReview.HorizontalScroll.Enabled = false;
            tbAllReview.RowCount = 0;
            tbAllReview.RowStyles.Clear();
            tbAllReview.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            foreach (CourseReview review in listReviews)
            {
                itemReview item = new itemReview();
                item.avatarPath = Image.FromFile(Program.AVARTAR_PATH + currentAccount.avatar);
                item.name = review.Register.Account.fullname;
                item.review = review.content;
                item.datetime = review.review_time.ToString();
                item.SetRating(review.stars);

                tbAllReview.Controls.Add(item);
            }
        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRating.SelectedIndex == 0)
            {
                listCourseReview = Program.provider.CourseReviews.ToList();
            }
            else
            {
                listCourseReview = (
                    from review in Program.provider.CourseReviews
                    where review.stars == (6 - cmbRating.SelectedIndex)
                    select review
                    ).ToList();
            }
            LoadAllReview(listCourseReview);
        }
    }
}
