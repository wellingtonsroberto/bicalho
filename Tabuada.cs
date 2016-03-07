using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] vetor = new int[10, 2]; 
            Console.WriteLine("Digite o numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {

                vetor[i, 0] = i + 1;
                vetor[i, 1] = num;

            }

            for (int y = 0; y < 10; y++)
                Console.WriteLine("{0} X {1} = {2}", vetor[y, 0], vetor[y, 1], (vetor[y, 0] * vetor[y, 1]));

            Console.ReadKey();

        
        
        }
    }
}
