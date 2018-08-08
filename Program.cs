using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosEnAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 999;
            AugmentingDigitsCalculator calculator=new AugmentingDigitsCalculator(start,finish);
            Console.WriteLine(String.Format("Cantidad de Numeros en aumento entre {0} y {1}: {2}",start,finish,calculator.Calculate()));
            Console.ReadKey();
        }
    }
}
