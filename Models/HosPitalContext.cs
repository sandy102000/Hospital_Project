using Microsoft.EntityFrameworkCore;


namespace CareNet_System.Models
{
    public class HosPitalContext:DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Patient> Patients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // استخدام محول لتحويل النصوص إلى enum بشكل صحيح
            modelBuilder.Entity<Patient>()
                .Property(p => p.treatment)
                .HasConversion(
                    v => v.ToString(), // تحويل الـ enum إلى نص عند الحفظ
                    v => v == "Physical Therapy" ? TreatmentType.PhysicalTherapy : (TreatmentType)Enum.Parse(typeof(TreatmentType), v)); // تحويل النصوص إلى enum عند الاسترجاع
        }
        public DbSet<Bills> Bills { get; set; }
      

        public HosPitalContext() : base() { }
        public HosPitalContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False");

        }
    }
}
