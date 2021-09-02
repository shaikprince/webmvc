using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webMvc.Models
{
    public class Rolemodel
    {
        public int Role { get; set; }



        [required]
        public string Name { get; set; }
    }
}