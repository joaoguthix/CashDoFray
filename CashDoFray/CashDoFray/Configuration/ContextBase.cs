using CashDoFray.Model;
using Microsoft.EntityFrameworkCore;

namespace CashDoFray.Configuration
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Message> Messages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string ObterStringConexao()
        {
            return "Data Source=DSPC\\SQLEXPRESS;Initial Catalog=CashDoFray;Integrated Security=True";
        }
    }
}