using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        double A = Convert.ToDouble(Console.ReadLine()), B = Convert.ToDouble(Console.ReadLine());
        Console.Write("MEDIA = " + ((A*3.5+B*7.5)/11).ToString("0.00000") + "\n");
    }

}
