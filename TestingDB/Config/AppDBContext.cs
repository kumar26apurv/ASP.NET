
using Microsoft.EntityFrameworkCore;
namespace TestingDB.Config
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options):base(options)
        {

        }
    }
}
