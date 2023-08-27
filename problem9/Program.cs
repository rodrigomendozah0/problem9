using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mayor, medio, menor;
            Console.WriteLine("PROGRAMA PARA HALLAR EL MAYOR VALOR NUMERICO");
            Console.WriteLine("********************************************");
            Console.WriteLine("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    mayor = num1;
                    if (num2 > num3)
                    {
                        medio = num2;
                        menor = num3;
                    }
                    else
                    {
                        medio = num3;
                        menor = num2;
                    }
                }
                else
                {
                    mayor = num3;
                    medio = num1;
                    menor = num2;
                }
            }
            else
            {
                if (num2 > num3)
                {
                    mayor = num2;
                    if (num1 > num3)
                    {
                        medio = num1;
                        menor = num3;
                    }
                    else
                    {
                        medio = num3;
                        menor = num1;
                    }
                }
                else
                {
                    mayor = num3;
                    medio = num2;
                    menor = num1;
                }
            }
            Console.WriteLine("El número con mayor valor es: " + mayor);
            Console.ReadKey();
        }
    }
}
