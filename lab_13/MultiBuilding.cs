using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    class MultiBuilding : Building
    {
        int floor;

        public MultiBuilding (string address, double length, double width, double height, int floor)
        :base(address,length, width, height)
        {
            this.floor = floor;
        }
        public string Print()
        {
           string rezult=base.Print();
            rezult += $"{floor}";
            return rezult;

        }
    }
   
}
