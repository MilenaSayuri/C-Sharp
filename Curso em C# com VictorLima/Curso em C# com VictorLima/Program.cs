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
            Console.WriteLine(nome);
            Console.WriteLine("Seu RG eh: ");
            Console.WriteLine(RG);

            int adicao = 20 + 20;
            int multiplicacao = 20 * 3;
            int divisao = 20 / 2;
            float divisaoo = 5.0f / 2;

            Console.WriteLine(adicao);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);
            Console.WriteLine(divisaoo);

            //loops

            if (10 > 200)
            {
                Console.WriteLine("Eh verdade");
            }
            else
            {
                Console.WriteLine("Eh mentira");
            }

            Console.WriteLine("Digite seu gênero: ");
            string genero = Console.ReadLine().ToLower();
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (genero == "mulher" && idade >= 25)
            {
                Console.WriteLine("Entrada confirmada na festa de graça!");
            }
            else
            {
                Console.WriteLine("Vc nao dentro das condições para entrar na festa de graça");
            }

            ExibirMsg();
            GerarPreco(50, "Lamen");

            //array
            string[] produtos = new string[5]
            {
                "Stardew Valley",
                "Hogwarts Legacy",
                "Resident Evil",
                "The Legend of Zelda",
                "Pokemon"
            };

            Console.WriteLine(produtos[2]);

                Console.ReadLine();
        }


        //funcao
        // TipoDeRetorno NomeDaFuncao(TipoParametro parametro)
        static void ExibirMsg()
        {
            Console.WriteLine("Estou usando funcoes");
            Console.WriteLine("Seja bem-vindo!");


        }

        static void GerarPreco(int valor, string nome) //valor so funciona dentro dessa funcao
        {
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("R$" + valor);
        }
    }
}
