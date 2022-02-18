using System;
namespace Frequencia_de_numeros.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos valores será a lista de números");
             int qtnumero = System.Convert.ToInt32(Console.ReadLine());
             int numeroanterior=0;

            int [] numeros = new int[qtnumero];
            int[] contador = new int[qtnumero];        

            for (int i=0; i<numeros.Length;i++) {
                Console.WriteLine("Digite os valor na posição  " + i);
                 numeros[i] = System.Convert.ToInt32(Console.ReadLine());

                if (numeros[i] == 0)
                {
                    numeroanterior = numeros[i];
                }
                else if (i > 0)

                    if (numeros[i] == numeroanterior)
                    {
                        numeroanterior = numeros[i];
                        contador[i]++;
                    }
               
            }





            //Mostrar a lista
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i] + " aparece " + contador[i] + " vez(es)");
            }
		}
    }
}
