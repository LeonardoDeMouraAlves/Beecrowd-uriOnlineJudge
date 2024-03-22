using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        string nome = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine()), vendas = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("TOTAL = R$ {0}\n", (salario+vendas*0.15).ToString("0.00"));
        
    }

}
