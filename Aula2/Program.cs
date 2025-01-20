using System;

namespace Aula2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0) {
                Console.WriteLine(args.GetValue(0));
            }
            else {
                Console.WriteLine("Não há argumentos");
            }
        }


    }
}