using Microsoft.EntityFrameworkCore;
using DateQuest.Models;

namespace DateQuest.Contexts
{
    public class HomeContext: DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get; set;}
    }
}