using Lap04_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap04_01
{
    public partial class frmFaculty : Form
    {
        StudentContextDB dbFaculty = new StudentContextDB();
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                //3. Goi csdl
                List<Faculty> listFaculty = dbFaculty.Faculty.ToList();

                FillDataDGV(listFaculty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDataDGV(List<Faculty> listFaculty)
        {
            dgvListFaculty.Rows.Clear(); //lam sach du lieu dgv
            foreach (var faculty in listFaculty)
            {
                int RowNew = dgvListFaculty.Rows.Add();
                dgvListFaculty.Rows[RowNew].Cells[0].Value = faculty.FacultyID;
                dgvListFaculty.Rows[RowNew].Cells[1].Value = faculty.FacultyName;
                dgvListFaculty.Rows[RowNew].Cells[2].Value = faculty.TotalProfessor;
            }
        }

        private void LoadForm()
        {
            txtFacultyID.Clear();
            txtFacultyName.Clear();
            txtTotalProfessor.Clear();
        }

        private void LoadDGV()
        {
            List<Faculty> newListFaculty = dbFaculty.Faculty.ToList();
            FillDataDGV(newListFaculty);
        }

        private void btnAddAndEdit_Click(object sender, EventArgs e)
        {
            if (CheckDataInput()) // Kiểm tra dữ liệu đầu vào
            {
                if (CheckFacultyID(txtFacultyID.Text) == -1) // Thêm mới nếu FacultyID trống
                {
                    Faculty newFaculty = new Faculty();
                    newFaculty.FacultyID = Convert.ToInt32(txtFacultyID.Text);
                    newFaculty.FacultyName = txtFacultyName.Text;
                    // Kiểm tra và gán giá trị cho TotalProfessor
                    if (string.IsNullOrWhiteSpace(txtTotalProfessor.Text))
                    {
                        // Nếu giá trị là null hoặc chuỗi trống, gán null cho TotalProfessor
                        newFaculty.TotalProfessor = null;
                    }
                    else
                    {
                        // Nếu không phải null, chuyển đổi sang kiểu int
                        newFaculty.TotalProfessor = Convert.ToInt32(txtTotalProfessor.Text);
                    }
                    dbFaculty.Faculty.AddOrUpdate(newFaculty); // Thêm hoặc cập nhật dữ liệu
                    dbFaculty.SaveChanges(); // Lưu thay đổi vào DB

                    MessageBox.Show("Thêm mới khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Chỉnh sửa
                {
                    int facultyID = Convert.ToInt32(txtFacultyID.Text);
                    Faculty dbUpdate = dbFaculty.Faculty.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (dbUpdate != null)
                    {
                        dbUpdate.FacultyName = txtFacultyName.Text;
                        // Kiểm tra và gán giá trị cho TotalProfessor
                        if (string.IsNullOrWhiteSpace(txtTotalProfessor.Text))
                        {
                            // Nếu giá trị là null hoặc chuỗi trống, gán null cho TotalProfessor
                            dbUpdate.TotalProfessor = null;
                        }
                        else
                        {
                            // Nếu không phải null, chuyển đổi sang kiểu int
                            dbUpdate.TotalProfessor = Convert.ToInt32(txtTotalProfessor.Text);
                        }
                        dbFaculty.Faculty.AddOrUpdate(dbUpdate);
                        dbFaculty.SaveChanges();

                        MessageBox.Show("Cập nhật khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khoa để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                LoadDGV(); // Cập nhật lại DataGridView
                LoadForm(); // Xóa trắng các trường nhập liệu
            }
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrEmpty(txtFacultyName.Text))
            {
                MessageBox.Show("Tên khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int CheckFacultyID(string idNewFaculty)
        {
            int length = dgvListFaculty.Rows.Count; //dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvListFaculty.Rows[i].Cells[0].Value != null)
                    if (dgvListFaculty.Rows[i].Cells[0].Value.ToString() == idNewFaculty)
                        return i;
            }
            return -1; // -1 la khong tim thay ma sv moi trong danh sach
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int facultyID = Convert.ToInt32(txtFacultyID.Text);
            Faculty dbDelete = dbFaculty.Faculty.FirstOrDefault(f => f.FacultyID == facultyID);
            // kiem tra xem doi tuong
            if (dbDelete != null)
            {
                DialogResult result = MessageBox.Show("Bạn có đồng ý xóa khoa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // code xoa 
                    #region code xoa
                    dbFaculty.Faculty.Remove(dbDelete);
                    dbFaculty.SaveChanges();
                    #endregion
                    // ham load lai table dgv
                    LoadDGV();
                    LoadForm();
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã khoa cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng dữ liệu mà người dùng chọn
                DataGridViewRow row = dgvListFaculty.Rows[e.RowIndex];

                txtFacultyID.Text = row.Cells[0].Value.ToString();
                txtFacultyName.Text = row.Cells[1].Value.ToString();
                // Kiểm tra nếu TotalProfessor là null, gán chuỗi trống nếu đúng
                if (row.Cells[2].Value == null || row.Cells[2].Value == DBNull.Value)
                {
                    txtTotalProfessor.Text = ""; // hoặc bạn có thể gán "0" nếu cần
                }
                else
                {
                    txtTotalProfessor.Text = row.Cells[2].Value.ToString();
                }
            }
        }
    }
}
