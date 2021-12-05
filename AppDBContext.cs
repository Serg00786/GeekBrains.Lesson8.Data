using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace GeekBrains.Lesson8.Data
{

    public class StudentsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public StudentsContext()
        {

        }

        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {

        }
        public DbSet<ListOfStudent> ListOfStudent{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Students;User ID=SA;Password=1qaz!QAZ;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }


}
