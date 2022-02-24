//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Pesquisa
    {
        private string texto;

        public Pesquisa(string texto)
        {
            SetTexto(texto);
        }

        public void SetTexto(string texto)
        {
            this.texto = texto;
        }

        public string GetTexto()
        {
            return texto;
        }

        //método que verifica se informação inserida pelo usuário existe no texto principal
        //virtual declara que o método pode ser sobrescrito por classes filhas de Pesquisa
        public virtual void BuscarTexto(string texto)
        {
            //'existe' recebe status da existência da cadeia de caracteres no texto
            bool existe = this.texto.Contains(texto);

            if(existe == true)
            {
                Console.WriteLine("O termo '" + texto + "' existe no texto!!");
            }
            else
            {
                Console.WriteLine("O termo '" + texto + "' NÃO existe no texto!!");
            }

        }
    }
}
