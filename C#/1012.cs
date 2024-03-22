using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        string[] entrada = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(entrada[0]), B = Convert.ToDouble(entrada[1]), C = Convert.ToDouble(entrada[2]);
        
        Console.Write("TRIANGULO: {0}\n", (A*C/2).ToString("0.000"));
        Console.Write("CIRCULO: {0}\n", (3.14159*C*C).ToString("0.000"));
        Console.Write("TRAPEZIO: {0}\n", ((A+B)*C/2).ToString("0.000"));
        Console.Write("QUADRADO: {0}\n", (B*B).ToString("0.000"));
        Console.Write("RETANGULO: {0}\n", (A*B).ToString("0.000"));
        
    }
}
