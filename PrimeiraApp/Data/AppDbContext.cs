using Microsoft.EntityFrameworkCore;
using PrimeiraApp.Models;

namespace PrimeiraApp.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
