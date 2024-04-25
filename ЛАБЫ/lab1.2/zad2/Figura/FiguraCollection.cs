using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2.Figura
{
    public class FiguraCollection
    {
        private List<object> shapes;

        public FiguraCollection()
        {
            shapes = new List<object>();
        }

        public void AddShape(object shape)
        {
            shapes.Add(shape);
        }

        public double GetTotalArea()
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    totalArea += ((Circle)shape).GetPloshad();
                }
                else if (shape is Rectangle)
                {
                    totalArea += ((Rectangle)shape).GetPloshad();
                }
                else if (shape is Triangle)
                {
                    totalArea += ((Triangle)shape).GetPloshad();
                }
            }

            return totalArea;
        }
    }
}
