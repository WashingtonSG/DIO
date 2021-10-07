using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context :DbContext
    {
        private static string _connStr = @"
            Server=127.0.0.1,1433;
            Database=Cursomvc;
            User Id=SA;
            Password=7532147Io.ri5";

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(_connStr);
        }
    }
}