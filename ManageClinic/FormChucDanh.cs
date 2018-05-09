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
    public partial class FormChucDanh : DevExpress.XtraEditors.XtraForm
    {
        public FormChucDanh()
        {
            InitializeComponent();
        }
        private BaseFunctions<ChucDanh> cd = new BaseFunctions<ChucDanh>();
        public ChucDanh GetForm()
        {
            ChucDanh d = new ChucDanh();
            d.MaChucDanh = (txtMachucdanh.Text != "") ?int.Parse(txtMachucdanh.Text):-1;
            d.TenChucDanh = txtTenchucdanh.Text;
            d.MoTaCongViec = txtMota.Text;
            return d;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cd.Add(GetForm());
            LoadChucDanh();
        }
        private void LoadChucDanh()
        {
            gridControl1.DataSource = cd.SelectAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cd.Delete(int.Parse(txtMachucdanh.Text));
            LoadChucDanh();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.SelectedRowsCount>0)
            {
                ChucDanh d = (ChucDanh)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                txtMota.Text = d.MoTaCongViec;
                txtTenchucdanh.Text = d.TenChucDanh;
                txtMachucdanh.Text = d.MaChucDanh.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cd.Update(GetForm());
            LoadChucDanh();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMachucdanh.ResetText();
            txtTenchucdanh.ResetText();
            txtMota.ResetText();
        }

        private void btnKethuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}