﻿class program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i+=5)
        {            
            Console.WriteLine($"Estou passando pela {i} vez no for");

        }
        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"variavel sesi vale {sesi}");
        }
        {
            Console.WriteLine($"{numero} x {cont} = {numero*cont}");
        }

        int numero = 87;
        for(int cont = 1; cont <= 1000; cont++)
        {
            Console.WriteLine($"{numero} x {cont} = {numero*cont}");
        }
        //Declarando um vetor
        string[]alunos = new string [35];

        //Atribuindo valores ao nosso vetor
        alunos[1] = "Abner";
        alunos[2] = "Adalberto Kaio";
        alunos[3] = "Ana Carolina";
        alunos[4] = "Samuel";

        foreach (string aluno in alunos)
        {

            Console.WriteLine(aluno);
        }

        int[]cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;
         
         int laura = 0 ; //soma
         int jorge = 0 ; //maior
         int bianca = 100 ; //menor
        foreach (int enzo in cadeiras)
        {
            laura = laura + enzo
            if (enzo > jorge)
            jorge = enzo;
            {
            if(enzo < bianca)
            bianca = enzo;
               
        }
    }
    Cosole.WriteLine($"Soma: {laura}, Maior {jorge} menor {bianca}");

    Array.Sort(cadeiras);

    for (int x = 0; x < cadeiras.Lenght)
       Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
    
}
Array.Sort(cadeiras);
for(int x = 0; x < cadeiras.Lenght ; x++){
    Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
}
