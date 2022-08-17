using Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Data
{
    public class AppCad : DbContext
    {
        public AppCad(DbContextOptions<AppCad> options) : base(options) 
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
