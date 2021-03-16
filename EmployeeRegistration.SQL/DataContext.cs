using EmployeeRegistration.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistration.SQL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        DbSet<EmployeeDetail> EmpDetails { get; set; }
    }
}
