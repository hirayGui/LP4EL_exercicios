//LP4EL - Aula 05
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> funcionarios = new Dictionary<string, decimal>();

            //Adicione um funcionário.
            funcionarios.Add("Mar Celo", 450);
            funcionarios.Add("Ro Berto", 900);
            funcionarios.Add("Pedro Pedroso", 150);
            //consultando funcionarios
            Console.WriteLine("Lista de funcionarios:");
            foreach (KeyValuePair<string, decimal> x in funcionarios)
                Console.WriteLine(x);

            //Altere o salário de um funcionário. 
            funcionarios["Ro Berto"] = 400;
            //consultando funcionarios
            Console.WriteLine("Lista de funcionarios:");
            foreach (KeyValuePair<string, decimal> x in funcionarios)
                Console.WriteLine(x);

            //Remova um funcionário.
            funcionarios.Remove("Mar Celo");
            //consultando funcionarios
            Console.WriteLine("Lista de funcionarios:");
            foreach (KeyValuePair<string, decimal> x in funcionarios)
                Console.WriteLine(x);

            //Verifique a existência de um funcionário. 
            if (funcionarios.ContainsKey("Ro Berto"))
                Console.WriteLine("Salário de Ro Berto: " + funcionarios["Ro Berto"]);

            //Verifique a existência de um salário.
            if (funcionarios.ContainsValue(150))
                Console.WriteLine("Salário existe!");



            Console.ReadKey();
        }
    }
}
