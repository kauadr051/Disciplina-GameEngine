using System;

class Exercicio3
{

    static void Main (string[] args) {
        
        bool escolaConcluida = true;
        int idade = 29;
        bool maiorIdade = idade >= 18;
        int faculdade = 0;
        bool aptoFaculdade = semFaculdade < 1;

        Console.WriteLine(escolaConcluida && maiorIdade && aptoFaculdade);
    }  
}

/*

Para entrar na faculdade, uma pessoa precisa:

    1 - ter 18 anos ou mais
    2 - ter concluído o ensino médio
    3 - não estar em outra faculdade

Faça um Console.WriteLine que cotenha a equação, usando operadores lógicos, que diz se uma pessoa
pode ou não entrar na faculdade */    
