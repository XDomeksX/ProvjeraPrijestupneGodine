using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraPrijestupneGodine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i <= 2100; i++)
            {
                do
                {
                    i++;
                    if (i % 4 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                } while (i <= 2100);
            }
            Console.ReadKey();
        }
    }
}
