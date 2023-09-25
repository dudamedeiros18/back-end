using System.Collections.Generic;
using Ssei.Models;
public class Program
  {
    public static void Main()
    {
      //Criando um lista de inteiros
      List<int> listaNumeros = new List<int>();
      
      //Adicionando elelmentos á lista
      listaNumeros.Add(10); // posição [0]
      listaNumeros.Add(20); // posição [1]
      listaNumeros.Add(45); // posição [2]
      
      //Acessando os dados da lista pelo índice
      Console.WriteLine(listaNumeros[2]);

      //Contagem de elementos
      Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

      listaNumeros.Add(55); // posição [3]
      Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

      List<string> listaNomes = new List<string>();
      listaNomes.Add("helena");
      listaNomes.Add("agata");
      listaNomes.Add("maria alice");

      Console.WriteLine(listaNomes[0]);

      Console.WriteLine($" Neste momento temos {listaNomes.Count} adicionada");
      Console.WriteLine("**********************");

      //Criando uma lista de numeros já atribuindo valores
      List<int> numeros = new List<int> {1, 2, 5, 6, 8, 9 };
      Console.WriteLine($"Quantidade de elementos na lista de numeros: {numeros.Count}");
      numeros.Remove(2); // Remover o elementos 2
      numeros.RemoveAt(1); //Remover o elemento do indice 1
      numeros.RemoveRange(2,2); // Remover 2 e elementos a partir do indice 2
      
      //Substituindo informações do item da lista
      numeros[0] = 100;

      //Iterando sobre todos os itens da lista
      foreach(int numero in numeros)
      {
        Console.WriteLine(item);
      }
       foreach(string item in listaNomes)
       {
        Console.WriteLine(item)
       }

       //Criando uma lista com objetos da Classe Aluno
       listaNomes<Aluno> listaAlunos = new list<Aluno>();

       //Adicionando um novo aluno á minha lista
       Aluno novoAluno = new listaAlunos ("Pedro", 16);
       listaAlunos.Add(novoAluno);

       listaAlunos.Add(new Aluno("Patricia", 17));
       listaAlunos.Add(new Aluno("Bob", 17));

       //Exibindo lista de alunos
       Console.WriteLine("Lista alunos:");
       foreach(T item in listaAlunos)
       {
         Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
       }

       //Criando uma noba lista, ordenando por nome
       var ordenaçao = from aluno in listaAlunos
                       where aluno.idade = 17
                       orderby aluno.nome
                       select aluno.nome;

        foreach (var aluno in ordenaçao)
        Console.WriteLine(aluno)





      


    }
}
