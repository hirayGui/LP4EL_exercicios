//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    //classe Forma é abstrata, logo seus métodos não podem ser privados
    abstract class Forma
    {
        private string cor;

        protected string GetCor()
        {
            return cor;
        }
        protected void ConfigurarCor(string cor)
        {
            this.cor = cor;
        }

        //o método CalcularArea, por ser abstrato, não pode ter um "corpo"
        public abstract void CalcularArea();
    }
}
