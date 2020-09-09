using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio 9
            List<int> t = Enumerable.Range(1, 50).ToList();
            var pares = t.Where(num => num % 2 == 0);
            foreach (int i in pares)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
