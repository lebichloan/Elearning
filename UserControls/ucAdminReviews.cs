﻿using Elearning.Entities;
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
    public partial class ucAdminReviews : UserControl
    {
        Course course;
        public ucAdminReviews(Course course)
        {
            InitializeComponent();
            this.course = course;
            flpReviews.AutoScroll = true;
            flpReviews.VerticalScroll.Enabled = true;
            LoadReviews();

        }

        private void LoadReviews()
        {
            int totalReviews = 0;
            // create an array to store the number of reviews for each star
            int[] total = new int[6];
            for (int i = 0; i < 6; i++)
            {
                total[i] = 0;
            }
            // get list of reviews of the course through registers
            List<CourseReview> reviews = new List<CourseReview>();
            List<Register> registers = Program.provider.Registers.Where(x => x.course_id == course.course_id).ToList();
            foreach (Register reg in registers)
            {
                   if (reg.CourseReviews != null && reg.CourseReviews.Count > 0)
                {
                    reviews.Add(reg.CourseReviews.First());
                }
            }
            reviews = reviews.OrderByDescending(x => x.review_id).ToList();
            // for loop through all register of the course. each register has one or zero review
            foreach (CourseReview review in reviews)
            {
                ucAdminReview ucReview = new ucAdminReview(review);
                ucReview.Dock = DockStyle.Top;
                ucReview.Size = ucReview.ClientSize = new Size(flpReviews.ClientSize.Width - 15, ucReview.Height);

                flpReviews.Controls.Add(ucReview);
                totalReviews++;

                total[(int)review.stars]++;
            }

            if (totalReviews > 0)
            {

                lbNumReviews.Text = totalReviews.ToString() + " reviews";
                var stars = Math.Round((decimal)course.stars, 2);
                lbAvgRating.Text = stars.ToString() + "/5";
                lbAvgRating.Visible = true;

                bar1star.Value = (int)((total[1] * 1.0 / totalReviews) * 100.0);
                bar2stars.Value = (int)((total[2] * 1.0 / totalReviews) * 100.0);
                bar3stars.Value = (int)((total[3] * 1.0 / totalReviews) * 100.0);
                bar4stars.Value = (int)((total[4] * 1.0 / totalReviews) * 100.0);
                bar5stars.Value = (int)((total[5] * 1.0 / totalReviews) * 100.0);

                // print the percentage of each star, round to 2 decimal places
                lb1starPercent.Text = Math.Round((total[1] * 1.0 / totalReviews) * 100.0, 2).ToString() + "%";
                lb2starsPercent.Text = Math.Round((total[2] * 1.0 / totalReviews) * 100.0, 2).ToString() + "%";
                lb3starsPercent.Text = Math.Round((total[3] * 1.0 / totalReviews) * 100.0, 2).ToString() + "%";
                lb4starsPercent.Text = Math.Round((total[4] * 1.0 / totalReviews) * 100.0, 2).ToString() + "%";
                lb5starsPercent.Text = Math.Round((total[5] * 1.0 / totalReviews) * 100.0, 2).ToString() + "%";
            }
            else
            {
                lbNumReviews.Text = "No review yet";
                lbAvgRating.Visible = false;
                bar1star.Value = 0;
                bar2stars.Value = 0;
                bar3stars.Value = 0;
                bar4stars.Value = 0;
                bar5stars.Value = 0;

                lb1starPercent.Text = "0%";
                lb2starsPercent.Text = "0%";
                lb3starsPercent.Text = "0%";
                lb4starsPercent.Text = "0%";
                lb5starsPercent.Text = "0%";
            }

        }

        private void ucAdminReviews_Load(object sender, EventArgs e)
        {
            
        }

        private void cbFilterReviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cbFilterReviews.SelectedIndex;

            foreach(ucAdminReview ucReview in flpReviews.Controls)
            {
                if (value == 0)
                {
                    ucReview.Visible = true;
                }
                else
                {
                    ucReview.Visible = ucReview.star() == value;
                }
            }
        }
    }
}
