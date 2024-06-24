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
        private ucAdminReviews ucReviews;
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

            ucReviews = new ucAdminReviews(course);
            ucReviews.Dock = DockStyle.Fill;
            conReviews.Controls.Add(ucReviews);
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            backHomeClicked?.Invoke(this, e);
        }

        public EventHandler reLoadMyElearning;
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

            lblDescription.Text = course.course_description;

            if (course.stars != null)
            {
                lblStar.Text = String.Format("{0}/5",
                    FormatDecimal(course.stars.Value));
            }
            else {
                lblStar.Text = "No reviews";
            }

            if (course.discount != 0)
            {
                lblPrice.Text = course.price.ToString("N0") + "đ";
                int priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                lblFinalPrice.Text = priceAfterDiscount.ToString("N0") + "đ";
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Strikeout);
            }
            else
            {
                lblPrice.Text = Program.FormatNumberWithSpaces(course.price);
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Bold);
                lblFinalPrice.Visible = false;
            }

            LoadModuleOfCourse(course);
        }

        public static string FormatDecimal(decimal? value)
        {
            if (!value.HasValue)
            {
                return string.Empty;
            }

            decimal roundedValue = Math.Round(value.Value, 1);

            if (roundedValue == Math.Floor(roundedValue))
            {
                return roundedValue.ToString("0");
            }
            else
            {
                return roundedValue.ToString("0.0");
            }
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
                    uc.moduleDescription = module.description;
                    uc.courseModuleClick += ucCourseModule_Click;
                    layoutModule.Controls.Add(uc);
                }
            }


            int countMandatoryTest = (
                from test in Program.provider.CourseTests
                where test.CourseResource.CourseModule.course_id == course.course_id
                && test.mandatory == 1
                select test
                ).ToList().Count();

            lblDescriptionAuto.Text = String.Format(
                "There are total {0} modules in this course. \n" +
                "You need to pass {1} mandatory tests to obtain certificate for completing this course",
                count.ToString(),
                countMandatoryTest.ToString());

        }

        private void ucCourseModule_Click(object sender, EventArgs e)
        {

        }

        private void panTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
