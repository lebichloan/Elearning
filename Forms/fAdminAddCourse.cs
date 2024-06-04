using Elearning.Entities;
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
    public partial class fAdminAddCourse : Form
    {
        public EventHandler evtReload;
        public fAdminAddCourse()
        {
            InitializeComponent();

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

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Open file dialog to choose course image. Only accept image files.
            // After choosing the file, display the image in pbThumbnailPreview, and add path as text of tbPath
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbThumbnailPreview.Image.Dispose();
                pbThumbnailPreview.Image = Image.FromFile(fileDialog.FileName);
                pbThumbnailPreview.SizeMode = PictureBoxSizeMode.Zoom;
                tbPath.Text = fileDialog.FileName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the course to the database
            // Check if all fields are filled
            if (tbCourseName.Text == "" || tbDescription.Text == "" || tbPath.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                // Add new course to database with the filled data.
                // With image, copy the image to the courses image folder defined in Program.COURSES_IMG_PATH, the file name should be the course_id, and the extension should be the same as the original file.
                Course course = new Course();
                course.course_name = tbCourseName.Text;
                course.lecturer = tbLecturerName.Text;
                course.course_description = tbDescription.Text;
                course.price = tbPrice.Text != "" ? (int)Convert.ToDecimal(tbPrice.Text) : 0;
                course.difficulty = cbDifficulty.SelectedItem.ToString();
                course.category = cbCategory.SelectedItem.ToString();
                course.created_at = DateTime.Now;
                course.created_by = 1; // account id of an admin, hard-coded for now
                course.course_image = "";
                // Add the course to the database and get the course_id
                Program.provider.Courses.Add(course);
                Program.provider.SaveChanges();

                int course_id = course.course_id;
                string srcPath = tbPath.Text;
                string destPath = Program.COURSES_IMG_PATH + course_id + srcPath.Substring(srcPath.LastIndexOf('.'));
                System.IO.File.Copy(srcPath, destPath);
                course.course_image = course_id + srcPath.Substring(srcPath.LastIndexOf('.'));
                Program.provider.SaveChanges();

                MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all fields
                tbCourseName.Text = "";
                tbLecturerName.Text = "";
                tbDescription.Text = "";
                tbPrice.Text = "";
                cbDifficulty.SelectedIndex = 0;
                cbCategory.SelectedIndex = 0;
                pbThumbnailPreview.Image = null;
                tbPath.Text = "";

                evtReload?.Invoke(this, e);
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
    }
}
