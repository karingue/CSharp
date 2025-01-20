using System;

namespace Aula_04
{
    class Aula04{

        int num = 10; // Variável de instância
        static void Main()
        {
           Aula04 aula04 = new Aula04();
           aula04.teste();
        }
        void teste(){
            Console.WriteLine(num);

        }       
    }
}