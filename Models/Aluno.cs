namespace EscolaSama.Models
{
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void ExibirInfo()
    {
        Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}");
    }
}

}