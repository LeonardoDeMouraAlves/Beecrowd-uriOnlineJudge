using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        double A = Convert.ToDouble(Console.ReadLine()), B = Convert.ToDouble(Console.ReadLine()), C = Convert.ToDouble(Console.ReadLine());
        Console.Write("MEDIA = " + ((((A*2)+(B*3)+(C*5))/10).ToString("0.0"))+ "\n");
    }

}
