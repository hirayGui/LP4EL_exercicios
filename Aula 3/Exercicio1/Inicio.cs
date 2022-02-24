//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Inicio
    {
        static void Main(string[] args)
        {
            //variáveis que auxiliarão o programa
            int opcao = 1;
            string texto;

            //iniciando objetos
            Pesquisa pesq = new Pesquisa(null);
            PesquisaFim pesqF = new PesquisaFim(pesq.GetTexto());
            PesquisaInicio pesqI = new PesquisaInicio(pesq.GetTexto());

            //apresentando ações possíveis
            while (opcao > 0)
            {
                Console.WriteLine("Programa Analisador de Texto" +
                                "\n===============================" +
                                "\nEscolha uma opção:" +
                                "\n[1] Informar texto" +
                                "\n[2] Buscar string" +
                                "\n[3] Buscar string no inicio" +
                                "\n[4] Buscar string no fim" +
                                "\n[0] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        //recebendo texto do usuário
                        Console.WriteLine("Insira o texto a ser analisado: ");
                        texto = Console.ReadLine();

                        //sobrescrevendo objetos
                        pesq = new Pesquisa(texto);
                        //utilização de GetTexto de Pesquisa para ter certeza que o texto irá ser o mesmo para todos
                        pesqI = new PesquisaInicio(pesq.GetTexto());
                        pesqF = new PesquisaFim(pesq.GetTexto());
                        break;

                    case 2:
                        //usuário informa cadeia de caracteres a ser procurada no texto
                        Console.WriteLine("Insira o termo a ser procurado no texto: ");
                        texto = Console.ReadLine();

                        //chamando método da classe mãe
                        pesq.BuscarTexto(texto);
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        //usuário informa cadeia de caracteres a ser procurada no inicio do texto
                        Console.WriteLine("Insira o termo a ser procurado no inicio do texto: ");
                        texto = Console.ReadLine();

                        //chamando método da classe filha, PesquisaInicio
                        pesqI.BuscarTexto(texto);
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        //usuário informa cadeia de caracteres a ser procurada no final do texto
                        Console.WriteLine("Insira o termo a ser procurado no final do texto: ");
                        texto = Console.ReadLine();

                        //chamando método da classe filha, PesquisaFim
                        pesqF.BuscarTexto(texto);
                        Console.WriteLine("\n");
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
            Console.ReadKey();
        }
    }
}
