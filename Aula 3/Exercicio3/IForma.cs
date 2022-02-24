//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    //classe Forma é interface, logo ela não possui atributos e seus métodos são obrigatoriamente públicos
    interface IForma
    {
        void ConfigurarCor(string cor);
        void CalcularArea();
    }
}
