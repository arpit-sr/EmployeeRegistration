using EmployeeRegistration.Core.Contracts;
using EmployeeRegistration.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistration.SQL
{
    public class SQLRepository<T> : ISQLRepository<T> where T : BaseEntity
    {

        public SQLRepository()
        {
            
        }
        //public IQueryable<T> Collection()
        //{
            
        //}

        public void Commit()
        {
            
        }

        public void Delete(string Id)
        {
           
        }

        //public T Find(string Id)
        //{
           
        //}

        public void Insert(T t)
        {
           
        }

        public void Update(T t)
        {
           
        }
    }
}
