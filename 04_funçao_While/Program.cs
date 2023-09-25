//public static string NomeFuncao(string nome)()


class Sesi
{
    public static void Main()
    {
        MostrarMensagem("Seja bem-vindo");
        MostrarMensagem("SESI / SENAI");
        ImprimirDatahora();
        //Chamado o método Potenciacao com o paramentro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {potencia} ");

        ContagemRegressiva(10);
    }

public static void ContagemRegressiva(int n){

while (n >= 0)
    {
        Console.WriteLine(n);
        n--;   //n = n - 1
        System.Threading.Thread.Sleep(1000);   //500 ms
    }
    Console.WriteLine("BOOOOOOOOM");

public static void JogoQueNrSouEu()
}
console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *")
Console.WriteLine("                Bem Vindo ao Jogo            ")
Console.WriteLine("Sorteei um n de 1  a 20, tente adivinha-lo   ")
Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *")
Console.WriteLine(""); //Linha em branco

Random rnd = new Random();
int nrSorteado = rnd.Next(20);
int nrDigitado = -1;

do {
    Console.WriteLine("Digite um n");
    nrDigitado = int.Parse(Console.Readline());
    if(nrDigitdo > nrSorteado)
    Console.WriteLine("O número digitado é MAIOR que o sorteado");
    else if (nrDigitado < nrSorteado)
    Console.WriteLine("O número digitado é MENOR que o sorteado");
} while (nrDigitado != nrSorteado);

Console.WriteLine("Parabéns voce acertou");

    



    public static double Potenciacao(int num ){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }
    public static void ImprimirDatahora(){
        Console.WriteLine(DateTime.Now.ToString());
    }
    public static void MostrarMensagem(string mensagem)
{
    Console.WriteLine(mensagem);
}

}
