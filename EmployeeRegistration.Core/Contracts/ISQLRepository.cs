using EmployeeRegistration.Core.Models;
using System.Linq;

namespace EmployeeRegistration.Core.Contracts
{
    public interface ISQLRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}