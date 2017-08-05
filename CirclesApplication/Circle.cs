using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesApplication
{
    class Circle
    {
        int radius;
        float area; 

        /// <summary> 
        /// Constructor 
        /// </summary> 
        /// <param name="radius">the radius of the circle</param> 
        public Circle(int radius)
        {
            this.radius = radius;
            area = (float)(Math.PI * Math.Pow(radius, 2));
        } 

        /// <summary> 
        /// Gets the radius of the circle 
        /// </summary> 
        /// 
        public int Radius
        {
            get { return radius; }
        } 

        /// <summary> 
        /// Gets the area of the circle 
        /// </summary> 
        public double Area
        {
            get
            {
                return area;
            }
        }
    }
}
