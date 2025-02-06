using System;

namespace Aula13{
    class Aula13{

        static void Main(){
            
            int[] n = new int[5]; 
            int[] num = new int[3]{1,2,3};

            n[0]=11;
            n[1]=22;
            n[2]=33;
            n[3]=44;
            n[4]=55;

            for(int i=0; i<n.Length; i++){
                Console.WriteLine(n[i]);
            }

            for(int l=0; l<num.Length;l++){
                Console.WriteLine(num[l]);
            }
        }

    }
}