namespace Models{
    public class Pessoa{
        private string nome { get; set;}
        private int idade { get; set;}
        private int email {get; set;}
        private int anoNascimento {get; set;}
        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa){
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.mail = emailPessoa;
            this.anoNascimento = 2023 - idade;
        }
        public void Cantar(){
            Console.WriteLine($"{nome} está cantando")
        }
        public void Informacoes
    }
}