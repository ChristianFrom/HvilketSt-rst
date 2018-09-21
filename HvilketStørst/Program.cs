using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvilketStørst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv to tal, så vil jeg fortælle, hvilket et er størst");
            Console.WriteLine("Det første tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Det andet tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            sammenlign(tal1, tal2);

    
            Console.ReadKey();
        }

        private static void sammenlign(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                Console.WriteLine("Det første tal er størst!");               
            }

            if (tal1 < tal2)
            {
                Console.WriteLine("Det andet tal er størst!");               
            }

            if (tal1 == tal2)
            {
                Console.WriteLine("De er lige store!");               
            }
        }
    }
}
