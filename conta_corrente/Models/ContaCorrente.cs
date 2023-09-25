namespace Models{
    public class ContaCorrente{
        private string titular { get; set;}
        private double saldo { get; set; }

        public ContaCorrente (string titularNome, int saldoConta){
            this.titular = titularNome;
            this.saldo = saldoConta;
        }
        public void ConsultarSaldo(){
            Console.WriteLine($"Seu saldo é de R${saldo}");
        }
        public void Depositar(){
           Console.WriteLine("Digite o valor do depósito:");
           double valor = double.Parse(Console.ReadLine());
           if(valor > 0){
            saldo += valor;
            Console.WriteLine("valor depositado com sucesso!");
           }
           else{
            Console.WriteLine("valor inválido");
           }
        }
        public void Sacar(){
         Console.WriteLine("Digite o valor do saque:");
           double valor = double.Parse(Console.ReadLine());
           if(valor > 0){
            saldo -= valor;
            Console.WriteLine("valor sacado com sucesso!");
           }
           else{
            Console.WriteLine("valor inválido");  
        }
    }
}
}