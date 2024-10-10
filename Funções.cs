using System;

class Funcoes   
{
    public void calculaAreaR(int baseR,int alturaR) {

        int areaR = baseR * alturaR;
        Console.WriteLine(areaR);
    }   

    static void Main (string[] args) {
        
        Funcoes meuObj = new Funcoes();

        meuObj.calculaAreaR(5,10);
        meuObj.calculaAreaR(6,12);
        meuObj.calculaAreaR(7,14);

    }  
}
