using eTicketBookings.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eTicketBookings.Data
{
    public interface IEntityRepository<T> where T:class,IEntityBase,new()
    {
        Task<IEnumerable<T>> getAllAsync();
        Task<IEnumerable<T>> getAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> getByIdAsync(int id);
        Task addAsync(T Entity);
        Task UpdateAsync(int id, T Entity);
        Task deleteAsync(int id);
    }
}
