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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elearning.UserControls
{
    public partial class ucHome : UserControl
    {
        public EventHandler viewDetailsClicked;
        public ucHome()
        {
            InitializeComponent();
            InitUI();
        }

        public void ReloadData()
        {
            courses = new List<Course>();
        }

        private void InitUI()
        {
            txtSearch.Text = string.Empty;
            btnClear.Visible = false;

            cmbDifficulty.Items.Add("All");
            for (int i=0; i< Program.COURSE_DIFFICULTIES.Length; i++)
            {
                cmbDifficulty.Items.Add(Program.COURSE_DIFFICULTIES[i]);
            }
            cmbDifficulty.SelectedIndex = 0;

            cmbCategory.Items.Add("All");
            for (int i = 0; i < Program.COURSE_CATEGORIES.Length; i++)
            {
                cmbCategory.Items.Add(Program.COURSE_CATEGORIES[i]);
            }
            cmbCategory.SelectedIndex = 0;

            layoutCourses.AutoScroll = true;
            layoutCourses.VerticalScroll.Visible = true;
            layoutCourses.VerticalScroll.Enabled = true;
            layoutCourses.HorizontalScroll.Visible = false;
            layoutCourses.HorizontalScroll.Enabled = false;
            layoutCourses.RowCount = 0;
            layoutCourses.RowStyles.Clear();
            layoutCourses.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            //ucCoursePreview ucCoursePreview = new ucCoursePreview();
            //int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            //layoutCourses.ColumnCount = columns;
            //layoutCourses.ColumnStyles.Clear();
            //for (int i = 0; i < columns; ++i)
            //{
            //    layoutCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            //}

            //var courses = Program.provider.Courses.ToList();
            //foreach (Course course in courses)
            //{
            //    ucCoursePreview ucCourse = new ucCoursePreview();
            //    ucCourse.coursePreviewClicked = course;
            //    ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            //    ucCourse.courseLecturer = course.lecturer;
            //    ucCourse.courseName = course.course_name;
            //    ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
            //    layoutCourses.Controls.Add(ucCourse);
            //}
        }

        private Course coursePreview;
        public Course coursePreviewClicked
        {
            get { return coursePreview; }
            set { coursePreview = value; }
        }

        private void ucCoursePreview_viewDetailsClicked(object sender, EventArgs e)
        {
            ucCoursePreview ucCourse = sender as ucCoursePreview;
            coursePreview = ucCourse.coursePreviewClicked;
            viewDetailsClicked?.Invoke(this, e);
        }

        private string keySearch = null;
        private string filterDifficulty = "All";
        private string filterCategory = "All";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString() != "")
            {
                keySearch = txtSearch.Text.ToString().ToLower();
                LoadDataSearch(keySearch);
                btnClear.Visible = true;
            }
            else
            {
                keySearch = null;
                LoadDataSearch(keySearch);
                btnClear.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            keySearch = null;
            txtSearch.Text = null;
            btnClear.Visible = false;
            LoadDataSearch(keySearch);
        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDifficulty.SelectedIndex.ToString() != filterDifficulty)
            {
                if (cmbDifficulty.SelectedIndex == 0)
                {
                    filterDifficulty = "All";
                }
                else
                {
                    filterDifficulty = Program.COURSE_DIFFICULTIES[cmbDifficulty.SelectedIndex - 1];
                }
            }
            LoadDataFilter(filterDifficulty, filterCategory);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex.ToString() != filterCategory)
            {
                if (cmbCategory.SelectedIndex == 0)
                {
                    filterCategory = "All";
                }
                else
                {
                    filterCategory = Program.COURSE_CATEGORIES[cmbCategory.SelectedIndex - 1];
                }
            }
            LoadDataFilter(filterDifficulty, filterCategory);
        }

        List<Course> courses;

        private void LoadDataSearch(string keySearch)
        {
            layoutCourses.Controls.Clear();

            ucCoursePreview ucCoursePreview = new ucCoursePreview();
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutCourses.ColumnCount = columns;
            layoutCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            courses = Program.provider.Courses.ToList();
            foreach (Course course in courses)
            {
                if (keySearch == null)
                {
                    ucCoursePreview ucCourse = new ucCoursePreview();
                    ucCourse.coursePreviewClicked = course;
                    ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                    ucCourse.courseLecturer = course.lecturer;
                    ucCourse.courseName = course.course_name;
                    ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                    ucCourse.SetUIRate(0, 0);
                    layoutCourses.Controls.Add(ucCourse);
                }
                else
                {
                    if (course.course_name.ToLower().Contains(keySearch)
                        || course.lecturer.ToLower().Contains(keySearch)
                        || course.difficulty.ToLower().Contains(keySearch)
                        || course.category.ToLower().Contains(keySearch)
                        )
                    {
                        ucCoursePreview ucCourse = new ucCoursePreview();
                        ucCourse.coursePreviewClicked = course;
                        ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                        ucCourse.courseLecturer = course.lecturer;
                        ucCourse.courseName = course.course_name;
                        if (course.stars != null)
                        {
                            ucCourse.rating = String.Format("{0}/5",
                                FormatDecimal(course.stars.Value));
                        }
                        else
                        {
                            ucCourse.rating = "0/5";
                        }

                        if (course.discount_end_date >= DateTime.Now)
                        {
                            int? priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                            ucCourse.price = Program.FormatNumberWithSpaces((int)priceAfterDiscount);
                        }
                        else
                        {
                            ucCourse.price = Program.FormatNumberWithSpaces(course.price);
                        }

                        ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                        ucCourse.SetUIRate(0, 0);
                        layoutCourses.Controls.Add(ucCourse);
                    }

                }
            }
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadDataFilter(filterDifficulty, filterCategory);
        }

        private void LoadDataFilter(string filterDifficulty, string filterCategory)
        {
            layoutCourses.Controls.Clear();
            
            ucCoursePreview ucCoursePreview = new ucCoursePreview();
            int columns = (Screen.PrimaryScreen.WorkingArea.Width - 5) / ucCoursePreview.MaximumSize.Width;
            layoutCourses.ColumnCount = columns;
            layoutCourses.ColumnStyles.Clear();
            for (int i = 0; i < columns; ++i)
            {
                layoutCourses.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columns));
            }

            courses = Program.provider.Courses.ToList();
            foreach(Course course in courses)
            {
                if (filterDifficulty == "All" && filterCategory == "All")
                {
                    ucCoursePreview ucCourse = new ucCoursePreview();
                    ucCourse.coursePreviewClicked = course;
                    ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                    ucCourse.courseLecturer = course.lecturer;
                    ucCourse.courseName = course.course_name;

                    if (course.stars != null)
                    {
                        ucCourse.rating = String.Format("{0}/5",
                            FormatDecimal(course.stars.Value));
                    }
                    else
                    {
                        ucCourse.rating = "0/5";
                    }

                    if (course.discount_end_date >= DateTime.Now)
                    {
                        int? priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                        ucCourse.price = Program.FormatNumberWithSpaces((int)priceAfterDiscount);
                    }
                    else
                    {
                        ucCourse.price = Program.FormatNumberWithSpaces(course.price);
                    }

                    ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                    ucCourse.SetUIRate(0, 0);
                    layoutCourses.Controls.Add(ucCourse);
                }
                else if (filterDifficulty == course.difficulty && filterCategory == "All")
                {
                    ucCoursePreview ucCourse = new ucCoursePreview();
                    ucCourse.coursePreviewClicked = course;
                    ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                    ucCourse.courseLecturer = course.lecturer;
                    ucCourse.courseName = course.course_name;

                    if (course.stars != null)
                    {
                        ucCourse.rating = String.Format("{0}/5",
                            FormatDecimal(course.stars.Value));
                    }
                    else
                    {
                        ucCourse.rating = "0/5";
                    }

                    if (course.discount_end_date >= DateTime.Now)
                    {
                        int? priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                        ucCourse.price = Program.FormatNumberWithSpaces((int)priceAfterDiscount);
                    }
                    else
                    {
                        ucCourse.price = Program.FormatNumberWithSpaces(course.price);
                    }

                    ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                    ucCourse.SetUIRate(0, 0);
                    layoutCourses.Controls.Add(ucCourse);
                }
                else if (filterDifficulty == "All" && filterCategory == course.category)
                {
                    ucCoursePreview ucCourse = new ucCoursePreview();
                    ucCourse.coursePreviewClicked = course;
                    ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                    ucCourse.courseLecturer = course.lecturer;
                    ucCourse.courseName = course.course_name;

                    if (course.stars != null)
                    {
                        ucCourse.rating = String.Format("{0}/5",
                            FormatDecimal(course.stars.Value));
                    }
                    else
                    {
                        ucCourse.rating = "0/5";
                    }

                    if (course.discount_end_date >= DateTime.Now)
                    {
                        int? priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                        ucCourse.price = Program.FormatNumberWithSpaces((int)priceAfterDiscount);
                    }
                    else
                    {
                        ucCourse.price = Program.FormatNumberWithSpaces(course.price);
                    }

                    ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                    ucCourse.SetUIRate(0, 0);
                    layoutCourses.Controls.Add(ucCourse);
                }
                else
                {
                    if (filterCategory == course.category && filterDifficulty == course.difficulty)
                    {
                        ucCoursePreview ucCourse = new ucCoursePreview();
                        ucCourse.coursePreviewClicked = course;
                        ucCourse.courseImage = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
                        ucCourse.courseLecturer = course.lecturer;
                        ucCourse.courseName = course.course_name;

                        if (course.stars != null)
                        {
                            ucCourse.rating = String.Format("{0}/5",
                                FormatDecimal(course.stars.Value));
                        }
                        else
                        {
                            ucCourse.rating = "0/5";
                        }

                        if (course.discount_end_date >= DateTime.Now)
                        {
                            int? priceAfterDiscount = (int)Math.Round(course.price - (course.price * (int)course.discount / 100.0));
                            ucCourse.price = Program.FormatNumberWithSpaces((int)priceAfterDiscount);
                        }
                        else
                        {
                            ucCourse.price = Program.FormatNumberWithSpaces(course.price);
                        }

                        ucCourse.viewDetailsClicked += ucCoursePreview_viewDetailsClicked;
                        ucCourse.SetUIRate(0, 0);
                        layoutCourses.Controls.Add(ucCourse);
                    }
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearch.Text.ToString() != "")
                {
                    keySearch = txtSearch.Text.ToString();
                    LoadDataSearch(keySearch);
                    btnClear.Visible = true;
                }
                else
                {
                    keySearch = null;
                    LoadDataSearch(keySearch);
                    btnClear.Visible = false;
                }
            }
        }
    }
}
