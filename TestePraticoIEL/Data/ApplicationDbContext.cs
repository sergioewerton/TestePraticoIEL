using CadastroIEL.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroIEL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Isso diz ao EF Core para criar uma tabela chamada "Estudantes"
        // baseada no seu modelo "Estudante"
        public DbSet<Estudante> Estudantes { get; set; }
    }
}
