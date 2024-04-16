using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos{ get; set;}
    }
}