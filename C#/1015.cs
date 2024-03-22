using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        string[] entrada = Console.ReadLine().Split(' ');
        double X1 = Convert.ToDouble(entrada[0]), Y1 = Convert.ToDouble(entrada[1]);
        
        string[] entrada1 = Console.ReadLine().Split(' ');
        double X2 = Convert.ToDouble(entrada1[0]), Y2 = Convert.ToDouble(entrada1[1]);
        
        Console.Write(Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)).ToString("0.0000") + "\n");
    }
}
