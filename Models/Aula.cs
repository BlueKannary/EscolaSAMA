using System;
using System.Collections.Generic;

namespace EscolaSamaApp.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Aula(int id, string titulo, Professor professor)
        {
            Id = id;
            Titulo = titulo;
            Professor = professor;
            Alunos = new List<Aluno>();
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Aula: {Titulo}");
            Console.WriteLine($"Professor: {Professor?.Nome}");
            Console.WriteLine("Alunos:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($" - {aluno.Nome}");
            }
        }

    }
}
