//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using Exercicio_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Circulo : IForma
    {
        static double pi = 3.14;
        private double raio;
        private string cor;

        //declarando construtor
        public Circulo(double raio, string cor)
        {
            SetRaio(raio);
            ConfigurarCor(cor);
        }

        //sobrescrevendo método da interface
        public void CalcularArea()
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
        public void SetRaio(double raio)
        {
            this.raio = raio;
        }

        public double GetRaio()
        {
            return raio;
        }

        //sobrescrevendo ConfigurarCor()
        public void ConfigurarCor(string cor)
        {
            this.cor = cor;
        }

        public string GetCor()
        {
            return cor;
        }
    }
}
