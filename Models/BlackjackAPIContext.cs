using Microsoft.EntityFrameworkCore;
using System;

namespace BlackjackAPI.Models
{
  public class BlackjackAPIContext : DbContext
  {
    public BlackjackAPIContext(DbContextOptions<BlackjackAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Dealer> Dealers { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseLazyLoadingProxies();
    // }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dealer>()
      .HasData(
        new Dealer 
        { 
          DealerId=1, 
          Name="Tumbleweed Terrence", 
          PlayStyle=4, 
          Description="Just a drifter, rolling wherever the wind takes him"
        },
        new Dealer 
        { 
          DealerId= 2, 
          Name= "Randall the Ruthless", 
          PlayStyle= 3, 
          Description="A ruthless rapscallion, chive-talker, onion hip-hop enthusiast" 
        },
        new Dealer 
        { 
          DealerId= 3, 
          Name= "Kissin' Kate Barlow", 
          PlayStyle= 5, 
          Description="A poker hand as deadly as her six-shooter"
        }
      );
    }
  }
}