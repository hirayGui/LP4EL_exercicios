//LP4EL - Aula 05
//Guilherme de Sousa Brito - SP3013189
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Inicio
    {
        static void Main(string[] args)
        {
            HashSet<string> mercado = new HashSet<string>() {"Banana", "Maçã", "Panela", "Sabonete", "Carne de cavalo"};
            HashSet<string> lojinha = new HashSet<string>() { "Banana", "Maçã", "Taiyaki", "Shochu" };
            //imprimindo itens do mercado
            Console.WriteLine("Itens do mercado: ");
            foreach (string m in mercado)
                Console.WriteLine(m);
            //imprimindo itens da lojinha
            Console.WriteLine("Itens da lojinha: ");
            foreach (string l in lojinha)
                Console.WriteLine(l);
            Console.WriteLine("\n");
            //---------------------------------------------------------------------------

            //Remova um produto do 1º conjunto.
            mercado.Remove("Carne de cavalo");
            //imprimindo itens do mercado
            Console.WriteLine("Itens do mercado: ");
            foreach (string m in mercado)
                Console.WriteLine(m);
            Console.WriteLine("\n");
            //---------------------------------------------------------------------------

            //Mostre os produtos em comum nos dois conjuntos. 
            mercado.IntersectWith(lojinha);
            //imprimindo itens do mercado
            Console.WriteLine("Itens em comum entre o mercado e a lojinha: ");
            foreach (string m in mercado)
                Console.WriteLine(m);
            Console.WriteLine("\n");
            //---------------------------------------------------------------------------

            //reiniciando listas
            mercado = new HashSet<string>() { "Banana", "Maçã", "Panela", "Sabonete", "Carne de cavalo" };
            lojinha = new HashSet<string>() { "Banana", "Maçã", "Taiyaki", "Shochu" };
            //---------------------------------------------------------------------------

            //Junte os produtos dos dois conjuntos. 
            mercado.UnionWith(lojinha);
            //imprimindo itens do mercado
            Console.WriteLine("Itens do mercado junto da lojinha: ");
            foreach (string m in mercado)
                Console.WriteLine(m);
            //---------------------------------------------------------------------------

            //reiniciando listas
            mercado = new HashSet<string>() { "Banana", "Maçã", "Panela", "Sabonete", "Carne de cavalo" };
            lojinha = new HashSet<string>() { "Banana", "Maçã", "Taiyaki", "Shochu" };
            //---------------------------------------------------------------------------

            //Subtraia o 1º conjunto do 2º conjunto.
            lojinha.ExceptWith(mercado);
            //imprimindo itens da lojinha
            Console.WriteLine("Itens da lojinha menos os do mercado: ");
            foreach (string l in lojinha)
                Console.WriteLine(l);
            Console.WriteLine("\n");
            //---------------------------------------------------------------------------

            //reiniciando listas
            mercado = new HashSet<string>() { "Banana", "Maçã"};
            lojinha = new HashSet<string>() { "Banana", "Maçã", "Taiyaki", "Shochu" };
            //imprimindo itens do mercado
            Console.WriteLine("Itens do mercado: ");
            foreach (string m in mercado)
                Console.WriteLine(m);
            //imprimindo itens da lojinha
            Console.WriteLine("Itens da lojinha: ");
            foreach (string l in lojinha)
                Console.WriteLine(l);
            Console.WriteLine("\n");
            //---------------------------------------------------------------------------

            //Verifique se o 1º conjunto está contido no 2º.
            if (mercado.IsSubsetOf(lojinha))
                Console.WriteLine("Itens de mercado estão contidos em lojinha");
            else
                Console.WriteLine("Itens de mercado NÃO estão contidos em lojinha");
            //----------------------------------------------------------------------------
            
            //Verifique se o 1º conjunto contém o 2º.
            if (mercado.IsSupersetOf(lojinha))
                Console.WriteLine("Mercado contém itens da lojinha");
            else
                Console.WriteLine("Mercado NÃO contém itens da lojinha");
            //---------------------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
