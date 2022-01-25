using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Ярославль", 20, 15, 10);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Ярославль", 20, 15, 10, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
