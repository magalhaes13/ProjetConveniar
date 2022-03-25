namespace WebApplication1.Models
{
    public class DbContext
    {
        private DbContextOptions<Contexto> options;

        public DbContext(DbContextOptions<Contexto> options)
        {
            this.options = options;
        }
    }
}