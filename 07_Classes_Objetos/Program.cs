//Sempre que formos utilizar bibliotecas ou classes já criadas 
//impostamos ela com o using 
using Sesi.Model;
class Program
{
    public static void Main()
    {
       //Criando uma variavel aluno1 e instanciando  da classe Aluno
       //Ou seja, estamos um valor tamos criando nosso objeto
       var aluno1 = new Aluno();
       //Atribuindo  um valor ao atributo nome do aluno1
       aluno1.nome = "Maria Eduarda " ;
       aluno1.idade = 17;
       aluno1.turma = "2 EM";
       //Chmanado o metodo da classes Aluno
       aluno1.Apresentar();
       Aluno1.Apresentar();
    Aluno1.ResumirFaltas();
    Aluno1.AdicionarFaltas(10);
    Aluno1.ResumirFaltas();
    Aluno1.AdicionarFaltas(7);
    Aluno1.ResumirFaltas();
    }
}
