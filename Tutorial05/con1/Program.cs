using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace con1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string[] pole1 = {"Anicka","Petr", "Janek" };
            List<string> pole2= new List<string>();
            string text1= "ahoj,jak se mas,ja se mam dobre";
            string[] pole3 = text1.Split(',');
            int i = -1;
            while (i < pole3.Length -1)
            {
                i++;
                Console.WriteLine(pole3[i]);
            }

            Console.ReadKey();
        }
    }
}
