namespace Lap04_04
{
    partial class Form1
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
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.dtpSend = new System.Windows.Forms.DateTimePicker();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            this.dgvListBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Location = new System.Drawing.Point(12, 165);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.RowHeadersWidth = 51;
            this.dgvListBill.RowTemplate.Height = 24;
            this.dgvListBill.Size = new System.Drawing.Size(1086, 347);
            this.dgvListBill.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpReceive);
            this.groupBox1.Controls.Add(this.dtpSend);
            this.groupBox1.Controls.Add(this.chkView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // dtpReceive
            // 
            this.dtpReceive.Location = new System.Drawing.Point(428, 87);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(200, 22);
            this.dtpReceive.TabIndex = 1;
            this.dtpReceive.ValueChanged += new System.EventHandler(this.dtpSend_ValueChanged);
            // 
            // dtpSend
            // 
            this.dtpSend.Location = new System.Drawing.Point(200, 87);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(200, 22);
            this.dtpSend.TabIndex = 1;
            this.dtpSend.ValueChanged += new System.EventHandler(this.dtpSend_ValueChanged);
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(46, 39);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(160, 20);
            this.chkView.TabIndex = 0;
            this.chkView.Text = "Xem tất cả trong tháng";
            this.chkView.UseVisualStyleBackColor = true;
            this.chkView.CheckedChanged += new System.EventHandler(this.chkView_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(915, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Cộng:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(998, 531);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 22);
            this.txtSum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 570);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListBill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSend;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSum;
    }
}

