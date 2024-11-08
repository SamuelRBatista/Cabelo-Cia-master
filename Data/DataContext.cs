using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyApp.Entities;
using MyApp.Models;

namespace MyApp.Context
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Aluno>Alunos { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<CategoryService> CategoryServices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(new Aluno
            {
                AlunoId = 1,
                Nome = "Samuel",
                Email = "samuka-srb@live.com",
                Idade = 23,
                Curso = "C#"
            });
        }
    }
}
