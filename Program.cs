using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07jogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random();    
            
            int numero;
            int sorteio = sorteador.Next(1,11);

            Console.WriteLine("Bem-vindo a Conradito Jogos \n");
            Console.WriteLine("Adivinhe o numero de 1 até 10");
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());

            if(numero > 10 || numero < 1 ) 
            {
                Console.WriteLine("Digite um valor valido");
                Main(null);
                return;
            }
            if(numero == sorteio)
            {
                Console.WriteLine("Parabens, você acertou o número e ganhou!");
            }
            else
            {
                Console.WriteLine("Que pena, você errou! Tente novamente...");
                Main(null);
                return;
            }

            

            Console.ReadKey();
        }
    }
}
