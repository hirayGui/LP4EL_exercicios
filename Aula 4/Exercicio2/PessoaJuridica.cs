//LP4EL - Aula 04
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    //os dois pontos demarca a classe PessoaJuridica herdando os atributos da classe Cliente
    class PessoaJuridica : Cliente
    {
        //declarando atributos
        private string razaoSocial, cnpj;

        //criando construtor
        public PessoaJuridica(string razaoSocial, string cnpj, int codigo, string endereco, string telefone)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.Codigo = codigo;
            this.Endereco = endereco;
            this.Telefone = telefone;

        }

        //declarando getters e setters
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}
