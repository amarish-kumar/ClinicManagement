using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GiaDichVu
    {
        public int MaGiaDichVu { get; set; }
        public int MaDichVu { get; set; }
        public float GiaTienDichVu { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public GiaDichVu() { }
    }
}
