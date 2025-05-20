using Cadastro_Alunos_Senac.Controller;
using Cadastro_Alunos_Senac.Model;

// control r g limpa tudo que vc n ta usando
namespace Cadastro_Alunos_Senac.View
{
    public class AlunoView
    {
        private AlunoController controller = new();

        public void MostrarMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("=== Cadastro do Aluno no Senac ===");
                Console.WriteLine("1 - cadastrar Aluno");
                Console.WriteLine("2 - Listar Alunos");
                Console.WriteLine("3 - Atualizar alunos");
                Console.WriteLine("4 - Excluir Alunos");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opcao: ");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1: CadastrarAluno(); break;
                    case 2: ListarAlunos(); break;
                    case 3: AtualizarAluno(); break;
                    case 4: ExcluirAluno(); break;
                }
                Console.WriteLine("\nPressione Enter para Continuar...");
                Console.ReadLine();

            } while (opcao != 0);
        }


        private void CadastrarAluno(){
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();//mesmo que leia 
            Console.WriteLine("cpf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Data de Nascimento:  dd/mm/aaaa");
            DateTime data = DateTime.Parse(Console.ReadLine());

            controller.CadastrarAluno(nome, cpf, curso, data);
            Console.WriteLine("Aluno Cadastrado com sucesso ");
        }

        private void ListarAlunos()
        {
            List<Aluno> alunos = controller.ListarAlunos();
            Console.WriteLine("\n Lista de Alunos: ");
            foreach(var aluno in alunos)
            {
                Console.WriteLine($"ID: {aluno.Id} | Nome: {aluno.Nome} | CPF: {aluno.Cpf} | Curso: {aluno.Curso} | Data de Nascimento: {aluno.DataNascimento}");
            }
        }

        public void AtualizarAluno() {

            Console.WriteLine("Digite o id do aluno a ser atualizado");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Novo nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Novo cpf: ");
            string cpf  = Console.ReadLine();

            Console.WriteLine("Novo curso: ");
            string curso = Console.ReadLine();

            Console.WriteLine("Novo data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            bool atualizado = controller.AtualizarAluno(id, nome, cpf, curso, data);
            Console.WriteLine(atualizado? "Aluno Cadastrado com sucesso!" : "Aluno não encontrado!");
        }

        public void ExcluirAluno()
        {
            Console.WriteLine("Digite o Id do aluno a ser excluido");
            int id = int.Parse(Console.ReadLine());

            bool excluido = controller.ExcluirAluno(id);
            Console.WriteLine(excluido ? "Aluno excluido com sucesso" : "Aluno não excluido, ou não encontrado " );
        }
    }
}
