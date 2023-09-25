using Models;
public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("*********************");
        Console.WriteLine("Bem-vindo ao C# Banco");
        Console.WriteLine("*********************");
        Console.WriteLine("Nossas funçoes;");
        Console.WriteLine("Consultar saldo, depositar e sacar");
        Console.WriteLine("**********************");


        //Instanciar um objeto


        Menu();
    }

        public static void Menu()
        {
            string titular = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente(titular,0);

       
        string opcao = "";
        do
         {
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "1":
                conta.ConsultarSaldo();
                Console.WriteLine("");
                break;
                case "2":
                conta.Depositar();
                break;
                case "3":
                conta.Sacar();

                break;
                case "4":
                Console.WriteLine("volte sempre!!!");
                Console.WriteLine("               ");
                System.Threading.Thread.Sleep(1000);
                break;

            }
    } while(opcao != "4");
}
}

            
            