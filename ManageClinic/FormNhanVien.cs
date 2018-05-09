using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;

namespace ManageClinic
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tableChucDanh.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.tableChucDanh.ChucDanh);
        }
        private BaseFunctions<NhanVien> nv = new BaseFunctions<NhanVien>();

        private void btnChucDanh_Click(object sender, EventArgs e)
        {
            FormChucDanh frm = new FormChucDanh();
            frm.ShowDialog();
            frm.FormClosed += new FormClosedEventHandler(FormChucDanhClose);
        }
        private void FormChucDanhClose(object sender, FormClosedEventArgs e)
        {
            this.chucDanhTableAdapter.Fill(this.tableChucDanh.ChucDanh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nv.Add(GetForm());
            LoadFormNhanVien();
        }
        private void LoadFormNhanVien()
        {
            gridControl1.DataSource = nv.SelectAll();
        }
        private NhanVien GetForm()
        {
            NhanVien a = new NhanVien();
            a.MaNhanVien = (txtManhanvien.Text!="")?int.Parse(txtManhanvien.Text):-1;
            a.MaChucDanh = int.Parse(cbbMachucdanh.ValueMember);
            a.HoVaTen = txtHovaten.Text;
            a.DiaChi = txtDiachi.Text;
            a.NgaySinh = DateTime.Parse(dtNgaysinh.Text);
            a.NgayVaoLam = DateTime.Parse(dtNgayvaolam.Text);
            a.NgayNghiLam = DateTime.Parse(dtNgaynghilam.Text);
            a.SoCMND = txtSocmnd.Text;
            a.SoDienThoai = txtSodienthoai.Text;
            return a;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nv.Delete(int.Parse(txtManhanvien.Text));
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtManhanvien.ResetText();
            cbbMachucdanh.ResetText();
            txtHovaten.ResetText();
            txtDiachi.ResetText();
            txtSocmnd.ResetText();
            dtNgaysinh.ResetText();
            dtNgayvaolam.ResetText();
            dtNgaynghilam.ResetText();
            txtSodienthoai.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nv.Update(GetForm());
            LoadFormNhanVien();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                NhanVien a = (NhanVien)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                txtManhanvien.Text = a.MaNhanVien.ToString();
                cbbMachucdanh.ValueMember = a.MaChucDanh.ToString();
                txtHovaten.Text = a.HoVaTen;
                txtDiachi.Text = a.DiaChi;
                txtSocmnd.Text = a.SoCMND;
                dtNgaynghilam.EditValue = a.NgayNghiLam;
                dtNgaysinh.EditValue = a.NgaySinh;
                dtNgayvaolam.EditValue = a.NgayVaoLam;
                txtSodienthoai.Text = a.SoDienThoai;
            }
        }
    }
}