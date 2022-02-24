//LP4EL - Aula 02
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_04
{
    class Cliente
    {
        //declarando atributos
        private int codigo;
        private string endereco, telefone;

        //declarando getters e setters
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
