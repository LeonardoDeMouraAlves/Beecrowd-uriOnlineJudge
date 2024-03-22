using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        int segundos = int.Parse(Console.ReadLine());
        int minutos = 0;
        int horas = 0;
        
        while(segundos>=60){
            minutos++;
            segundos=segundos-60;
        }
        while(minutos>=60){
            horas++;
            minutos=minutos-60;
        }
        
        Console.Write("{0}:{1}:{2}\n",horas,minutos,segundos);
    }
}
