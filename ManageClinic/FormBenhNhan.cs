using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DataAccess;

namespace ManageClinic
{
    public partial class FormBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        public FormBenhNhan()
        {
            InitializeComponent();
        }
        private int Dem { get; set; }
        private BaseFunctions<BenhNhan> t = new BaseFunctions<BenhNhan>();

        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            gridcontrol1.DataSource = t.SelectAll();
        }
        private BenhNhan GetBenhNhanForm()
        {
            BenhNhan bn = new BenhNhan();
            bn.MaBenhNhan = txtMabenhnhan.Text;
            bn.HoVaTen =    txtHovaten.Text;
            bn.NgaySinh =   dtNgaysinh.DateTime;
            bn.CMND =       txtSocmnd.Text;
            bn.TenNguoiThan = txtHotenthannhan.Text;
            bn.SDTThanNhan = txtSodtthannhan.Text;
            bn.SDTBenhNhan = txtSodienthoai.Text;
            return bn;
        }
        private void SetFormBenhNhan(BenhNhan bn)
        {
            this.txtMabenhnhan.Text = bn.MaBenhNhan;
            this.txtHovaten.Text = bn.HoVaTen;
            this.dtNgaysinh.DateTime = bn.NgaySinh;
            this.txtSocmnd.Text = bn.CMND;  
            this.txtHotenthannhan.Text = bn.TenNguoiThan;
            this.txtSodtthannhan.Text= bn.SDTThanNhan;
            this.txtSodienthoai.Text= bn.SDTBenhNhan ;
        }
        private BenhNhan GetGridView()
        {
            BenhNhan bn = new BenhNhan();
            if (gridView1.SelectedRowsCount>0)
            {
                BenhNhan item =(BenhNhan)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
                bn = item;
            }
            return bn;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            BenhNhan bn = new BenhNhan();
            bn = GetBenhNhanForm();
            BenhNhan b = new BenhNhan();
            b=t.GetLastID();
            long s=-1;
            if (b != null)
                s=long.Parse(b.MaBenhNhan.Substring(2));
            s++;
            string kq = "BN" + s;
            while (kq.Length<13)
            {
                kq = kq.Insert(2, "0");
            }
            bn.MaBenhNhan = kq;
            t.Add(bn);
            gridcontrol1.DataSource = t.SelectAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            t.Delete(txtMabenhnhan.Text);
            gridcontrol1.DataSource = t.SelectAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            t.Update(GetBenhNhanForm());
            gridcontrol1.DataSource = t.SelectAll();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMabenhnhan.ResetText();
            txtHovaten.ResetText();
            dtNgaysinh.ResetText();
            txtSocmnd.ResetText();
            txtHotenthannhan.ResetText();
            txtSodienthoai.ResetText();
            txtSodtthannhan.Reset();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SetFormBenhNhan(GetGridView());
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}