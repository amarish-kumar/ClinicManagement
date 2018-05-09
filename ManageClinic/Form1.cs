using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManageClinic
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuanlybenhnhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form[] ds = this.MdiChildren;
            foreach (Form item in ds)
            {
                item.Close();
            }
            FormBenhNhan frm = new FormBenhNhan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanlyhosokhambenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form[] ds = this.MdiChildren;
            foreach (Form item in ds)
            {
                item.Close();
            }
            FormQuanLyHoso frm = new FormQuanLyHoso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTKTKBenhnhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnQuanlynhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form[] ds = this.MdiChildren;
            foreach (Form item in ds)
            {
                item.Close();
            }
            FormNhanVien frm = new FormNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
