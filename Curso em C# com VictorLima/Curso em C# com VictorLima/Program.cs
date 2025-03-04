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
        //enum -> enumeracao
        enum Cor { Azul = 33, Rosa = 28, Roxo = 10, Preto = 111, Cinza = 55 }


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

            int contador = 0;
            while( contador < 10)
            {
                Console.WriteLine("Rodando o While!");
            }
            Console.WriteLine("FIM DA LINHA!");

            string[] palavras = { "Milena", "Sayuri", "Hayakawa" };
            foreach(string palavra in palavras)
            {
                Console.WriteLine("FOREACH RODANDO");
            }
            Console.WriteLine("Fim do FOREACH");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fim do FOR");

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


            //switch
            string cor = "Azul";
            switch (cor)
            {
                case "Rosa":
                    Console.WriteLine("Sua cor favorita eh Rosa!");
                    break;
                case "Preto":
                    Console.WriteLine("Sua cor favorita eh Preto!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu nao conheço!");
                    break;
            }

            ExibirMsg();
            GerarPreco(50, "Lamen");

            Cor CorFavorita = Cor.Rosa;
            Console.WriteLine(CorFavorita);
            Console.WriteLine((int)CorFavorita);
            Console.WriteLine((Cor)111);


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
