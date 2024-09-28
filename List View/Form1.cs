using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở form Nhân viên
            NhanVienForm form = new NhanVienForm();
            form.ShowDialog();
            // Thêm thông tin nhân viên vào dataGridView
            dataGridView.Rows.Add(form.MSNV, form.TenNV, form.LuongCB);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhân viên được chọn
            int index = dataGridView.CurrentRow.Index;
            string MSNV = dataGridView.Rows[index].Cells[0].Value.ToString();
            string TenNV = dataGridView.Rows[index].Cells[1].Value.ToString();
            string LuongCB = dataGridView.Rows[index].Cells[2].Value.ToString();
            // Mở form Nhân viên
            NhanVienForm form = new NhanVienForm();
            form.MSNV = MSNV;
            form.TenNV = TenNV;
            form.LuongCB = LuongCB;
            form.ShowDialog();
            // Sửa thông tin nhân viên trong dataGridView
            dataGridView.Rows[index].Cells[0].Value = form.MSNV;
            dataGridView.Rows[index].Cells[1].Value = form.TenNV;
            dataGridView.Rows[index].Cells[2].Value = form.LuongCB;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa thông tin nhân viên được chọn
            int index = dataGridView.CurrentRow.Index;
            dataGridView.Rows.RemoveAt(index);
        }
    }
}
