using System;

namespace Aula12{

    class Aula12{
        static void Main(){

            int tempo = 0;
            char Escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("Viagem X a Viagem Y");
            Console.WriteLine("Transportes: [A] - Avião | [B] - Ônibus | [C] - Carro");
            Console.WriteLine("Escolha um transporte: ");
            Escolha=char.Parse(Console.ReadLine());
            
            switch(Escolha){
                case 'A':
                case 'a':
                    tempo = 50;
                    break;
                case 'B':
                case 'b':
                    tempo = 300;
                    break;
                case 'C':
                case 'c':
                    tempo = 400;
                    break;
                default:
                    tempo = -1;
                    break;
            }
            while(tempo == -1){
                Console.WriteLine("Transporte escolhido inválido, escolha novamente: ");
                Escolha=char.Parse(Console.ReadLine());
                switch(Escolha){
                    case 'A':
                    case 'a':
                        tempo = 50;
                        break;
                    case 'B':
                    case 'b':
                        tempo = 300;
                        break;
                    case 'C':
                    case 'c':
                        tempo = 400;
                        break;
                    default:
                        tempo = -1;
                        break;
                }
            }
            if(tempo < 0){
                Console.WriteLine("Transporte escolhido inválido");
            }else{
                Console.WriteLine("O tempo da viagem é de {0} minutos", tempo);
            }

            Console.WriteLine("Deseja calcular outro transporte? [S/N]");
            Escolha=char.Parse(Console.ReadLine());

            if(Escolha == 'S' || Escolha == 's'){
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("Fim do Programa");
            }
        }
    }
}//Fim do Código	
