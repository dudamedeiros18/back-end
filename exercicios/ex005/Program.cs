class Program{

     public static void Main() 
     {
        ListaDoChurasco();
     }

     public static void ListaDoChurasco(){
        //Declarar o vetor com 6 posições tipo string
        string[] lista = new string[6];
        //Receber os produtos que precisam ser comprados
        for(int i = 0; i <6; i++){


            //Console para informar o produto a comprar 
              Console.WriteLine("Digite o produto que vamos comprar");
              ListaDoChurrasco = int.Parse(Console.ReadLine);
            //Declarar uma variavel produto para receber o que eu escrever no ReadLine
             string produto = Console.ReadLine();
            //Atribuir no meu vetor o produto que eu digitei pela posição
            lista[i] = produto;
        }
         Array.Sort(lista);
     //Para cada item na lista imprimir o produto
     foreach(string item in lista){
        Console.WriteLine(item);
     }
     }

     //Ordenar meu vetor
    
}
