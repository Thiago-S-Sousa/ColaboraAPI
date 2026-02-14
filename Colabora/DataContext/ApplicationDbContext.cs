using Colabora.Models;
using Microsoft.EntityFrameworkCore;

namespace Colabora.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
