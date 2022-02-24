﻿//LP4EL - Aula 03
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Retangulo : Forma
    {
        private double comprimento, altura;

        //declarando construtor da classe
        public Retangulo(double comprimento, double altura, string cor)
        {
            SetComprimento(comprimento);
            SetAltura(altura);
            ConfigurarCor(cor);
        }

        //sobrescrevendo método da classe abstrata
        public override void CalcularArea()
        {
            double area = comprimento * altura;
            Console.WriteLine("Informações do retângulo: " +
                            "\nCor: " + GetCor() +   
                            "\nBase: " + comprimento +
                            "\nAltura: " + altura +
                            "\nÁrea: " + area);

            Console.WriteLine("\n");
        }

        //declarando getters e setters
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }

        public double GetAltura()
        {
            return altura;
        }

        public void SetComprimento(double comprimento)
        {
            this.comprimento = comprimento;
        }

        public double GetComprimento()
        {
            return comprimento;
        }
    }
}
