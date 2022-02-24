//LP4EL - Aula 04
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            //criando objeto de Produto
            Produto produto = new Produto(0, null, 0, false);

            int opcao = 1;
            while (opcao > 0)
            {
                Console.WriteLine("Programa Gerenciador de Produto" +
                                "\n===============================" +
                                "\nEscolha uma opção:" + 
                                "\n[1] Consutar Produto" +
                                "\n[2] Atualizar dados de Produto" +
                                "\n[0] Sair");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                //exceção para formato inválido de opção
                catch(FormatException e)
                {
                    Console.WriteLine("Erro encontrado: " + e.Message);
                }
                finally
                {
                    //atribuindo valor para opção inválida para que o programa não execute alguma ação indesejada
                    opcao = 3;
                }
                Console.Clear();

                switch (opcao)
                {
                    //declarando ações de acordo com a opção do usuário
                    case 1:
                        try
                        {
                            Console.WriteLine("Informações do Produto:" +
                                            "\nCodigo: " + produto.GetCodigo() +
                                            "\nDescrição: " + produto.GetDescricao() +
                                            "\nPreço: " + produto.GetPreco() +
                                            "\nAtivo: " + produto.GetAtivo());
                            Console.WriteLine("\n\n\n");
                        }
                        //exceção para o objeto não estar vazio
                        catch (NullReferenceException e) 
                        {
                            Console.WriteLine("Erro encontrado: " + e.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Atualizando Produto: ");

                        try
                        {
                            //lendo dados informados pelo usuário
                            Console.WriteLine("Informe o código do produto: ");
                            int codigo = int.Parse(Console.ReadLine());
                            produto.SetCodigo(codigo);

                            Console.WriteLine("Informe a descrição do produto: ");
                            string descricao = Console.ReadLine();
                            produto.SetDescricao(descricao);

                            Console.WriteLine("Informe o preço do produto: ");
                            double preco = double.Parse(Console.ReadLine());
                            produto.SetPreco(preco);

                            Console.WriteLine("Informe se o produto está ativo: (s/n)");
                            string ativo_aux = Console.ReadLine();
                            bool ativo = false;
                            if((ativo_aux == "s") || (ativo_aux == "S"))
                            {
                                ativo = true;
                            }
                            else if ((ativo_aux == "n") || (ativo_aux == "N"))
                            {
                                ativo = false;
                            } 
                            produto.SetAtivo(ativo);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Erro encontrado: " + e.Message);
                        }
                        Console.Clear();
                        break;

                    case 0:
                        Console.WriteLine("===SAINDO===");
                        break;

                    default:
                        Console.WriteLine("\nOPÇÃO INVÁLIDA!\n\n");
                        break;
                }
            } 
            Console.ReadKey();
        }
    }

    //declarando classe Produto
    class Produto
    {
        //declarando atributos
        private int codigo;
        private string descricao;
        private double preco;
        private bool ativo;

        //declarando construtor
        public Produto(int codigo, string descricao, double preco, bool ativo)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.ativo = ativo;
        }

        //declarando getters e setters
        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public bool GetAtivo()
        {
            return ativo;
        }

        public void SetAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}
