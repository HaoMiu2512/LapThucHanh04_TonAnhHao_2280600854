using Lap04_04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap04_04
{
    public partial class Form1 : Form
    {
        BillContextDB dbBill = new BillContextDB();
        public Form1()
        {
            InitializeComponent();
            // Sự kiện khi thay đổi ngày trong DateTimePicker
            dtpSend.ValueChanged += dtpSend_ValueChanged;
            dtpReceive.ValueChanged += dtpSend_ValueChanged;

            // Load dữ liệu mặc định khi Form được mở
            LoadInvoiceData(DateTime.Now, DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lấy giá trị từ cả hai DateTimePicker
            DateTime selectedOrderDate = dtpSend.Value;
            DateTime selectedDeliveryDate = dtpReceive.Value;

            // Gọi phương thức load dữ liệu theo cả OrderDate và DeliveryDate
            LoadInvoiceData(selectedOrderDate, selectedDeliveryDate);
        }

        private void LoadInvoiceData(int month, int year)
        {
            using (var context = new BillContextDB())
            {
                var invoiceData = context.Order.AsQueryable();

                // Lọc hóa đơn theo tháng và năm
                invoiceData = invoiceData.Where(o => o.Invoice.OrderDate.Month == month && o.Invoice.OrderDate.Year == year);

                // Nhóm và tính toán tổng số tiền
                var groupedData = invoiceData
                    .GroupBy(o => new { o.InvoiceNo, o.Invoice.OrderDate, o.Invoice.DeliveryDate })
                    .Select(g => new
                    {
                        STT = 0, // Số thứ tự sẽ tự động cấp sau
                        InvoiceNo = g.Key.InvoiceNo,
                        OrderDate = g.Key.OrderDate,
                        DeliveryDate = g.Key.DeliveryDate,
                        TotalAmount = g.Sum(x => x.Price * x.Quantity) // Thành tiền
                    })
                    .ToList();

                // Tự động cấp số thứ tự
                int counter = 1;
                var dataWithIndex = groupedData.Select(i => new
                {
                    STT = counter++, // Cấp số thứ tự
                    i.InvoiceNo,
                    i.OrderDate,
                    i.DeliveryDate,
                    i.TotalAmount
                }).ToList();

                // Gán dữ liệu cho DataGridView
                dgvListBill.DataSource = dataWithIndex;
                decimal totalSum = dataWithIndex.Sum(x => x.TotalAmount);
                txtSum.Text = "Tổng cộng: " + totalSum.ToString(); // Định dạng tiền tệ
            }
        }
        // Thêm phương thức LoadInvoiceData cho việc lọc theo ngày
        private void LoadInvoiceData(DateTime orderDate, DateTime deliveryDate)
        {
            using (var context = new BillContextDB())
            {
                var invoiceData = context.Order.AsQueryable();

                // Lọc hóa đơn theo ngày đặt hàng và giao hàng
                invoiceData = invoiceData.Where(o =>
                    DbFunctions.TruncateTime(o.Invoice.OrderDate) >= DbFunctions.TruncateTime(orderDate) &&
                    DbFunctions.TruncateTime(o.Invoice.DeliveryDate) < DbFunctions.TruncateTime(deliveryDate));

                // Nhóm và tính toán tổng số tiền
                var groupedData = invoiceData
                    .GroupBy(o => new { o.InvoiceNo, o.Invoice.OrderDate, o.Invoice.DeliveryDate })
                    .Select(g => new
                    {
                        STT = 0, // Số thứ tự sẽ tự động cấp sau
                        InvoiceNo = g.Key.InvoiceNo,
                        OrderDate = g.Key.OrderDate,
                        DeliveryDate = g.Key.DeliveryDate,
                        TotalAmount = g.Sum(x => x.Price * x.Quantity) // Thành tiền
                    })
                    .ToList();

                // Tự động cấp số thứ tự
                int counter = 1;
                var dataWithIndex = groupedData.Select(i => new
                {
                    STT = counter++, // Cấp số thứ tự
                    i.InvoiceNo,
                    i.OrderDate,
                    i.DeliveryDate,
                    i.TotalAmount
                }).ToList();

                // Gán dữ liệu cho DataGridView
                dgvListBill.DataSource = dataWithIndex;
                decimal totalSum = dataWithIndex.Sum(x => x.TotalAmount);
                txtSum.Text = "Tổng cộng: " + totalSum.ToString("C"); // Định dạng tiền tệ
            }
        }

        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
            // Gọi phương thức load dữ liệu theo trạng thái checkbox
            if (chkView.Checked)
            {
                // Nếu checkbox được chọn, lấy tháng và năm từ DateTimePicker
                DateTime selectedDate = dtpSend.Value;
                LoadInvoiceData(selectedDate.Month, selectedDate.Year); // Gọi phương thức với Month và Year
            }
            else
            {
                // Nếu checkbox không được chọn, chỉ lấy theo ngày
                LoadInvoiceData(dtpSend.Value, dtpReceive.Value); // Gọi phương thức với hai ngày
            }
        }

        private void dtpSend_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ cả hai DateTimePicker
            DateTime selectedOrderDate = dtpSend.Value;
            DateTime selectedDeliveryDate = dtpReceive.Value;

            // Gọi phương thức load dữ liệu theo cả OrderDate và DeliveryDate
            LoadInvoiceData(selectedOrderDate, selectedDeliveryDate);
        }

    }
}
