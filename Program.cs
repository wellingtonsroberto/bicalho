using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] vetor1 = new int [5,3];  
            
            for (int i = 0; i < 5; i++)

              {
                    
             for (int j = 0; j < 3; j++)
			                      
              {
			 
			  Console.WriteLine ("Informe o valor para linha {0} coluna {1}" , i + 1,j +1);
                 vetor1[i,j] = Convert.ToInt32(Console.ReadLine());

                   }     
                }
               
            Console.WriteLine("Precione qualquer tecla para mostrar os valores....");
            Console.ReadKey();

            for (int i = 0; i < 5; i++)

              {
                    
             for (int j = 0; j < 3; j++)
			                      
              {
			 
			  Console.WriteLine ("O valor da linha {0} coluna {1}" , i + 1,j + 1);
              Console.WriteLine("{0}", vetor1[i, j]);
                 

                   }     
                }

                 Console.WriteLine("Precione qualquer tecla para sair !");
                 Console.ReadKey();
               
        
        }
    }
}

