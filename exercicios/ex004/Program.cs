class senai{

    public static void Main() {
    int divisoes =Divisao( int.Parse(Console.Readline));
    Console.WriteLine($"divisao {divisoes}");

    int multiplicacao = int.Parse(Console.ReadLine());
    double valor = multiplicacao(multiplicacao);
    Console.WriteLine($"O dobro do {valor}");

    }
}

  public static int Divisao(int num)
  {
    int resultado = num/2;
    return resultado;
  }

  public static double Multiplicacao(int num)
  {
    double resultado = num*2;
    return resultado;
  }

  public static void tabuada(int valor)
  {
    int contador = 1;

    while(contador <=10)
    {
        Console.WriteLine($"{valor} x {contador} = {valor * contador}");
        contador++;
    }

    public static void ResumoSalarios()
    {
        int somaSalario = 0;
        int menorSalario = 100000;
        int maiorsalario = 0;
        
        do {
            Console.WriteLine("Digite o salario do Empregado:");
            salarioEmpregado = int.Parse(Console.ReadLine);

            while (salarioEmpregado > 0);
        }
    }




  }