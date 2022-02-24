//LP4EL - Aula 02
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03
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
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    //declarando ações de acordo com a opção do usuário
                    case 1:
                        Console.WriteLine("Informações do Produto:" +
                                        "\nCodigo: " + produto.Codigo +
                                        "\nDescrição: " + produto.Descricao +
                                        "\nPreço: " + produto.Preco +
                                        "\nAtivo: " + produto.Ativo);
                        Console.WriteLine("\n\n\n");
                        break;

                    case 2:
                        Console.WriteLine("Atualizando Produto: ");

                        //lendo dados informados pelo usuário
                        Console.WriteLine("Informe o código do produto: ");
                        int codigo = int.Parse(Console.ReadLine());
                        produto.Codigo = codigo;

                        Console.WriteLine("Informe a descrição do produto: ");
                        string descricao = Console.ReadLine();
                        produto.Descricao = descricao;

                        Console.WriteLine("Informe o preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());
                        produto.Preco = preco;

                        Console.WriteLine("Informe se o produto está ativo: (s/n)");
                        string ativo_aux = Console.ReadLine();
                        bool ativo = false;
                        if ((ativo_aux == "s") || (ativo_aux == "S"))
                        {
                            ativo = true;
                        }
                        else if ((ativo_aux == "n") || (ativo_aux == "N"))
                        {
                            ativo = false;
                        }
                        produto.Ativo = ativo;
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
        public int codigo;
        public string descricao;
        public double preco;
        public bool ativo;

        //declarando construtor
        public Produto(int codigo, string descricao, double preco, bool ativo)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.ativo = ativo;
        }

        //declarando getters e setter com propriedade explícita
        public int Codigo
        {
            get { return codigo; }
            set { if ((value > 0) && (value < 100)) { codigo = value; } }
        }

        public string Descricao
        {
            get { return descricao; }
            set { if (!(value == null)) { descricao = value; } }
        }

        public double Preco
        {
            get { return preco; }
            set { if (value > 0) { preco = value; } }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; } 
        }
    }
}
