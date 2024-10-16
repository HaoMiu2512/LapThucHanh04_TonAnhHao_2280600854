namespace Lap04_01
{
    partial class frmFaculty
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
            this.dgvListFaculty = new System.Windows.Forms.DataGridView();
            this.dgvFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddAndEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFaculty)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListFaculty
            // 
            this.dgvListFaculty.AllowUserToAddRows = false;
            this.dgvListFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFacultyID,
            this.dgvFacultyName,
            this.dgvTotalProfessor});
            this.dgvListFaculty.Location = new System.Drawing.Point(471, 34);
            this.dgvListFaculty.Name = "dgvListFaculty";
            this.dgvListFaculty.RowHeadersWidth = 51;
            this.dgvListFaculty.RowTemplate.Height = 24;
            this.dgvListFaculty.Size = new System.Drawing.Size(636, 389);
            this.dgvListFaculty.TabIndex = 0;
            this.dgvListFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListFaculty_CellClick);
            // 
            // dgvFacultyID
            // 
            this.dgvFacultyID.HeaderText = "Mã Khoa";
            this.dgvFacultyID.MinimumWidth = 6;
            this.dgvFacultyID.Name = "dgvFacultyID";
            // 
            // dgvFacultyName
            // 
            this.dgvFacultyName.HeaderText = "Tên Khoa";
            this.dgvFacultyName.MinimumWidth = 6;
            this.dgvFacultyName.Name = "dgvFacultyName";
            // 
            // dgvTotalProfessor
            // 
            this.dgvTotalProfessor.HeaderText = "Tổng số GS";
            this.dgvTotalProfessor.MinimumWidth = 6;
            this.dgvTotalProfessor.Name = "dgvTotalProfessor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalProfessor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFacultyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFacultyID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(134, 169);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(270, 22);
            this.txtTotalProfessor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng số GS";
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(134, 103);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(270, 22);
            this.txtFacultyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoa";
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(134, 42);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(270, 22);
            this.txtFacultyID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddAndEdit
            // 
            this.btnAddAndEdit.Location = new System.Drawing.Point(235, 387);
            this.btnAddAndEdit.Name = "btnAddAndEdit";
            this.btnAddAndEdit.Size = new System.Drawing.Size(111, 36);
            this.btnAddAndEdit.TabIndex = 2;
            this.btnAddAndEdit.Text = "Thêm / Sửa";
            this.btnAddAndEdit.UseVisualStyleBackColor = true;
            this.btnAddAndEdit.Click += new System.EventHandler(this.btnAddAndEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1035, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 489);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddAndEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListFaculty);
            this.Name = "frmFaculty";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFaculty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListFaculty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddAndEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalProfessor;
    }
}