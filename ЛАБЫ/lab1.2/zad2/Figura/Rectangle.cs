using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2.Figura
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetPloshad()
        {
            return Width * Height;
        }
    }
}
