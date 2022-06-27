using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejejrcicio1_Github
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("##### Bienvenido!! ######");
            Console.WriteLine("");
            Console.WriteLine("Por favor, ingrese un numero: ");
            List<int> numeros = new List<int>();
            var num = Convert.ToInt32(Console.ReadLine());
            var flag = true;
            while(flag == true)
            {
                numeros.Add(num);
                
                Console.WriteLine("Desea agregar otro numero? Si(s) / No(n)");
                var usuario = Console.ReadLine();
                if (usuario == "s")
                {
                    flag = true;
                }
                else if(usuario == "n")
                {
                    flag = false;
                    break;
                }
                Console.WriteLine("Por favor, ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            var contador = numeros.Count();
            var suma = numeros.Sum();
            decimal prom = suma / contador;
            var Max = numeros.Max();
            var Min = numeros.Min();
            Console.WriteLine("La suma es {0}", suma);
            Console.WriteLine("El promedio es {0}", prom);
            Console.WriteLine("El valor maximo es: {0} y el valor minimo es: {1}", Max, Min);

            Console.ReadKey();
        }
    }
}
