using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistration.Core.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public string pKey { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public BaseEntity()
        {
            this.pKey = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
        }
    }
}
