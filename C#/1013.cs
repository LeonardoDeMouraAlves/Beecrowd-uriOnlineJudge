using System;

//Desenvolvido por Leonardo de Moura Alves

class URI {

    static void Main(string[] args) { 
    
        string[] entrada = Console.ReadLine().Split(' ');
        int maior = 0;
        
        if(Convert.ToInt32(entrada[0])>=Convert.ToInt32(entrada[1]) && Convert.ToInt32(entrada[0])>=Convert.ToInt32(entrada[2])){
            maior = Convert.ToInt32(entrada[0]);
        }
        if(Convert.ToInt32(entrada[1])>=Convert.ToInt32(entrada[0]) && Convert.ToInt32(entrada[1])>=Convert.ToInt32(entrada[2])){
            maior = Convert.ToInt32(entrada[1]);
        }
        if(Convert.ToInt32(entrada[2])>=Convert.ToInt32(entrada[0]) && Convert.ToInt32(entrada[2])>=Convert.ToInt32(entrada[1])){
            maior = Convert.ToInt32(entrada[2]);
        }
        
        Console.Write("{0} eh o maior\n", maior);
    }
}
