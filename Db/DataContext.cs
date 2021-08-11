
using Microsoft.EntityFrameworkCore;

using techlink.Persons;
using techlink.Posts;

namespace techlink.Db
{
    public class DataContext :DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }

        public DbSet<Person> Persons 
        {
            get;
            init;
        }

        public DbSet<Post> Posts
        {
            get;
            init;
        }
    }
}