//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class PesquisaFim : Pesquisa
    {
        public PesquisaFim(string texto) : base(texto)
        {
        }

        //método que verifica se informação inserida pelo usuário existe no final do texto principal
        //sealed faz com que nenhuma classe filha de PesquisaFim possa sobrescrever o método
        public sealed override void BuscarTexto(string texto)
        {
            //'existe' recebe status da existência da cadeia de caracteres no texto
            //StringComparison.CurrentCultureIgnoreCase desativa a sensibiidade de caracteres do metódo
            bool existe = base.GetTexto().EndsWith(texto, StringComparison.CurrentCultureIgnoreCase);

            if (existe == true)
            {
                Console.WriteLine("O termo '" + texto + "' existe no final do texto!!");
            }
            else
            {
                Console.WriteLine("O termo '" + texto + "' NÃO existe no final do texto!!");
            }

        }
    }
}
