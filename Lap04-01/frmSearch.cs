using Lap04_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap04_01
{
    public partial class frmSearch : Form
    {
        StudentContextDB dbStudent = new StudentContextDB();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox và ComboBox
            string studentID = txtStudentID.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string facultyName = cmbFaculty.Text.Trim(); // Nếu sử dụng ComboBox để chọn khoa

            // Khởi tạo truy vấn cơ sở dữ liệu
            var query = dbStudent.Student.AsQueryable();

            // Kiểm tra và áp dụng điều kiện tìm kiếm
            if (!string.IsNullOrEmpty(studentID))
            {
                query = query.Where(s => s.StudentID.Contains(studentID)); // Tìm kiếm theo mã sinh viên
            }

            if (!string.IsNullOrEmpty(fullName))
            {
                query = query.Where(s => s.FullName.Contains(fullName)); // Tìm kiếm theo họ tên
            }

            if (!string.IsNullOrEmpty(facultyName))
            {
                query = query.Where(s => s.Faculty.FacultyName.Contains(facultyName)); // Tìm kiếm theo tên khoa
            }

            // Lấy danh sách sinh viên thỏa mãn điều kiện tìm kiếm
            List<Student> searchResults = query.ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            FillDataDGV(searchResults);
            CountStudents();
            // Kiểm tra điều kiện tìm kiếm
            if (string.IsNullOrEmpty(studentID) && string.IsNullOrEmpty(fullName) && cmbFaculty.SelectedIndex == -1)
            {
                // Nếu không có điều kiện nào được nhập, đặt txtAnswer về 0
                txtAnswer.Text = "0"; // Đặt lại giá trị mặc định
            }
            else if (searchResults.Count == 0)
            {
                // Nếu không tìm thấy sinh viên nào, hiển thị thông báo
                txtAnswer.Text = "0"; // Đặt lại txtAnswer về 0
                MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FillDataDGV(List<Student> listStudent)
        {
            dgvListStudent.Rows.Clear(); //lam sach du lieu dgv
            foreach (var student in listStudent)
            {
                int RowNew = dgvListStudent.Rows.Add();
                dgvListStudent.Rows[RowNew].Cells[0].Value = student.StudentID;
                dgvListStudent.Rows[RowNew].Cells[1].Value = student.FullName;
                dgvListStudent.Rows[RowNew].Cells[2].Value = student.Faculty.FacultyName;
                dgvListStudent.Rows[RowNew].Cells[3].Value = student.AverageScore;
            }
        }

        private void FillDataCMB(List<Faculty> listFaculty)
        {
            cmbFaculty.DataSource = listFaculty;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            try
            {
                //3. Goi csdl
                List<Student> listStudent = dbStudent.Student.ToList();
                List<Faculty> listFaculty = dbStudent.Faculty.ToList();

                FillDataCMB(listFaculty);
                FillDataDGV(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetForm()
        {
            // Xóa nội dung của các TextBox
            txtStudentID.Text = "";
            txtFullName.Text = "";
            dgvListStudent.DataSource = null;
            
            // Đặt lại ComboBox về mục mặc định
            cmbFaculty.SelectedIndex = -1; // Chọn lại mục mặc định trong ComboBox
            txtAnswer.Text = "0"; // Đặt lại giá trị mặc định
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Gọi hàm ResetForm để thiết lập lại các trường nhập liệu về mặc định
            ResetForm();
            LoadDGV();

            // Thông báo cho người dùng
            MessageBox.Show("Đã thiết lập lại các trường nhập liệu về mặc định!", "Thông báo", MessageBoxButtons.OK);
        }

        private void LoadForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
        }

        private void LoadDGV()
        {
            List<Student> newListStudent = dbStudent.Student.ToList();
            FillDataDGV(newListStudent);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CountStudents()
        {
            int studentCount = dgvListStudent.Rows.Count; // Đếm số dòng trong DataGridView

            // Nếu bạn có thêm dòng tiêu đề thì cần trừ 1
            if (dgvListStudent.AllowUserToAddRows) // Nếu cho phép thêm dòng mới
            {
                studentCount--; // Giảm số lượng sinh viên đi 1
            }

            // Hiển thị số lượng sinh viên vào txtTotalStudents
            txtAnswer.Text = studentCount.ToString();
        }
    }
}
