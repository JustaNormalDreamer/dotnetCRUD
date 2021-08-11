
using Microsoft.EntityFrameworkCore;

using techlink.Persons;

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
    }
}