using Microsoft.EntityFrameworkCore;

namespace BullGre.Data
{
    public class AppDbBullGre : DbContext
    {
        public AppDbBullGre(DbContextOptions<AppDbBullGre> options)
            : base(options) { }

        public DbSet<Features.Fazenda.Model.FazendaModel> Fazenda { get; set; }

    }
}
