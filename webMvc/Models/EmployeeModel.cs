using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webMvc.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [required]
        public string FirstName { get; set; }
        [required]
        public string LastName{ get; set; }
        [required]
       
        public DateTime DOB { get; set; }
        public long Contact { get; set; }
        public int RoleId { get; set; }

    }
    internal class requiredAttribute : Attribute
    {

    }
}

