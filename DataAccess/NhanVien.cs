using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public int MaChucDanh { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCMND { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public DateTime NgayNghiLam { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public NhanVien() { }
    }
}
