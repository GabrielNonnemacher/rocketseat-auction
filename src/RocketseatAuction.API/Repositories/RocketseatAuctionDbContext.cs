using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories;

public class RocketseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=J:\\Github-Pessoal\\C#\\RocketSeat\\rocketseat-auction\\src\\RocketseatAuction.API\\DataBase\\leilaoDbNLW.db");
    }
}
