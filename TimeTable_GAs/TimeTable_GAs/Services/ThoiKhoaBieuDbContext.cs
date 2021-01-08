using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable_GAs.Model;

namespace TimeTable_GAs.Services
{
    public partial class ThoiKhoaBieuDbContext: DbContext
    {
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<ThoiGian> ThoiGians { get; set; }
        public DbSet<BaiGiang> BaiGiangs { get; set; }
       
    }
}
