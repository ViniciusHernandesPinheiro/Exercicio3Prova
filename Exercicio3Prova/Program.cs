using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RA: 6322036
            //Nome: Vinícius Hernandes Pinheiro

            Console.WriteLine("Exercicio 3");

            for (int vezes =0; vezes < 3; vezes++)
            {
                Console.WriteLine("\nFiguras geometricas e seus respectivos codigos ");
                Console.WriteLine("1 – Circulo");
                Console.WriteLine("2 – Trapézio");
                Console.WriteLine("3 – Losango");

                Console.Write("\nDigite o codigo de uma figura geometrica para calcular sua área: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo >= 1 && codigo <= 3)
                {
                    switch (codigo)
                    {
                        case 1:
                            Console.Write("\nInforme o valor do raio do circulo: ");
                            double raio = Convert.ToDouble(Console.ReadLine());

                            double areaCirculo = (3.14 * (raio * raio));
                            Console.WriteLine("Area do circulo: " + areaCirculo);
                            break;

                        case 2:
                            Console.Write("\nInforme o valor da base menor do trapezio: ");
                            double bmenor = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe o valor da base maior do trapezio: ");
                            double Bmaior = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe o valor da altura do trapezio: ");
                            double aTrapezio = Convert.ToDouble(Console.ReadLine());

                            double areaTrapezio = (((Bmaior + bmenor) * aTrapezio) / 2);
                            Console.WriteLine("Area do trapezio: " + areaTrapezio);
                            break;

                        case 3:
                            Console.Write("\nInforme o valor da diagonal menor do losango: ");
                            double dmenor = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe o valor da diagonal maior do losango: ");
                            double Dmaior = Convert.ToDouble(Console.ReadLine());

                            double areaLozango = ((Dmaior * dmenor) / 2);
                            Console.WriteLine("Area do lozango: " + areaLozango);
                            break;

                    }
                    Console.WriteLine("-------------------------------");
                }

                else
                {
                    Console.WriteLine("\nCódigo invalido ");
                }
            }
            
        }
    }
}
