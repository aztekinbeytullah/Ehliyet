using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class MyDbContext:IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ev = "server=DESKTOP-F009EHO; database=mtskdbdb;integrated security=true;";
            string uzak = "workstation id=mtskdbdb.mssql.somee.com;packet size=4096;user id=OgretmenX_SQLLogin_1;pwd=2ce7csxt6x;data source=mtskdbdb.mssql.somee.com;persist security info=False;initial catalog=mtskdbdb";
            string laptop = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mtskdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(laptop);
            base.OnConfiguring(optionsBuilder);
           
        }
      
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Question>? Questions { get; set; }
        public DbSet<Exercise>? Exercises { get; set; }
        public DbSet<ExerciseQuestion>? ExerciseQuestions { get; set; }


    }
}
