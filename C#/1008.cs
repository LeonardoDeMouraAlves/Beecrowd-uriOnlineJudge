using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        int funcionario = Convert.ToInt32(Console.ReadLine()), horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
        double salarioHoras = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("NUMBER = {0}\nSALARY = U$ {1}\n", funcionario, (horasTrabalhadas*salarioHoras).ToString("0.00"));
    }

}
