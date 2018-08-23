
using EFCodeFirstSample.Model;
using System.Data.Entity;

namespace EFCodeFirstSample.DataContext
{
    public class LivrariaDbContext : DbContext
    {
        public LivrariaDbContext() : base("LivrariaDbContext")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Database.SetInitializer(new LivrariaDbContextInitilizer());
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().ToTable("autor");
            modelBuilder.Entity<Livro>().ToTable("livros");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            base.OnModelCreating(modelBuilder);
        }


    }

    public class LivrariaDbContextInitilizer : DropCreateDatabaseAlways<LivrariaDbContext>
    {
        
    }
}
