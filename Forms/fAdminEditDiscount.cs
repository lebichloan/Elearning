using Elearning.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fAdminEditDiscount : Form
    {
        Course course;

        public fAdminEditDiscount(Course course)
        {
            InitializeComponent();
            this.course = course;
            lbCourseName.Text = course.course_name;
            tbDiscount.Text = course.discount.ToString();
            dateEnd.MinDate = DateTime.Now;
            if (course.discount_end_date == null)
            {
                dateEnd.Value = DateTime.Now;
            }
            else
            {
                dateEnd.Value = (DateTime)course.discount_end_date;
            }

            // only allow typing numbers in the discount textbox
            tbDiscount.KeyPress += new KeyPressEventHandler((sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check if the discount is valid, should be between 0 and 100
            if (int.TryParse(tbDiscount.Text, out int discount) && discount >= 0 && discount <= 100)
            {
                if (discount == 0)
                {
                    // Show a confirmation dialog to remove the discount
                    if (MessageBox.Show("Are you sure you want to remove the discount?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        course.discount = 0;
                        course.discount_end_date = null;
                        Program.provider.SaveChanges();
                        MessageBox.Show("Discount removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }

                    return;
                }

                int newPrice = (int)Math.Round(course.price - (course.price * discount / 100.0));

                if (MessageBox.Show("The new price will be " + newPrice.ToString("N0") + " VND. The discount will end on " + dateEnd.Value.ToString("dd/MM/yyyy") + ". Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    course.discount = discount;
                    course.discount_end_date = dateEnd.Value;
                    Program.provider.SaveChanges();
                    MessageBox.Show("Discount updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid discount value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            // if the discount is 0, disable the date picker
            if (tbDiscount.Text == "0")
            {
                dateEnd.Enabled = false;
            }
            else
            {
                dateEnd.Enabled = true;
            }
        }
    }
}
