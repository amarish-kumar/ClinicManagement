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
    public partial class FormGiaDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FormGiaDichVu()
        {
            InitializeComponent();
        }
        private BaseFunctions<GiaDichVu> gdv = new BaseFunctions<GiaDichVu>();
        private BaseFunctions<DichVu> dv = new BaseFunctions<DichVu>();
        public int Madichvu { get; set; }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0 && txtsearch.Text != "")
            {
                gridControl1.DataSource = dv.SearchWord(int.Parse(txtsearch.Text), "ID");
            }
            else
                gridControl1.DataSource = dv.SearchWord(txtsearch.Text, "Ten");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                DichVu d = (DichVu)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                txtMadichvu.Text = d.MaDichVu.ToString();
                txtTendichvu.Text = d.TenDichVu;
            }
        }
        private GiaDichVu GetForm()
        {
            GiaDichVu d = new GiaDichVu();
            d.MaDichVu = int.Parse(txtMadichvu.Text);
            d.GiaTienDichVu = float.Parse(txtGiatiendichvu.Text);
            d.NgayCapNhat =DateTime.Parse(dtNgaycapnhat.Text);
            d.MaGiaDichVu = (txtMagiadichvu.Text!="")?int.Parse(txtMagiadichvu.Text):0;
            return d;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gdv.Add(GetForm());
            LoadTable();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gdv.Delete(int.Parse(txtMagiadichvu.Text));
            LoadTable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gdv.Update(GetForm());
            LoadTable();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMagiadichvu.ResetText();
            txtMadichvu.ResetText();
            txtTendichvu.ResetText();
            dtNgaycapnhat.ResetText();
            txtGiatiendichvu.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGiaDichVu_Load(object sender, EventArgs e)
        {
            txtMadichvu.Text = this.Madichvu.ToString();
            LoadTable();
        }
        private void LoadTable()
        {
            gridControl2.DataSource = gdv.SelectBy(int.Parse(txtMadichvu.Text), "MaDichVu");
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView2.SelectedRowsCount > 0)
            {
                GiaDichVu d = (GiaDichVu)gridView2.GetRow(gridView2.GetSelectedRows()[0]);
                txtMadichvu.Text = d.MaDichVu.ToString();
                txtGiatiendichvu.Text = d.GiaTienDichVu.ToString();
                txtMagiadichvu.Text = d.MaGiaDichVu.ToString();
                dtNgaycapnhat.Text = d.NgayCapNhat.ToShortDateString();
                DichVu a = dv.SelectByID(int.Parse(txtMadichvu.Text))[0];
                txtTendichvu.Text = a.TenDichVu;
            }
        }
    }
}