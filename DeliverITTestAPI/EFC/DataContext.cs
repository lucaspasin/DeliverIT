using DeliverITTestAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DeliverITTestAPI.EFC
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Bill> Bills => Set<Bill>();
    }
}
