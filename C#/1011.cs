using System;

//Desenvolvido por Leonardo de Moura Alves

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double raio = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("VOLUME = {0}\n", (Convert.ToDouble(4.0/3.0)*3.14159*raio*raio*raio).ToString("0.000"));
    }
}
