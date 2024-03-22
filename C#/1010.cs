using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        string[] entrada = Console.ReadLine().Split(' ');
        double valorPagar = 0.0;
        valorPagar = valorPagar + Convert.ToDouble(entrada[1]) * Convert.ToDouble(entrada[2]);
        
        string[] entrada1 = Console.ReadLine().Split(' ');
        valorPagar = valorPagar + Convert.ToDouble(entrada1[1]) * Convert.ToDouble(entrada1[2]);
        
        Console.Write("VALOR A PAGAR: R$ {0}\n", valorPagar.ToString("0.00"));
        
}
}
