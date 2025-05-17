using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Alunos_Senac.Model;

namespace Cadastro_Alunos_Senac.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos = new();
        private int proximoId = 1;

        public void CadastrarAluno(string nome, string cpf, string curso, DateTime dataNascimento)
        {

            Aluno novoAluno = new(proximoId++, nome, cpf, curso, dataNascimento);
            alunos.Add(novoAluno);

        }


    }
}
