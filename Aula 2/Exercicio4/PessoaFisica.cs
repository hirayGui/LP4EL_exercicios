//LP4EL - Aula 02
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    //os dois pontos demarca a classe PessoaFisica herdando os atributos da classe Cliente
    class PessoaFisica : Cliente
    {
        //declarando atributos
        private string nome, cpf;

        //criando construtor
        public PessoaFisica(string nome, string cpf, int codigo, string endereco, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.Codigo = codigo;
            this.Endereco = endereco;
            this.Telefone = telefone;

        }

        //declarando getters e setters
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }

}
