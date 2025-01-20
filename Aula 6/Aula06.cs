using System;

namespace Aula6{
    class Aula06{
        static void Main(){
            int n1, n2, n3;
            n1 = 10; n2 = 20; n3 = 30;

            Console.WriteLine(" | n1={0} | \n | n2={1} | \n | n3={2} |",n1,n2,n3);

            Aula06.Main2();

        }
        static void Main2(){
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.3;
            string produto = "Pastel";

            Console.WriteLine(" ______________________________");
            Console.WriteLine("|Produto......:{0,15}|",produto);
            Console.WriteLine("|Val.Compra...:{0,15:c}|",valorCompra);
            Console.WriteLine("|Lucro........:{0,15:p}|",lucro);
            Console.WriteLine("|Val.Venda....:{0,15:c}|",valorVenda = valorCompra + (valorCompra * lucro));
            Console.WriteLine(" _____________________________");
        }
    }
}