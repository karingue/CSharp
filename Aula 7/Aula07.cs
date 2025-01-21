using System;

namespace Aula07
{
    class Aula07
    {
        static void Main(string[] args){
            int v1, v2, soma;
            string nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());

            soma = v1 + v2;

            Console.WriteLine("Olá {0}, a soma de {1} e {2} é igual a {3}", nome, v1, v2, soma);
        }
    }
}