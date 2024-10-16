using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lap04_01.Model; //1. Khai bao csdl

namespace Lap04_01
{
    public partial class Form1 : Form
    { //2. Khoi tao csdl
        StudentContextDB dbStudent = new StudentContextDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckStudentID(txtStudentID.Text) == -1) // -1 la sinh vien moi
                {
                    Student newStudent = new Student(); // tao doi tuong sv moi
                    // gan gia tri cho doi tuong sv moi
                    newStudent.StudentID = txtStudentID.Text;
                    newStudent.FullName = txtFullName.Text;
                    newStudent.FacultyID = Convert.ToInt32(cmbFaculty.SelectedValue.ToString());
                    newStudent.AverageScore = Convert.ToDouble(txtAverageScore.Text);
                    // dua sv moi vao danh sach
                    dbStudent.Student.AddOrUpdate(newStudent);
                    dbStudent.SaveChanges();

                    LoadDGV();
                    LoadForm();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Dữ liệu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LoadForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
        }

        private void LoadDGV()
        {
            List<Student> newListStudent = dbStudent.Student.ToList();
            FillDataDGV(newListStudent);
        }

        private int CheckStudentID(string idNewStudent)
        {
            int length = dgvListStudent.Rows.Count; //dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvListStudent.Rows[i].Cells[0].Value != null)
                    if (dgvListStudent.Rows[i].Cells[0].Value.ToString() == idNewStudent)
                        return i;
            }
            return -1; // -1 la khong tim thay ma sv moi trong danh sach
        }

        /// <summary> ham kiem tra du lieu dau vao
        private bool CheckDataInput()
        {
            // Kiểm tra các trường bắt buộc không được để trống
            if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra mã số sinh viên phải có đúng 10 ký tự
            else if (txtStudentID.TextLength != 10 || !txtStudentID.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mã số sinh viên phải có 10 ký tự và không được chứa chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra điểm trung bình có phải là số hợp lệ kiểu float hay không
            else
            {
                float averageScore;
                bool score = float.TryParse(txtAverageScore.Text, out averageScore);
                if (!score)
                {
                    MessageBox.Show("Điểm sinh viên chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (averageScore < 0 || averageScore > 10)
                {
                    MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            // Nếu tất cả kiểm tra đều hợp lệ
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // FirstOrdefault lay phan tu dau tien thoa dieu kien
            Student dbUpdate = dbStudent.Student.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
            // kiem tra xem doi tuong
            if (dbUpdate != null)
            {
                // gan cac doi tuong update moi
                #region code gan gia tri
                dbUpdate.FullName = txtFullName.Text;
                dbUpdate.FacultyID = Convert.ToInt32(cmbFaculty.SelectedValue.ToString());
                dbUpdate.AverageScore = Convert.ToDouble(txtAverageScore.Text);
                #endregion
                // dua du lieu khi thay doi vao DB
                dbStudent.Student.AddOrUpdate(dbUpdate);
                dbStudent.SaveChanges();
                // ham load lai table dgv
                LoadDGV();
                LoadForm();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student dbDelete = dbStudent.Student.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
            // kiem tra xem doi tuong
            if (dbDelete != null)
            {
                DialogResult result = MessageBox.Show("Bạn có đồng ý xóa sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // code xoa 
                    #region code xoa
                    dbStudent.Student.Remove(dbDelete);
                    dbStudent.SaveChanges();
                    #endregion
                    // ham load lai table dgv
                    LoadDGV();
                    LoadForm();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số dòng hợp lệ (tránh lỗi khi người dùng click vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu mà người dùng chọn
                DataGridViewRow row = dgvListStudent.Rows[e.RowIndex];

                // Hiển thị thông tin của sinh viên đã chọn vào các TextBox và ComboBox
                txtStudentID.Text = row.Cells[0].Value.ToString(); // Lấy giá trị StudentID
                txtFullName.Text = row.Cells[1].Value.ToString(); // Lấy giá trị FullName
                cmbFaculty.Text = row.Cells[2].Value.ToString(); // Lấy giá trị FacultyID
                txtAverageScore.Text = row.Cells[3].Value.ToString(); // Lấy giá trị AverageScore

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form nếu người dùng chọn "Có"
            }
        }

        private void btnUpdateFaculty_Click(object sender, EventArgs e)
        {
            // Tạo form quản lý khoa
            List<Faculty> listFaculty = dbStudent.Faculty.ToList();

            FillDataCMB(listFaculty);
            cmbFaculty.SelectedIndex = -1;
            frmFaculty frmFaculty = new frmFaculty();
           
            frmFaculty.ShowDialog();
           
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void tsbControl_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.FormClosed += new FormClosedEventHandler(frmFaculty_FormClosed);
            frmFaculty.ShowDialog();
        }

        private void frmFaculty_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Faculty> listFaculty = dbStudent.Faculty.ToList();
            FillDataCMB(listFaculty);
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            List<Student> listStudent = dbStudent.Student.ToList();
            List<Faculty> listFaculty = dbStudent.Faculty.ToList();

            FillDataCMB(listFaculty);
            FillDataDGV(listStudent);

            FillDataCMB(listFaculty);
            frmFaculty.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form nếu người dùng chọn "Có"
            }
        }

       
    }
}
