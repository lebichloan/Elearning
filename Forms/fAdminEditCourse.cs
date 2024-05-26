using Elearning.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning.Forms
{
    public partial class fAdminEditCourse : Form
    {
        public Course course;
        public EventHandler evtReload;
        public fAdminEditCourse()
        {
            InitializeComponent();
        }

        public fAdminEditCourse(Course course) : this()
        {
            this.course = course;
            tbCourseName.Text = course.course_name;
            tbLecturerName.Text = course.lecturer;
            tbDescription.Text = course.course_description;
            tbPrice.Text = course.price.ToString();
            pbThumbnailPreview.Image = Image.FromFile(Program.COURSES_IMG_PATH + course.course_image);
            pbThumbnailPreview.SizeMode = PictureBoxSizeMode.Zoom;

            LoadDataToComboBoxes();
        }

        private void LoadDataToComboBoxes()
        {
            // Load data to the comboboxes
            // Load course difficulties to cbDifficulty
            foreach (string difficulty in Program.COURSE_DIFFICULTIES)
            {
                cbDifficulty.Items.Add(difficulty);
            }
            cbDifficulty.SelectedIndex = 0;

            // Load course categories to cbCategory
            foreach (string category in Program.COURSE_CATEGORIES)
            {
                cbCategory.Items.Add(category);
            }
            cbCategory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the changes to the database
            // Check if all fields are filled
            if (tbCourseName.Text == "" || tbDescription.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Add new course to database with the filled data.
                // With image, copy the image to the courses image folder defined in Program.COURSES_IMG_PATH, the file name should be the course_id, and the extension should be the same as the original file.
                course.course_name = tbCourseName.Text;
                course.lecturer = tbLecturerName.Text;
                course.course_description = tbDescription.Text;
                course.price = tbPrice.Text != "" ? (int)Convert.ToDecimal(tbPrice.Text) : 0;
                course.difficulty = cbDifficulty.SelectedItem.ToString();
                course.category = cbCategory.SelectedItem.ToString();

                Program.provider.SaveChanges();

                if (tbPath.Text != "")
                {
                    // Remove the old image file
                    System.IO.File.Delete(Program.COURSES_IMG_PATH + course.course_image);
                    // Copy the image to the courses image folder defined in Program.COURSES_IMG_PATH, the file name should be the course_id, and the extension should be the same as the original file.
                    course.course_image = course.course_id + System.IO.Path.GetExtension(tbPath.Text);
                    System.IO.File.Copy(tbPath.Text, course.course_image);
                }
                Program.provider.SaveChanges();
                MessageBox.Show("Edited course successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            evtReload?.Invoke(this, e);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbThumbnailPreview.Image = Image.FromFile(fileDialog.FileName);
                pbThumbnailPreview.SizeMode = PictureBoxSizeMode.Zoom;
                tbPath.Text = fileDialog.FileName;
            }
        }
    }
}
