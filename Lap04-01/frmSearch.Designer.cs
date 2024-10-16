namespace Lap04_01
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.dgvStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStudentID,
            this.dgvFullName,
            this.dgvFaculty,
            this.dgvAverageScore});
            this.dgvListStudent.Location = new System.Drawing.Point(12, 231);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.RowHeadersWidth = 51;
            this.dgvListStudent.RowTemplate.Height = 24;
            this.dgvListStudent.Size = new System.Drawing.Size(1097, 208);
            this.dgvListStudent.TabIndex = 0;
            // 
            // dgvStudentID
            // 
            this.dgvStudentID.HeaderText = "Mã Số SV";
            this.dgvStudentID.MinimumWidth = 6;
            this.dgvStudentID.Name = "dgvStudentID";
            // 
            // dgvFullName
            // 
            this.dgvFullName.HeaderText = "Họ Tên";
            this.dgvFullName.MinimumWidth = 6;
            this.dgvFullName.Name = "dgvFullName";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.HeaderText = "Tên Khoa";
            this.dgvFaculty.MinimumWidth = 6;
            this.dgvFaculty.Name = "dgvFaculty";
            // 
            // dgvAverageScore
            // 
            this.dgvAverageScore.HeaderText = "Điểm TB";
            this.dgvAverageScore.MinimumWidth = 6;
            this.dgvAverageScore.Name = "dgvAverageScore";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(121, 124);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(275, 24);
            this.cmbFaculty.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Số SV";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(121, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(275, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(121, 32);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(195, 22);
            this.txtStudentID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(609, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(699, 186);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1034, 186);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 39);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả tìm kiếm";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(1009, 448);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(100, 22);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 482);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListStudent);
            this.Name = "frmSearch";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAverageScore;
    }
}