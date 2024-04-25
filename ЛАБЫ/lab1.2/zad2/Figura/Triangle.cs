using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2.Figura
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetPloshad()
        {
            return (Base * Height) / 2;
        }
    }
}
