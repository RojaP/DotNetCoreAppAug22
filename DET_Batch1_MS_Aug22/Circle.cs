using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DET_Batch1_MS_Aug22
{
    public class Circle
    {
        float radius;
        const float PI = 22 / 7;
        public Circle()
        {
            radius = 0;
        }
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public float Area()
        {
            return 2*radius*PI;

        }
        public float Diameter()
        {
            return 2*radius;
        }
    }
}
