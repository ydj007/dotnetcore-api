using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) :base(opt)
        {

        }
        
        // Command 객체를 DBset으로 선언. DB에서 받을 수 있도록 한다. 아마도...
        // EF에선 객체와 DB 간 관계를 이런 식으로 선언해야 한다. 
        public DbSet<Command> Commands { get; set; }
    }
}