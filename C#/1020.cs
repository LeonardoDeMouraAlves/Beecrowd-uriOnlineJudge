using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        int dias = int.Parse(Console.ReadLine());
 
        Console.Write("{0} ano(s)\n{1} mes(es)\n{2} dia(s)\n",dias/365,(dias%365)/30,(dias%365)%30);
    }
}
