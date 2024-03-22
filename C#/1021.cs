using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        float dinheiro = float.Parse(Console.ReadLine());
        int aux = 0;
 
        Console.Write("NOTAS:\n");
        
        while(dinheiro>=100){
            aux++;
            dinheiro=dinheiro-100;
        }
        Console.Write("{0:f0} nota(s) de R$ 100.00\n", aux);
        aux=0;
        
        while(dinheiro>=50){
            aux++;
            dinheiro=dinheiro-50;
        }
        Console.Write("{0:f0} nota(s) de R$ 50.00\n", aux);
        aux=0;
        
        while(dinheiro>=20){
            aux++;
            dinheiro=dinheiro-20;
        }
        Console.Write("{0:f0} nota(s) de R$ 20.00\n", aux);
        aux=0;
        
        while(dinheiro>=10){
            aux++;
            dinheiro=dinheiro-10;
        }
        Console.Write("{0:f0} nota(s) de R$ 10.00\n", aux);
        aux=0;
        
        while(dinheiro>=5){
            aux++;
            dinheiro=dinheiro-5;
        }
        Console.Write("{0:f0} nota(s) de R$ 5.00\n", aux);
        aux=0;
        
        while(dinheiro>=2){
            aux++;
            dinheiro=dinheiro-2;
        }
        Console.Write("{0:f0} nota(s) de R$ 2.00\n", aux);
        aux=0;
        
        dinheiro=dinheiro*100;
        Console.Write("MOEDAS:\n");
        
        while(dinheiro>=100){
            aux++;
            dinheiro=dinheiro-100;
        }
        Console.Write("{0:f0} moeda(s) de R$ 1.00\n", aux);
        aux=0;
        
        while(dinheiro>=50){
            aux++;
            dinheiro=dinheiro-50;
        }
        Console.Write("{0:f0} moeda(s) de R$ 0.50\n", aux);
        aux=0;
        
        while(dinheiro>=25){
            aux++;
            dinheiro=dinheiro-25;
        }
        Console.Write("{0:f0} moeda(s) de R$ 0.25\n", aux);
        aux=0;

        while(dinheiro>=10){
            aux++;
            dinheiro=dinheiro-10;
        }
        Console.Write("{0:f0} moeda(s) de R$ 0.10\n", aux);
        aux=0;
        
        while(dinheiro>=5){
            aux++;
            dinheiro=dinheiro-5;
        }
        Console.Write("{0:f0} moeda(s) de R$ 0.05\n", aux);
        aux=0;
        
        while(Convert.ToInt32(dinheiro)>0){
            aux++;
            dinheiro=dinheiro-1;
            
        }
        Console.Write("{0:f0} moeda(s) de R$ 0.01\n", aux);
        
}
}
