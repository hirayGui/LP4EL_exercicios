//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Inicio
    {
        static void Main(string[] args)
        {
            //variáveis que auxiliarão o programa
            int opcao = 1;
            string cor;
            //altura pode ser usada para o circulo, pois o raio é a altura do circulo
            double altura, comprimento;

            //iniciando objetos
            Retangulo ret = new Retangulo(0.0, 0.0, null);
            Circulo cic = new Circulo(0, null);

            //apresentando ações possíveis
            while (opcao > 0)
            {
                Console.WriteLine("Programa Calculadora de Área" +
                                "\n===============================" +
                                "\nEscolha uma forma:" +
                                "\n[1] Retângulo" +
                                "\n[2] Circulo" +
                                "\n[0] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe a altura do retângulo: ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a base do retângulo: ");
                        comprimento = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a cor do retângulo: ");
                        cor = Console.ReadLine();

                        Console.WriteLine("\n");
                        ret = new Retangulo(comprimento, altura, cor);
                        ret.CalcularArea();


                        break;

                    case 2:
                        Console.WriteLine("Informe o raio do circulo: ");
                        altura = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe a cor do circulo: ");
                        cor = Console.ReadLine();

                        cic = new Circulo(altura, cor);
                        cic.CalcularArea();
                        break;

                    case 0:
                        Console.WriteLine("===SAINDO==");
                        break;

                    //declarando ação para input inválido do usuário
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!\n");
                        break;
                }
            }
        }
    }
}
