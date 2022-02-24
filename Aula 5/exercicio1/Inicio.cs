//LP4EL - Aula 05
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Inicio
    {
        static void Main(string[] args)
        {
            //iniciando lista e objeto cliente
            List<Cliente> lista_clientes = new List<Cliente>();
            Cliente cliente = new Cliente(0, null, null);

            int opcao = 1, codigo = 0, aut_codigo = 0;
            string nome, cpf;

            while(opcao > 0)
            {
                Console.WriteLine("Programa gerenciador de clientes" +
                                "\n================================" +
                                "\n" +
                                "\nEscolha uma ação:" +
                                "\n[1] Inserir cliente" +
                                "\n[2] Alterar cliente" +
                                "\n[3] Excluir cliente" +
                                "\n[4] Consultar clientes" +
                                "\n[0] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastrando novo cliente" +
                                        "\n------------------------");

                        Console.WriteLine("Informe o nome do cliente: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Informe o CPF do cliente: ");
                        cpf = Console.ReadLine();

                        //código se autoincrementa
                        aut_codigo++;

                        cliente = new Cliente(aut_codigo, nome, cpf);

                        lista_clientes.Add(cliente);
                        Console.Clear();
                        //linha de código para testar atribuição dos valores
                        //Console.WriteLine(cliente.GetCodigo() + "\n" + cliente.GetNome() + "\n" + cliente.GetCpf());
                        break;

                    case 2:
                        Console.WriteLine("Alterando dados de cliente" +
                                        "\n--------------------------" +
                                        "\nInsira '0' para sair ou" +
                                        "\nInsira o código do cliente:");
                        codigo = int.Parse(Console.ReadLine());
                        if (codigo == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Informe o nome do cliente: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Informe o CPF do cliente: ");
                            cpf = Console.ReadLine();

                            cliente = new Cliente(codigo, nome, cpf);

                            lista_clientes.RemoveAt(codigo);
                            lista_clientes.Insert(codigo, cliente);
                        }
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Removendo cliente da lista" +
                                        "\n--------------------------" +
                                        "\nInsira '0' para sair ou" +
                                        "\nInforme o código do cliente: ");
                        codigo = int.Parse(Console.ReadLine());
                        if (codigo == 0)
                        {
                            break;
                        }
                        else 
                        {
                            //checando se código informado existe
                            foreach(Cliente c in lista_clientes)
                            {
                                if (codigo == c.GetCodigo())
                                    lista_clientes.RemoveAt(codigo);
                            }
                            
                        }
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Apresentando lista de clientes" +
                                        "\n------------------------------");
                        foreach(Cliente c in lista_clientes)
                        {
                            if (c != null)
                            {
                                Console.WriteLine("Código: " + c.GetCodigo() +
                                                "\nNome: " + c.GetNome() +
                                                "\nCPF: " + c.GetCpf() + "\n");
                            }
                        }

                        Console.WriteLine("\n");
                        break;

                    case 0:
                        Console.WriteLine("===SAINDO===");
                        break;

                    //declarando ação para opção inválida
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
