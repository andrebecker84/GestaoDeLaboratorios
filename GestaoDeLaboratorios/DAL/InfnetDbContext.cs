using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions options) : base(options)
        {
         
        }
        public DbSet<Computadores> Computadores { get; set; }
    }
}