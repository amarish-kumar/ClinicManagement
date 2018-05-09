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
    public partial class FormChiTietDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FormChiTietDichVu()
        {
            InitializeComponent();
        }
        private BaseFunctions<DichVu> dv = new BaseFunctions<DichVu>();
        private BaseFunctions<ChiTietHoaDonDichVu> ctdv = new BaseFunctions<ChiTietHoaDonDichVu>();
        private BaseFunctions<GiaDichVu> gdv = new BaseFunctions<GiaDichVu>();
        public string Mahoadon { get; set; }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (rdtimkiem.SelectedIndex == 0 && txtsearch.Text != "")
            {
                gridControl1.DataSource = dv.SearchWord(int.Parse(txtsearch.Text), "ID");
            }
            else
                gridControl1.DataSource = dv.SearchWord(txtsearch.Text, "Ten");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.SelectedRowsCount>0)
            {
                DichVu d = (DichVu)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                this.txtMadichvu.Text = d.MaDichVu.ToString();
                this.txtTendichvu.Text = d.TenDichVu;
                this.txtDonvi.Text = d.DonVi;
            }
        }

        private void txtMadichvu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GiaDichVu g = gdv.GetLast(int.Parse(txtMadichvu.Text), "GiaDichVuMaDichVu");
                txtGia.Text = g.GiaTienDichVu.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                DichVu d = (DichVu)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                this.txtMadichvu.Text = d.MaDichVu.ToString();
                this.txtTendichvu.Text = d.TenDichVu;
                this.txtDonvi.Text = d.DonVi;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDonDichVu> ds = ctdv.SelectBy(int.Parse(txtMadichvu.Text), "MaDichVu");
            ChiTietHoaDonDichVu d = (ds.Count > 0) ? ds[0] : null;
            ChiTietHoaDonDichVu a = GetFormChiTietHoaDonDichVu();
            if (d != null)
            {
                a.SoLan = a.SoLan + d.SoLan;
                ctdv.Update(a);
            }
            else ctdv.Add(a);
            LoadChiTietDichVu();
        }
        private ChiTietHoaDonDichVu GetFormChiTietHoaDonDichVu()
        {
            ChiTietHoaDonDichVu d = new ChiTietHoaDonDichVu();
            d.MaHoaDon = txtMahoadon.Text;
            d.MaDichVu = int.Parse(txtMadichvu.Text);
            d.MaCTHDDichVu = (txtmaCTHD.Text!="")?int.Parse(txtmaCTHD.Text):0;
            d.SoLan = int.Parse(txtSolan.Text);
            return d;
        }
        private void LoadChiTietDichVu()
        {
            try
            {
                gridControl2.DataSource = ctdv.GetBy("MaHoaDon", Mahoadon);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmaCTHD.Text != "")
            {
                ctdv.Delete(txtmaCTHD.Text);
                LoadChiTietDichVu();
            }
            else XtraMessageBox.Show("Chưa có thông tin mã chi tiết dịch vụ");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ctdv.Update(GetFormChiTietHoaDonDichVu());
            LoadChiTietDichVu();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            this.txtMadichvu.ResetText();
            this.txtTendichvu.ResetText();
            this.txtmaCTHD.ResetText();
            this.txtSolan.ResetText();
            this.txtGia.ResetText();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView2.SelectedRowsCount>0)
            {
                DataRow data = gridView2.GetFocusedDataRow();
                txtmaCTHD.Text = data["MaCTHDDichVu"].ToString();
                txtMadichvu.Text = data["MaDichVu"].ToString();
                txtTendichvu.Text = data["TenDichVu"].ToString();
                txtSolan.Text = data["SoLan"].ToString();
                txtDonvi.Text = data["DonVi"].ToString();
                txtGia.Text = data["DonGia"].ToString();
            }
        }

        private void FormChiTietDichVu_Load(object sender, EventArgs e)
        {
            this.txtMahoadon.Text = Mahoadon;
            LoadChiTietDichVu();
        }

        private void btnCapnhatgia_Click(object sender, EventArgs e)
        {
            FormGiaDichVu frm = new FormGiaDichVu();
            frm.FormClosed += new FormClosedEventHandler(txtMadichvu_TextChanged);
            frm.Madichvu = int.Parse(txtMadichvu.Text);
            frm.ShowDialog();
        }
    }
}