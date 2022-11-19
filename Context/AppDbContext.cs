using ApiProyecto1002.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiProyecto1002.Context
{
    public class AppDbContext: DbContext
    {

        private AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<usuarios> usuarios { get;set }

    }

}
