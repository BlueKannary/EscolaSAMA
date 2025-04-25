using System;
using EscolaSama.Models;

namespace EscolaSamaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando alunos
            var aluno1 = new Aluno(1, "João", 16);
            var aluno2 = new Aluno(2, "Maria", 17);

            // Criando professor
            var professor = new Professor(1, "Carlos", "Matemática");

            // Criando aula
            var aula = new Aula(1, "Álgebra Básica", professor);

            // Adicionando alunos
            aula.Alunos.Add(aluno1);
            aula.Alunos.Add(aluno2);

            // Exibindo informações
            aula.ExibirInfo();
        }
    }
}
