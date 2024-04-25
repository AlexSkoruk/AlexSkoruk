using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2.Figura
{
    public class Circle
    {
        public double Radius { get; set; }
        public double GetPloshad()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
