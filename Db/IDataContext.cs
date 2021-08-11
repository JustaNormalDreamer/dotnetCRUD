using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using techlink.Persons;


namespace techlink.Db
{
    public interface IDataContext
    {
        DbSet<Person> Persons {
            get;
            init;
        }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}