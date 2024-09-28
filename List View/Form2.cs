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
    public partial class NhanVienForm : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public string LuongCB { get; set; }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            // Lưu thông tin nhân viên
            MSNV = txtMSNV.Text;
            TenNV = txtTenNV.Text;
            LuongCB = txtLuongCB.Text;
            this.Close();
        }

    }
}
