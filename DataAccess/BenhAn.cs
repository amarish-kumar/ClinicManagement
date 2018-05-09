using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BenhAn
    {
        public string MaBenhAn { get; set; }
        public DateTime NgayKham { get; set; }
        public string TrieuChung { get; set; }
        public string KetLuan { get; set; }
        public DateTime NgayTaiKham { get; set; }
        public string MaNhanVien { get; set; }
        public string ManBenhNhan { get; set; }
        public BenhAn() { }
    }
}
