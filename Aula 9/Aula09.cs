// C# - Aula 09: Enumeradores (enum)
using System;

namespace Aula09{
class Aula09{
    enum diasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    public static void Main(){

        //diasSemana ds = (diasSemana)3;
        
        int ds = (int)diasSemana.Sexta; 


        Console.WriteLine(ds);

        }
    }
}