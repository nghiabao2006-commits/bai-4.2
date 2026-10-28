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
        private DataGridView dgvStudents;

        public Form1()
        {
            InitializeComponent();

            try
            {
                Database.Init();       
                InitializeFormData();  
                BuildGrid();            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeFormData()
        {
            mtxtPhone.Mask = "(000) 000-0000";

            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";

            cboCourse.DataSource = StudentRepository.GetCourses();
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";

            rdoMale.Checked = true;
            if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
        }

        private void BuildGrid()
        {
            this.ClientSize = new Size(680, 560);   

            dgvStudents = new DataGridView
            {
                Location = new Point(27, 320),
                Size = new Size(626, 210),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dgvStudents);

            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentRepository.GetAll();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();

            if (name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!mtxtPhone.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đủ số điện thoại.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtPhone.Focus();
                return;
            }

            var gender = rdoMale.Checked ? "Male" : "Female";
            int courseId = (int)cboCourse.SelectedValue;

            try
            {
                StudentRepository.Add(name, mtxtPhone.Text, dtpBirthDate.Value, courseId,
                                      gender, chkNewsletter.Checked, chkMaterials.Checked);

                LoadStudents();

                MessageBox.Show("Đã lưu học viên: " + name, "Đăng ký",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear();
                mtxtPhone.Clear();
                chkNewsletter.Checked = false;
                chkMaterials.Checked = false;
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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