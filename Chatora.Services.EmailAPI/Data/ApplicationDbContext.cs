using Chatora.Services.EmailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Chatora.Services.EmailAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        
        // To create table in Database
        public DbSet<EmailLogger> EmailLoggers { get; set; }


    }
}
