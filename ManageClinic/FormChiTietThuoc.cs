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
    public partial class FormChiTietThuoc : DevExpress.XtraEditors.XtraForm
    {
        public FormChiTietThuoc()
        {
            InitializeComponent();
        }
        private BaseFunctions<Thuoc> th= new BaseFunctions<Thuoc>();
        private BaseFunctions<ChiTietHoaDonThuoc> thdetail = new BaseFunctions<ChiTietHoaDonThuoc>();
        private BaseFunctions<GiaThuoc> gt = new BaseFunctions<GiaThuoc>();

        public string MahoaDon { get; set; }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if ( radioGroup1.SelectedIndex == 0 && this.search.Text!="")
            {
                gridControl1.DataSource = th.SearchWord(this.search.Text, "Ten");
            }
            else if(this.search.Text != "")
            {
                gridControl1.DataSource = th.SearchWord(int.Parse(this.search.Text), "Id");
            }
            else gridControl1.DataSource = th.SearchWord(this.search.Text, "Ten");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                Thuoc t = (Thuoc)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                txtMathuoc.Text = t.MaThuoc.ToString();
                txtTenthuoc.Text = t.TenThuoc;
            }
        }

        private void txtMathuoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GiaThuoc g = gt.GetLast(int.Parse(txtMathuoc.Text), "GiaThuocMaThuoc");
                txtGia.Text = g.GiaXuat.ToString();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Chưa có thông tin giá thuốc");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<ChiTietHoaDonThuoc> ds = thdetail.SelectBy(txtMathuoc.Text, "MaThuoc");
            ChiTietHoaDonThuoc t= (ds.Count>0) ? ds[0] : null;
            ChiTietHoaDonThuoc a = Getformctthuoc();
            if (t!=null)
                {
                    a.SoLuong = a.SoLuong + t.SoLuong;
                    thdetail.Update(a);
                }else
                    thdetail.Add(a);
                LoadChiTietThuoc();
        }
        private ChiTietHoaDonThuoc Getformctthuoc()
        {
            ChiTietHoaDonThuoc ctth = new ChiTietHoaDonThuoc();
            ctth.MaCTHDThuoc = (txtMachitietthuoc.Text!="")?int.Parse(txtMachitietthuoc.Text):0;
            ctth.MaThuoc = int.Parse(txtMathuoc.Text);
            ctth.MaHoaDon = txtMahoadon.Text;
            ctth.SoLuong = int.Parse(txtSoluong.Text);
            return ctth;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMachitietthuoc.Text != "")
            {
                thdetail.Delete(txtMachitietthuoc.Text);
                LoadChiTietThuoc();
            }
            else XtraMessageBox.Show("Chưa có thông tin mã chi tiết thuốc");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                thdetail.Update(Getformctthuoc());
                LoadChiTietThuoc();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            this.txtMathuoc.ResetText();
            this.txtMachitietthuoc.ResetText();
            this.txtTenthuoc.ResetText();
            this.txtSoluong.ResetText();
            this.txtDonvi.ResetText();
            this.txtGia.ResetText();
        }

        private void btnKethuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // đẩy dữ liệu từ bảng lên textbox
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView2.SelectedRowsCount>0)
            {
                DataRow data = gridView2.GetFocusedDataRow();
                txtMathuoc.Text = data["MaThuoc"].ToString();
                txtMachitietthuoc.Text = data["MaCTHDThuoc"].ToString();
                txtTenthuoc.Text = data["TenThuoc"].ToString();
                txtSoluong.Text = data["SoLuong"].ToString();
                txtDonvi.Text = data["DonVi"].ToString();
                txtGia.Text = data["DonGia"].ToString();
            }
        }

        private void btnCapnhatgia_Click(object sender, EventArgs e)
        {
            FormGiaThuoc frm = new FormGiaThuoc();
            if(txtMathuoc.Text!="")
                frm.Mathuoc = int.Parse(txtMathuoc.Text);
            frm.ShowDialog();
        }

        private void FormChiTietThuoc_Load(object sender, EventArgs e)
        {
            this.txtMahoadon.Text = this.MahoaDon;
            LoadChiTietThuoc();
        }
        private void LoadChiTietThuoc()
        {
            try
            {
                gridControl2.DataSource = thdetail.GetBy("MaHoaDon",MahoaDon);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Chưa tồn tại dữ liệu !");
            }
        }
    }
}