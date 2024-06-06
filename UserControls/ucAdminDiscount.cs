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

namespace Elearning.UserControls
{
    public partial class ucAdminDiscount : UserControl
    {
        Course course;
        public ucAdminDiscount()
        {
            InitializeComponent();
        }

        public ucAdminDiscount(Course course) : this()
        {
            this.course = course;
            Reload();

        }

        public void Reload()
        {
            if(course.price == 0)
            {
                this.lbPrice.Visible = false;
                this.lbDiscount.Text = "Free course!";
                this.lbDiscountEndDate.Visible = false;
                this.lbDiscounted.Visible = false;
            }
            else
            {
                this.lbPrice.Visible = true;
                if (course.discount > 0)
                {
                    this.lbPrice.Text = course.price.ToString("N0");
                    // strike through the price
                    this.lbPrice.Font = new Font(this.lbPrice.Font, FontStyle.Strikeout);
                    int newPrice = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                    this.lbDiscounted.Text = newPrice.ToString("N0") + "VND";
                    this.lbDiscount.Text = "Discount: " + course.discount.ToString() + "%";
                    this.lbDiscountEndDate.Text = "Discount End On: " + ((DateTime)course.discount_end_date).ToString("dd/MM/yyyy");
                    this.lbDiscountEndDate.Visible = true;
                    this.lbDiscounted.Visible = true;
                }

                else
                {
                    this.lbPrice.Text = course.price.ToString("N0") + "VND";
                    this.lbDiscount.Text = "No discount";
                    this.lbDiscountEndDate.Visible = false;
                    this.lbDiscounted.Visible = false;
                    this.lbPrice.Font = new Font(this.lbPrice.Font, FontStyle.Regular);
                }
            }
        }
    }
}
