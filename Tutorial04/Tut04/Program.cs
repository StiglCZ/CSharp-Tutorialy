using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut04
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int i2 = 0;
			while(i2 < 10)
			{
			
Console.WriteLine(i2);
i2++;			
			}
			
            //cyklus, stane se to 10krat
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
