using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFormData();
        }

        private void InitializeFormData()
        {

            // Birth date format
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            // Populate courses (DisplayMember, ValueMember)
            var courses = new List<Course>
            {
                new Course { Id = 1, Name = "C# Beginner" },
                new Course { Id = 2, Name = "Windows Forms" },
                new Course { Id = 3, Name = "ASP.NET MVC" },
                new Course { Id = 4, Name = "Data Structures" }
            };

            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";

            // Default selections
            rdoMale.Checked = true;
            if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var phone = mtxtPhone.Text;
            var birth = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            var courseName = (cboCourse.SelectedItem as Course)?.Name ?? string.Empty;
            var courseId = cboCourse.SelectedValue != null ? cboCourse.SelectedValue.ToString() : string.Empty;
            var gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Other";
            var extras = new List<string>();
            if (chkNewsletter.Checked) extras.Add("Newsletter");
            if (chkMaterials.Checked) extras.Add("Materials");

            var info = new StringBuilder();
            info.AppendLine("Registration info:");
            info.AppendLine($"Name: {name}");
            info.AppendLine($"Phone: {phone}");
            info.AppendLine($"Birth date: {birth}");
            info.AppendLine($"Course: {courseName} (Id: {courseId})");
            info.AppendLine($"Gender: {gender}");
            info.AppendLine($"Extras: {(extras.Count > 0 ? string.Join(", ", extras) : "None")} ");

            MessageBox.Show(info.ToString(), "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void chkMaterials_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
