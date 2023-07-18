using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Shape
    {
        public virtual int PerimeterOfARectangle (int side1,int side2)
        {
            return (side1 * side2)*2;
        }
    }
}
