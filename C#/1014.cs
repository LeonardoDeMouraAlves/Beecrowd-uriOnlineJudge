using System; 

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
        int distancia = Convert.ToInt32(Console.ReadLine());
        double combustivel = Convert.ToDouble(Console.ReadLine());
        
        Console.Write(Convert.ToDouble(distancia/combustivel).ToString("0.000") + " km/l\n");
}
}
