//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Circulo : Forma
    {
        static double pi = 3.14;
        private double raio;

        //declarando construtor
        public Circulo(double raio, string cor)
        {
            SetRaio(raio);
            ConfigurarCor(cor);
        }

        //sobrescrevendo método da classe abstrata
        public override void CalcularArea()
        {
            double area = pi * (raio * raio);
            Console.WriteLine("Informações da circulo: " +
                            "\nCor: " + GetCor() +
                            "\nRaio: " + raio +
                            "\nPi: " + pi +
                            "\nÁrea: " + area);

            Console.WriteLine("\n");
        }

        //declarando get e set
        public void SetRaio(double raio) {
            this.raio = raio;
        }

        public double GetRaio() {
            return raio;
        }
    }
}
