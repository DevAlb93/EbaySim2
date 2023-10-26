using EbaySim.Domain;
using Microsoft.EntityFrameworkCore;

namespace EbaySim.Persistent
{
    public class EbaySimContext : DbContext
    {
        public EbaySimContext(DbContextOptions<EbaySimContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}
