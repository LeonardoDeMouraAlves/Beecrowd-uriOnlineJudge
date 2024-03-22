using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        double raio = Convert.ToDouble(Console.ReadLine());
        Console.Write("A="+ (((Convert.ToDouble(3.14159))*(raio*raio)).ToString("0.0000"))+"\n");
    }

}
