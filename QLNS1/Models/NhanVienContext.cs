using Microsoft.EntityFrameworkCore;
using QLNS1.Models;

namespace QLNS1.Models
{
    public class NhanVienContext : DbContext
    {
        public NhanVienContext(DbContextOptions<NhanVienContext> options) : base(options)
        {
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>().ToTable("dbo.NhanVien");
        }
    }
}
