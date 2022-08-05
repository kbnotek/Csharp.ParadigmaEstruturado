using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sequêncial - TopDown
             * 
             * Passo 1
             * Passo 2 
             * Passo 3
             * Passo 4
             *            
             */
            string repetir;
            string looping;
            string nome;
            do
            {//Passo 1 - Entrada de Dados

                Console.WriteLine("Qual é o Aluno ?");
                 nome = Console.ReadLine().ToUpper();

                //Passo 2 -Processamento
                string resposta;
                if (nome.Equals("BRUNO"))
                {
                    resposta = "Aluno do Senai";
                }
                else
                {
                    resposta = "Não é o Aluno do Senai";
                }
                //Passo 3 - Saída
                Console.WriteLine(resposta);
                
                
                    //passo 4 =- Montar uma Iteração ( repetição )
                    Console.WriteLine("Deseja Sair ? Y-N ");
                    looping = Console.ReadLine().ToUpper();
            

                
          
            } while (!looping.Equals("Y"));

            int[] notas = new int[4];
            notas[0] = 9;
            notas[1] = 21;
            notas[2] = 7;
            notas[3] = 15;
            Console.WriteLine($"Mostre as Notas do Aluno {nome} ");
            double soma= 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(notas[i]);
             
                soma = soma + notas[i];
            }
            double media = soma / notas.Length;
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");




            Console.ReadKey();


        }
    }
}
