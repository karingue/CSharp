using System;

namespace Aula10{

    class Aula10{

        public static void Main(){

          float n1, n2, n3, n4, n5;
          n1=n2=n3=n4=n5=0;
                   

            for(int i = 0; i < 5; i++){
                Console.Write("Digite a nota " + (i + 1) + ":");
                float nota = float.Parse(Console.ReadLine());
            

            switch(i){
                case 0:
                    n1 = nota;
                    break;
                case 1:
                    n2 = nota;
                    break;
                case 2:
                    n3 = nota;
                    break;
                case 3:
                    n4 = nota;
                    break;
                case 4:
                    n5 = nota;
                    break;
                }  
            }

            float media = (n1 + n2 + n3 + n4 + n5) / 5.2f;
            Console.WriteLine("A média é: " + media);

            string resultado = "";
            if(media >=6){
                if(media >=8.5){
                    resultado = "Aprovado com Maestria";
                }else{
                    resultado = "Aprovado";
                }
            }else{
                if(media >= 4){
                    resultado = "Recuperação";
                }else{
                    resultado = "Reprovado";
                }
            }
            Console.WriteLine("Sua média é: {0} e então você está: {1}",media, resultado);
        }
    }
}