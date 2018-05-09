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
    public partial class FormGiaThuoc : DevExpress.XtraEditors.XtraForm
    {
        public FormGiaThuoc()
        {
            InitializeComponent();
        }
        private BaseFunctions<GiaThuoc> gt = new BaseFunctions<GiaThuoc>();
        private BaseFunctions<Thuoc> th = new BaseFunctions<Thuoc>();
        public int Mathuoc { get; set; }

        private void FormGiaThuoc_Load(object sender, EventArgs e)
        {
            this.txtMathuoc.Text = Mathuoc.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0 && this.txtSearch.Text != "")
            {
                gridControl1.DataSource = th.SearchWord(this.txtSearch.Text, "Ten");
            }
            else if (this.txtSearch.Text != "")
            {
                gridControl1.DataSource = th.SearchWord(int.Parse(this.txtSearch.Text), "Id");
            }
            else gridControl1.DataSource = th.SearchWord(this.txtSearch.Text, "Ten");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                Thuoc t = (Thuoc)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                txtMathuoc.Text = t.MaThuoc.ToString();
                txtTenthuoc.Text = t.TenThuoc;
            }
        }

        private void txtMathuoc_EditValueChanged(object sender, EventArgs e)
        {
            GiaThuoc g = new GiaThuoc();
            if (txtMathuoc.Text != "")
            {
               g = gt.GetLast(txtMathuoc.Text, "GiaThuocMaThuoc");
            }
            if(g!=null)
            {
                Thuoc t = th.SelectByID(int.Parse(txtMathuoc.Text))[0];
                txtMagiathuoc.Text = g.MaGiaThuoc.ToString();
                txtMathuoc.Text = g.MaThuoc.ToString();
                txtGianhap.Text = g.GiaNhap.ToString();
                txtGiaxuat.Text = g.GiaXuat.ToString();
                dtNgaycapnhat.Text = g.NgayCapNhat.ToShortDateString();
                txtTenthuoc.Text = t.TenThuoc;
            }
            LoadGiaThuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                gt.Add(GetFormGiaThuoc());
                LoadGiaThuoc();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Cập nhật giá không thành công");
            }
        }
        private GiaThuoc GetFormGiaThuoc()
        {
            GiaThuoc g = new GiaThuoc();
            g.MaGiaThuoc = int.Parse(txtMagiathuoc.Text);
            g.MaThuoc = int.Parse(txtMathuoc.Text);
            g.GiaNhap = float.Parse(txtGianhap.Text);
            g.GiaXuat = float.Parse(txtGiaxuat.Text);
            g.NgayCapNhat =DateTime.Parse(dtNgaycapnhat.Text);
            return g;
        }
        private void LoadGiaThuoc()
        {
            try
            {
                gridControl2.DataSource = gt.SelectBy(int.Parse(txtMathuoc.Text),"MaThuoc");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Dữ liệu trống hoặc bạn đã yêu cầu sai");
             
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                gt.Update(GetFormGiaThuoc());
                LoadGiaThuoc();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Sửa bị lỗi");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMathuoc.ResetText();
            txtTenthuoc.ResetText();
            txtGianhap.ResetText();
            txtGiaxuat.ResetText();
            dtNgaycapnhat.ResetText();
        }

        private void btnkethuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.SelectedRowsCount>0)
            {
                GiaThuoc g = (GiaThuoc)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
                txtMagiathuoc.Text = g.MaGiaThuoc.ToString();
                txtGianhap.Text = g.GiaNhap.ToString();
                txtGiaxuat.Text = g.GiaXuat.ToString();
                dtNgaycapnhat.Text = g.NgayCapNhat.ToShortDateString();
            }
        }
    }
}