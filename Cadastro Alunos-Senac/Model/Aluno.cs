using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Alunos_Senac.Model
{
    public class Aluno
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Curso { get; set; }

        public DateTime DataNascimento { get; set; }
        public Aluno(int id, string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Curso = curso;
            DataNascimento = dataNascimento;
        }
    }
}
