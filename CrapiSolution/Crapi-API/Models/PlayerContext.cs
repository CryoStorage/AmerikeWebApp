using Microsoft.EntityFrameworkCore;
using Crapi_API.Models;

namespace TodoApi.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }
    
    }
}
