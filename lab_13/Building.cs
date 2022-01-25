using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    class Building
    {
        string address;
        double length;
        double width;
        double height;

        double Length
        {
            get { return Length; }
            set
            {
                if (value < 0)
                { length = 0; }
                else { length = value; }
            }
        }
        public Building(string address, double length, double width, double height)
        {
            this.address = address;
            this.Length = length;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $"{address} {length} {width} {height}";
            
        }
    }
}
