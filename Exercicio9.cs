using System;

class Exercicio9
{

    public void meusDados(string nome,int idade,double altura) {
        Console.WriteLine($"Meu nome é {nome}, minha idade é {idade} e minha altura é {altura}");
    }   

    static void Main (string[] args) {
        
        Exercicio9 meuObj = new Exercicio9();

        meuObj.meusDados("Kauã",17,1.82);
        

    }  
}

// Criar uma função que recebe seu nome, sua idade e sua altura e imprime no terminal.