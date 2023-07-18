using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Triangle1 : Shape
    {
        public virtual int GetPerimeter (int gverdi1, int gverdi2, int gverdi3)
        {
            return (gverdi1 + gverdi2 + gverdi3);
        }
    }
}
