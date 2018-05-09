using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BenhNhan
    {
        public string MaBenhNhan { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string TenNguoiThan { get; set; }
        public string SDTThanNhan { get; set; }
        public string SDTBenhNhan { get; set; }
        public BenhNhan()
        {

        }
        public BenhNhan(string mbn, string ht, DateTime ns,string cmnd,string tnt,string sdttn,string sdtbn)
        {
            this.MaBenhNhan = mbn;
            this.HoVaTen = ht;
            this.NgaySinh = ns;
            this.CMND = cmnd;
            this.TenNguoiThan = tnt;
            this.SDTThanNhan = sdttn;
            this.SDTBenhNhan = sdtbn;
        }
    }
}
