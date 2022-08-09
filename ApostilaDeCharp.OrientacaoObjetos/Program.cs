using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCharp.OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objeto p
            Personagem p = new Personagem();
            p.Nome = "Aloy";
            p.QtdePontos = 11;
            p.QtdeVidas = 7;

            Movimentacao m = new Movimentacao();
            m.Voar(p);
            m.Andar(p);
            Console.WriteLine(m.Andar(p));
            

            //Objeto utilizando NovoProjeto
           /* Personagem p2 = new Personagem();
            p2.Nome = "eloin";
            p2.QtdePontos = 20;
            p2.QtdeVidas = 6;

             Movimentacao m2 = new Movimentacao();
            m2.Voar(p2);
            Console.WriteLine(m2.Voar(p2));*/


            Console.ReadKey();
        }
    }
}
