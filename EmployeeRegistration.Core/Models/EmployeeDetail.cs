using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistration.Core.Models
{
    public class EmployeeDetail : BaseEntity
    {
        [StringLength(15)]
        public string FirstName { get; set; }
        [StringLength(15)]
        public string LastName { get; set; }
        public string EmailID { get; set; }
        [Range(0,99999999)]
        public int EmployeeID { get; set; }
        public string EmployeeLocation { get; set; }
        public string Image { get; set; }
    }
}
