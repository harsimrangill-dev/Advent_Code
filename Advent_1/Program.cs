using Microsoft.VisualBasic;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Advent_code
{
    class codes
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            obj.maxVal();

            int[] calories = new int[obj.getLength()];

            calories = obj.intarray();

            Array.Sort(calories);

            int  total;

            total = calories[obj.getLength() - 1] + calories[obj.getLength() - 2] + calories[obj.getLength() - 3];
            
            Console.WriteLine(total);


            

        }
    }
}