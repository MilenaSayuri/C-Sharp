//metodos ou pacotes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_em_C__com_VictorLima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Meu nome eh Milena");


            //variaveis
            int number = 20;
            string corFavorita = "Minha cor favorita: Rosa";
            bool sinal = false;
            float velocidade = 201.10f;

            Console.WriteLine(corFavorita);

            corFavorita = "Minha cor favorita: Preto";

            Console.WriteLine(corFavorita);

            //constantes usada por seguranca para evitar mudanca nos valores
            const float PI = 3.14f;
            const int RG = 12345678;

            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome eh: ", nome);
            //Console.WriteLine(nome);
            Console.WriteLine("Seu RG eh: ");
            Console.WriteLine(RG);
            


            Console.ReadLine();
        }
    }
}
