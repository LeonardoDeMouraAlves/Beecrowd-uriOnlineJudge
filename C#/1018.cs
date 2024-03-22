using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        int x = int.Parse(Console.ReadLine());
        int i = 0;
        
        Console.WriteLine("{0}",x);
        
        while(x>=100){
        x=x-100;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 100,00",i);
        i=0;
        
        while(x>=50){
        x=x-50;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 50,00",i);
        i=0;
        
        while(x>=20){
        x=x-20;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 20,00",i);
        i=0;
        
        while(x>=10){
        x=x-10;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 10,00",i);
        i=0;
        
        while(x>=5){
        x=x-5;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 5,00",i);
        i=0;
        
        while(x>=2){
        x=x-2;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 2,00",i);
        i=0;
        
        while(x>=1){
        x=x-1;
        i++;
        }
        Console.WriteLine("{0} nota(s) de R$ 1,00",i);
    }
        
    }
}
