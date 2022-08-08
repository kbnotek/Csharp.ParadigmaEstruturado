using System;

namespace ApostilaDeCsharp.EstrutrasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if - estrutura de Seleção simples
            double x = 42.1;
            if(x >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }

            // if else - estrutura de seleção composta
            //var - quem define o tipo é o compilador
            var idade = 49;

            if (idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }
            else
            {
                Console.WriteLine("Grande Jovem Jovem");
            }

            //if else if - estrutura de seleção composta encadeada


            if (idade >= 43.1){
                Console.WriteLine("Mandaloriano");
            }
            else if (idade >=18 &&idade <43.1) 
            {
                Console.WriteLine("Grande Jovem Jovem");
            }
            else
            {
                Console.WriteLine("Menino(a)");
            }
            
            //switch - estutura de seleção múltipla

            var dia = 3;
            switch (dia)
            {
                case 2: Console.WriteLine("Segunda");break;
                case 3: Console.WriteLine("Terça");break;
                case 4: Console.WriteLine("Quarta");break;
                case 5: Console.WriteLine("Quinta");break;
                case 6: Console.WriteLine("Sexta"); break;
                    default: Console.WriteLine("Final de Semana Chegou! ...");break;
            }
            // Operador Ternario
            string mensagem;
            var salário =51000.20;
            mensagem = salário >= 50000.36 ? "Tá Rico hein" : "Tá complicado";
            Console.WriteLine(mensagem);
            

            /*double a, b;
            a = 3;
            b = 4;

            if(a/b == 0.75)
            {
                Console.WriteLine("Numéro fracionado");
            }
            */
            //Número Fracionado ;
            var numero = 5.3;
            if (numero.GetType() == typeof(double)) 
            Console.WriteLine("Numéro Fracionário/real");









            Console.ReadKey();
        }
    }
}
