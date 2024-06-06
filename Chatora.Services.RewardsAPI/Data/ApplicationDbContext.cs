using Chatora.Services.RewardsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Chatora.Services.RewardsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        
        // To create table in Database
        public DbSet<Rewards> Rewards { get; set; }


    }
}
