using System;

namespace Aula3 {
    class Aula03 {
        static void Main(){
            //Tipos de Dados
            byte n1 = 10;
            int num = 0; //int é um tipo de dado que armazena um número inteiro
            char letra = 'c'; //char é um tipo de dado que armazena um único caractere
            float valor = 5.5f; //float é um tipo de dado que armazena um número decimal
            string nome = "Bruno"; //string é um tipo de dado que armazena uma sequência de caracteres
            var aux = 10; //var é um tipo de dado que armazena um valor que pode ser alterado
            bool verdadeiro = true; //bool é um tipo de dado que armazena um valor lógico (true ou false)
            double numeroGrande = 1234.5678; //double é um tipo de dado que armazena números decimais com maior precisão
            long numeroInteiroGrande = 9223372036854775807L; //long é um tipo de dado que armazena números inteiros muito grandes
            decimal valorPreciso = 123.456789m; //decimal é usado para valores monetários com alta precisão
            
            var aux2 = nome;
            Console.WriteLine("O nome do individuo é: " + aux2);
            int num1 = 10;
            int num2 = 2;

            var soma = num1 + num2;
            Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + soma);
        }
        
    }
}