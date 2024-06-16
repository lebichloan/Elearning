using Elearning.Entities;
using Microsoft.Win32;
using QRCoder;
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

namespace Elearning.Forms
{
    public partial class RegisterPayment : Form
    {
        public EventHandler backHomeClicked;
        private Account currentAccount = fLogin.currentAccount;
        private Course course = new Course();

        public RegisterPayment()
        {
            InitializeComponent();
        }

        public RegisterPayment(Course course)
        {
            InitializeComponent();
            this.course = course;
        }

        private int idPayment = 0;

        private void btnVisa_Click(object sender, EventArgs e)
        {
            idPayment = 1;
            picVisa.Image = Image.FromFile(Program.ICONS_PATH + "circle_filled_icon.png");
            btnVisa.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnBanking.BackColor = Color.White;

            picMomo.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picCash.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnBanking_Click(object sender, EventArgs e)
        {
            idPayment = 2;
            picBanking.Image = Image.FromFile(Program.ICONS_PATH + "circle_filled_icon.png");
            btnBanking.BackColor = Color.WhiteSmoke;

            picVisa.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnVisa.BackColor = Color.White;

            picMomo.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picCash.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnMoMo_Click(object sender, EventArgs e)
        {
            idPayment = 3;
            picMomo.Image = Image.FromFile(Program.ICONS_PATH + "circle_filled_icon.png");
            btnMoMo.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnBanking.BackColor = Color.White;

            picVisa.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnVisa.BackColor = Color.White;

            picCash.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnCash.BackColor = Color.White;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            idPayment = 0;
            picCash.Image = Image.FromFile(Program.ICONS_PATH + "circle_filled_icon.png");
            btnCash.BackColor = Color.WhiteSmoke;

            picBanking.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnBanking.BackColor = Color.White;

            picMomo.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnMoMo.BackColor = Color.White;

            picVisa.Image = Image.FromFile(Program.ICONS_PATH + "circle_icon.png");
            btnVisa.BackColor = Color.White;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (idPayment == 0)
            {
                try
                {
                    Register register = new Register();
                    register.learner_id = currentAccount.acc_id;
                    register.course_id = course.course_id;
                    register.registered_date = DateTime.Now;
                    register.register_status = 1;
                    register.completion_score = 0;
                    register.course_certificate = null;
                    Program.provider.Registers.Add(register);
                    Program.provider.SaveChanges();

                    DialogResult result = MessageBox.Show(
                        "Hoàn tất thanh toán. Đăng ký khóa học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    if (result == DialogResult.OK)
                    {
                        backHomeClicked?.Invoke(this, e);
                        this.Close();
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
                panPayment.Visible = false;

                if (course.discount_end_date <= DateTime.Now)
                {
                    int? priceAfterDiscount =
                        (int)Math.Round((double)(course.price - (course.price * course.discount / 100.0)));
                }
                else
                {
                    lblTotalCash.Text = Program.FormatNumberWithSpaces(course.price);
                }

                btnBack.Visible = true;
                panQRCode.Visible = true;
                CreateQRCode();
            }
        }

        private void CreateQRCode()
        {
            string dataPayment = course.price.ToString();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator
                .CreateQrCode(dataPayment, QRCodeGenerator.ECCLevel.Q));
            picQRCode.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false); qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                Register register = new Register();
                register.learner_id = currentAccount.acc_id;
                register.course_id = course.course_id;
                register.registered_date = DateTime.Now;
                register.register_status = 1;
                register.completion_score = 0;
                register.course_certificate = null;
                register.paid = (int)Math.Round((double)(course.price - (course.price * course.discount / 100.0)));
                Program.provider.Registers.Add(register);
                Program.provider.SaveChanges();

                DialogResult result = MessageBox.Show(
                    "Hoàn tất thanh toán. Đăng ký khóa học thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                if (result == DialogResult.OK)
                {
                    backHomeClicked?.Invoke(this, e);
                    this.Close();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            panPayment.Visible = true;
            btnBack.Visible = false;
            panQRCode.Visible = false;
        }
    }
}
