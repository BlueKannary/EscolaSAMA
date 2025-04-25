using System;

namespace EscolaSama.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        public Professor(int id, string nome, string disciplina)
        {
            Id = id;
            Nome = nome;
            Disciplina = disciplina;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Professor: {Nome}, Disciplina: {Disciplina}");
        }
    }
}
