using Microsoft.EntityFrameworkCore;

namespace TesteFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Bimestre> Bimestre { get; set; }

    }
}
