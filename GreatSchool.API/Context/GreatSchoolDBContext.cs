using Microsoft.EntityFrameworkCore;

namespace GreatSchool.API.Context
{
    public class GreatSchoolDBContext : DbContext
    {
        public virtual DbSet<Aluno> Aluno { get; set; }

        public GreatSchoolDBContext()
        {
        }

        public GreatSchoolDBContext(DbContextOptions<GreatSchoolDBContext> options) : base(options) 
        { 
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Name=GreatSchoolDB");
        //    }
        //}
    }
}
