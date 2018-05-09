using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class GiaThuoc
    {
        public int MaGiaThuoc { get; set; }
        public int MaThuoc { get; set; }
        public float GiaNhap { get; set; }
        public float GiaXuat { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public GiaThuoc() { }
    }
}
