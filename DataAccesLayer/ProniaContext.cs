using Microsoft.EntityFrameworkCore;
using WebApplicationPronia.Models;

namespace WebApplicationPronia.DataAccesLayer
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
         //   options.UseSqlServer("Server=sql8010.site4now.net;Database=ProniaNew;User Id=db_aa860b_azer_admin;Password=whcy1583;Trusted_Connection=True;");
              options.UseSqlServer("Server=sql8010.site4now.net;Database=db_aa860b_azer;User Id=db_aa860b_azer_admin;Password=whcy1583;"); 
            base.OnConfiguring(options);
        }
    }
}
