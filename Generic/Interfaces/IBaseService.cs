using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace techlink.Generic.Interfaces
{
    public interface IBaseService<T, U>
    {
        Task<IEnumerable<T>> all();

        Task<T> show(U id);

        Task store(T post);

        Task update(U id, T post);

        Task delete(U id);
    }
}