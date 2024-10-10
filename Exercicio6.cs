using System;

class Exercicio6
{
    static void Main() {


        int numero = 10;

        while(numero > 0) {
         numero = numero -1;
         Console.WriteLine(numero);
         if(numero == 0){
         Console.WriteLine($"BOOOOOM!");
         

        }
        else if(numero % 2 == 0){

         Console.WriteLine($"TAC");
        }
        else{
         Console.WriteLine($"TIC");
        }

        }

        
    }
}


/* Uma contagem que vai de 10 a 0
SE o segundo for par, imprime "TIC"
SE O segundo for ímpar, imprime "TAC"
Quando a contagem chegar a 0, imprime
"BOOOOOM!" */
