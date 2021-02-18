using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserverProject.Models
{
    public class CountryViewModel
    {
        public int ActiveCases { get; set; }
        public String Name { get; set; }

        public CountryViewModel(int activeCases, string name)
        {
            ActiveCases = activeCases;
            Name = name;
        }
    }
}
