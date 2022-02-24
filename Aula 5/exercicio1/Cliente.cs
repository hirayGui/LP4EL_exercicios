//LP4EL - Aula 05
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Cliente 
    {
        private int codigo = -1;
        private string nome, cpf;

        public Cliente(int codigo, string nome, string cpf)
        {
            SetCodigo(codigo);
            SetNome(nome);
            SetCpf(cpf);
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public bool SetCodigo(int codigo)
        {
            //autoincrementação do código é feita na classe Inicio
            //tive problemas com a autoincrementação sendo feita nessa classe
            if (codigo < 10)
            {
                this.codigo = codigo;
                return true;
            }
            else
                return false;
        }


        public string GetNome()
        {
            return nome;
        }

        public bool SetNome(string nome)
        {
            try
            {
                //definindo que nome deve ser composto para ser cadastrado
                if ((nome.Any(Char.IsWhiteSpace) == true) && (nome != null))
                {
                    this.nome = nome;
                    return true;
                }
                else
                    return false;
            }catch(ArgumentNullException e)
            {
                return false;
            }
        }

        public string GetCpf()
        {
            return cpf;
        }

        public bool SetCpf(string cpf)
        {
            try
            {
                //definindo que cpf deve conter 11 caracteres
                if (cpf != null && cpf.Length == 11)
                {
                    this.cpf = cpf;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException e)
            { 
                return false;
            }

        }
    }
}
