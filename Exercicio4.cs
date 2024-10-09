using System;

class Exercicio4
{

    static void Main (string[] args) { 
        
        bool lampadaLigada = true;

        if (lampadaLigada){

            Console.WriteLine ("A lâmpada está ligada");
        }
         else {
            Console.WriteLine ("A lâmpada está desligada");
        }      
    }  
}


        /* 
            Crie uma variável que diga se uma lâmpada está ligada ou não
            Exemplo:
            bool lampadaLigada = true;
            ou
            string lampadaLigada = "Ligada"

            SE a lâmpada estiver ligada, imprimir "A lâmpada está ligada"
            SE NÃO, imprimir "A lâmpada está desligada."


            EXERCICIO 2
            Um dia pode ser dividido entre: manhã, tarde, noite, madrugada.
            Manhã é antes das 12 é igual ou maior que 6 horas
            Tarde é das 12 em diante até as 18
            Noite é a partir das 18, até um pouco antes da meia noite (0 hora)
            Madrugada é a partir da 0 hora, até um pouco antes das 6.

            Crie uma variável chamada 'hora' e atribua um número inteiro
            a ela, de 0a 23 (ex:5). Através de um if, else if, else, imprima se é de manhã, se é de tarde, se é de noite, ou se é de madrugada.

       */
