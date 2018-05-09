using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace ManageClinic
{
    public partial class FormQuanLyHoso : DevExpress.XtraEditors.XtraForm
    {
        public FormQuanLyHoso()
        {
            InitializeComponent();
        }
        private BaseFunctions<BenhNhan> t = new BaseFunctions<BenhNhan>();
        private BaseFunctions<BenhAn> a = new BaseFunctions<BenhAn>();
        private BaseFunctions<HoaDon> hd = new BaseFunctions<HoaDon>();
        private string MaHoaDon { get; set; }
        private void FormQuanLyHoso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPhongKhamLKBenhNhan.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.qLPhongKhamLKBenhNhan.BenhNhan);
            // TODO: This line of code loads data into the 'qLPhongKhamBenhNhan.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLPhongKhamBenhNhan.NhanVien);
            LoadGridView();
            KiemTraHoaDon();
        }
        private void LoadGridView()
        {
            gridControl1.DataSource = a.SelectBy(cbbMaBN.SelectedValue,"MaBenhNhan");
        }
        private void SetThongTinBenhNhan()
        {
            List<BenhNhan> ds= t.SelectByID(cbbMaBN.SelectedValue);
            if (ds.Count > 0)
            {
                BenhNhan bn = ds[0];
                txtHoten.Text = bn.HoVaTen;
                txtSocmnd.Text = bn.CMND;
                dtNgaysinh.Text = bn.NgaySinh.ToShortDateString();
                txtSDT.Text = bn.SDTBenhNhan;
                txtTennguoithan.Text = bn.TenNguoiThan;
                txtSdtnguoithan.Text = bn.SDTThanNhan;
            }
        }

        private void cbbMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetThongTinBenhNhan();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            a.Delete(txtMabenhan.Text);
            LoadGridView();
        }
        private BenhAn GetFormBenhAn()
        {
            BenhAn ba = new BenhAn();
            ba.MaBenhAn = txtMabenhan.Text;
            ba.NgayKham =DateTime.Parse(dtNgaykham.Text);
            ba.TrieuChung = txtTrieuchung.Text;
            ba.KetLuan = txtketluan.Text;
            ba.NgayTaiKham =DateTime.Parse(dtNgaytaikham.Text);
            ba.MaNhanVien = cbbBacSy.SelectedValue.ToString();
            ba.ManBenhNhan = cbbMaBN.SelectedValue.ToString();
            return ba;
        }
        private void SetFormBenhAn()
        {
            BenhAn ba = new BenhAn();
            if (gridView1.SelectedRowsCount > 0)

            {
                ba = (BenhAn)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                this.txtMabenhan.Text = ba.MaBenhAn;
                this.dtNgaykham.Text = ba.NgayKham.ToShortDateString();
                this.txtTrieuchung.Text = ba.TrieuChung;
                this.txtketluan.Text = ba.KetLuan;
                this.dtNgaytaikham.Text = ba.NgayTaiKham.ToShortDateString();
                this.cbbBacSy.SelectedValue = ba.MaNhanVien;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo mã bệnh án
            BenhAn b = new BenhAn();
            b = a.GetLastID();
            long s = -1;
            if (b != null)
                s = long.Parse(b.MaBenhAn.Substring(2));
            s++;
            string kq = "BA" + s;
            while (kq.Length < 13)
            {
                kq = kq.Insert(2, "0");
            }
            //-----------------------------------------
            BenhAn ba = GetFormBenhAn();
            ba.MaBenhAn = kq;
            a.Add(ba);
            LoadGridView();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            this.txtMabenhan.ResetText();
            this.txtTrieuchung.ResetText();
            this.txtketluan.ResetText();
            this.dtNgaykham.ResetText();
            this.dtNgaytaikham.ResetText();
            this.cbbBacSy.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMabenhan.Text == null)
                MessageBox.Show("Chua chon ma benh an");
            else
                a.Update(GetFormBenhAn());
            LoadGridView();
        }

        private void btnLoadBenhNhan_Click(object sender, EventArgs e)
        {
            FormBenhNhan frm = new FormBenhNhan();
            frm.FormClosed += new FormClosedEventHandler(LoadBenhNhan);
            frm.ShowDialog();
        }
        private void LoadBenhNhan(object sender,FormClosedEventArgs e)
        {
            this.benhNhanTableAdapter.Fill(this.qLPhongKhamLKBenhNhan.BenhNhan);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetFormBenhAn();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //button Tạo hóa đơn
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.btnKedon.Enabled = true;
            this.btnDichvu.Enabled = true;
            this.btnTaohoadon.Enabled = false;
            HoaDon h = new HoaDon();
            h.LoaiHoaDon = true;
            h.TenKhachHang = txtHoten.Text;
            h.TenNhaCungCap = "Phòng khám ABC";
            h.MaKhachHang = txtMabenhan.Text;
            //Tạo mã hóa đơn
            HoaDon b = new HoaDon();
            b = hd.GetLastID();
            long s = -1;
            if (b != null)
                s = long.Parse(b.MaHoaDon.Substring(2));
            s++;
            string kq = "HD" + s;
            while (kq.Length < 13)
            {
                kq = kq.Insert(2, "0");
            }
            //-----------------------------------------------------
            h.MaHoaDon = kq;
            this.MaHoaDon = kq;
            hd.Add(h);
        }

        private void btnKedon_Click(object sender, EventArgs e)
        {
            FormChiTietThuoc frm = new FormChiTietThuoc();
            frm.MahoaDon = this.MaHoaDon;
            frm.ShowDialog();
        }
        // kiểm tra bệnh án đã tạo hóa đơn chưa
        private void KiemTraHoaDon()
        {
            HoaDon d = new HoaDon();
            if (txtMabenhan.Text == "")
                d = null;
            else
            {
                List<HoaDon> array = hd.SelectBy(txtMabenhan.Text, "MaKhachHang");
                if (array.Count > 0)
                    d = array[0];
                else  d=null ;

            }
            if (d == null)
            {
                this.btnKedon.Enabled = false;
                this.btnDichvu.Enabled = false;
                this.btnTaohoadon.Enabled = true;
            }
            else
            {
                this.btnKedon.Enabled = true;
                this.btnDichvu.Enabled = true;
                this.btnTaohoadon.Enabled = false;
                MaHoaDon = d.MaHoaDon;
            }
        }

        private void txtMabenhan_EditValueChanged(object sender, EventArgs e)
        {
            KiemTraHoaDon();
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            FormChiTietDichVu frm = new FormChiTietDichVu();
            frm.Mahoadon = MaHoaDon;
            frm.ShowDialog();
        }
    }
}