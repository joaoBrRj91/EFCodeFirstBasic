
using EFCodeFirstSample.Model;
using System.Data.Entity;

namespace EFCodeFirstSample.DataContext
{
    public class LivrariaDbContext : DbContext
    {
        public LivrariaDbContext() : base("LivrariaDbContext")
        {
            Database.SetInitializer(new LivrariaDbContextInitilizer());
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }

    public class LivrariaDbContextInitilizer : DropCreateDatabaseAlways<LivrariaDbContext>
    {
        
    }
}
