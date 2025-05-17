using Cadastro_Alunos_Senac.Controller;

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
                        //case 2: ListarAluno(); break;
                        //case 3: AtualizarAluno(); break;
                        //case 4: ExcluirAluno(); break;
                }
                Console.WriteLine("\nPressione Enter para Continuar...");
                Console.ReadLine();

            } while (opcao != 0);
        }
        private void CadastrarAluno(){
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("cpf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine("Data de Nascimento:  dd/mm/aaaa");
            DateTime data = DateTime.Parse(Console.ReadLine());

            controller.CadastrarAluno(nome, cpf, curso, data);
            Console.WriteLine("Aluno Cadastrado com sucesso ");
        }
    }
}
