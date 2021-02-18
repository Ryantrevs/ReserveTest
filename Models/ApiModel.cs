using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserverProject.Models
{
    public class ApiModel
    {
        public String ID { get; set; }
        public String Message { get; set; }
        public Global Global { get; set; }
        public List<Countries> Countries { get; set; }
    }
}
