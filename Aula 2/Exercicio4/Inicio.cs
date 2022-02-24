//LP4EL - Aula 02
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    class Inicio
    {        
        static void Main(string[] args)
        {
            //criando vetores para os tipos de pessoa
            PessoaFisica[] pessoasFisicas = new PessoaFisica[10];
            PessoaJuridica[] pessoasJuridicas = new PessoaJuridica[10];

            //criando os objetos de pessoa
            PessoaFisica pessoaFisica = new PessoaFisica(null, null, 0, null, null);
            PessoaJuridica pessoaJuridica = new PessoaJuridica(null, null, 0, null, null);

            //declarando variaveis a serem utilizadas
            int opcao = 1, pfCont = 0, pjCont = 0;

            while (opcao > 0)
            {
                Console.WriteLine("Programa Gerenciador de Cliente" +
                            "\n===============================" +
                            "\nEscolha uma opção:" +
                            "\n[1] Cadastrar Cliente" +
                            "\n[2] Consultar Clientes" +
                            "\n[0] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n\nEscolha o tipo de cliente que vai ser cadastrado: " +
                                        "\n[1] Pessoa Física" +
                                        "\n[2] Pessoa Jurídica");
                        opcao = int.Parse(Console.ReadLine());

                        //criando switch para detalhar cadastro dos tipos de cliente
                        switch (opcao)
                        {
                            case 1:
                                if(pfCont < pessoasFisicas.Length)
                                {
                                    Console.WriteLine("Informe o nome do cliente: ");
                                    string nome = Console.ReadLine();
                                   //pessoaFisica.Nome = nome;

                                    Console.WriteLine("Informe o CPF do cliente: ");
                                    string cpf = Console.ReadLine();
                                    //pessoaFisica.Cpf = cpf;

                                    Console.WriteLine("Informe o código do cliente: ");
                                    int codigo = int.Parse(Console.ReadLine());
                                   // pessoaFisica.Codigo = codigo;

                                    Console.WriteLine("Informe o endereço do cliente: ");
                                    string endereco = Console.ReadLine();
                                    //pessoaFisica.Endereco = endereco;

                                    Console.WriteLine("Informe o telefone do cliente: ");
                                    string telefone = Console.ReadLine();
                                    //pessoaFisica.Telefone = telefone;

                                    pessoasFisicas[pfCont] = new PessoaFisica(nome, cpf, codigo, endereco, telefone);
                                    pfCont++;
                                    //utilizando pfCont para contar cadastros e contar sua quantidade
                                    Console.WriteLine("Cliente cadastrado com sucesso!!\n\n");
                                } else if(pfCont == pessoasFisicas.Length)
                                {
                                    Console.WriteLine("Número máximo de clientes cadastrados alcançado!\n");
                                }
                                break;

                            case 2:
                                if (pfCont < pessoasJuridicas.Length)
                                {
                                    Console.WriteLine("Informe a razão social do cliente: ");
                                    string razaoSocial = Console.ReadLine();
                                    pessoaJuridica.RazaoSocial = razaoSocial;

                                    Console.WriteLine("Informe o CNPJ do cliente: ");
                                    string cnpj = Console.ReadLine();
                                    pessoaJuridica.Cnpj = cnpj;

                                    Console.WriteLine("Informe o código do cliente: ");
                                    int codigo = int.Parse(Console.ReadLine());
                                    pessoaJuridica.Codigo = codigo;

                                    Console.WriteLine("Informe o endereço do cliente: ");
                                    string endereco = Console.ReadLine();
                                    pessoaJuridica.Endereco = endereco;

                                    Console.WriteLine("Informe o telefone do cliente: ");
                                    string telefone = Console.ReadLine();
                                    pessoaJuridica.Telefone = telefone;

                                    pessoasJuridicas[pjCont] = pessoaJuridica;
                                    pjCont++;
                                    //utilizando pjCont para contar cadastros e contar sua quantidade
                                    Console.WriteLine("Cliente cadastrado com sucesso!!\n\n");
                                }
                                else if (pfCont == pessoasJuridicas.Length)
                                {
                                    Console.WriteLine("Número máximo de clientes cadastrados alcançado!\n");
                                }
                                break;

                            default:
                                Console.Write("OPÇÃO INVÁLIDA!\nCLIENTE NÃO CADASTRADO!\n\n");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("---Apresentando clientes---");

                        
                        Console.WriteLine("Clientes tipo PESSOA FÍSICA: \n");
                        PrintValues(pessoasFisicas);

                        
                        Console.WriteLine("\nClientes tipo PESSOA JURÍDICA: \n");
                        PrintValues(pessoasJuridicas);
                        break;

                    //comando para não dar continuidade na aplicação
                    case 0:
                        Console.WriteLine("===Saindo===");
                        break;

                    //comando para invalidar opções que não estão na lista
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA\n\n");
                        break;
                }
            }
            Console.ReadKey();
        }

        //criando método para imprimir pessaos fisicas
        public static void PrintValues(PessoaFisica[] pessoasFisicas)
        {
            foreach(PessoaFisica pf in pessoasFisicas)
            {
                if (pf != null)
                {
                    Console.WriteLine("Nome: " + pf.Nome +
                                            "\nCPF: " + pf.Cpf +
                                            "\nCodigo: " + pf.Codigo +
                                            "\nEndereço: " + pf.Endereco +
                                            "\nTelefone: " + pf.Telefone);
                }
            }
        }

        //criando método para imprimir pessaos juridicas
        public static void PrintValues(PessoaJuridica[] pessoasJuridicas)
        {
            foreach (PessoaJuridica pj in pessoasJuridicas)
            {
                if (pj != null)
                {
                    Console.WriteLine("Razão Social: " + pj.RazaoSocial +
                                            "\nCNPJ: " + pj.Cnpj +
                                            "\nCodigo: " + pj.Codigo +
                                            "\nEndereço: " + pj.Endereco +
                                            "\nTelefone: " + pj.Telefone);
                }
            }
        }
    }
}
