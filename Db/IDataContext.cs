using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using techlink.Persons;
using techlink.Posts;


namespace techlink.Db
{
    public interface IDataContext
    {
        DbSet<Person> Persons {
            get;
            init;
        }

        DbSet<Post> Posts
        {
            get;
            init;
        }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}