public class Program
{
    public static void Main(){
        //Criando uma anonima (classe sem definição in)
        var pessoa1 = new {
            nome = "João",
            idade = 17

        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br",
        };
        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade}");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e tem {pessoa2.email}");

        //pessoa1.nome = "Duda";

        //Criar 2 objetos de classe anonima de Carron

        var carro1 = new{
            marca = "jeep",
            modelo = "Wrangler",
            ano = 2017
        };
        var carro2 = new{
        marca = "chevrolet",
        modelo = "camaro",
        ano = 2014
        };

        Console.WriteLine($"o carro da marca {carro1.marca} tem o modelo {carro1.modelo} e é do ano{carro1.ano}");
        Console.WriteLine($"o carro da marca {carro2.marca} tem o modelo {carro2.modelo} e é do ano{carro2.ano}");
}
}
