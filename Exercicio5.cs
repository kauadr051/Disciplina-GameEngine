using System;

class Exercicio5
{

    static void Main (string[] args) { 

        string meuTime = "Grêmio";

        switch (meuTime){

            case "Grêmio":
               Console.WriteLine("O Grêmio possui 93 Títulos Oficias");
            break;

            case "Internacional":
               Console.WriteLine("O Internacional possui 64 Títulos Oficias");
            break;

            case "Juventude":
               Console.WriteLine("O Juventude possui 40 Títulos Oficias");
            break;

            case "Caxias do Sul":
               Console.WriteLine("O Caxias do Sul possui 16 Títulos Oficias");
            break;

            case "Criciúma":
               Console.WriteLine("O Criciúma possui 12 Títulos Oficias");
            break;

            default:
               Console.WriteLine("Time não encontrado.");
            break;   
        }

    }  
}


        /* 

            Usando Switch, crie uma váriavel chamada meuTime
            Faça um switch com cada case representando um time, e imprima algo diferente cada um

       */
