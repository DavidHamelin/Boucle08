using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boucle08
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] pairs = new int[] { 1, 2, 443, 4, 5, 6, 77, 8, 90, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                foreach (int pair in pairs)
                {
                    // utilisation du modulo pour sélectionner les nombres pouvant se diviser par 2
                    // le modulo "%" indique le reste d'une division
                    if (pair % 2 == 0)
                    {
                        Console.WriteLine(pair);
                    }
                }
            }
        }
    }
}
