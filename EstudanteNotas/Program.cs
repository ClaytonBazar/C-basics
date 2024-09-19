using System.Collections;
using EstudanteNotas.Model;
namespace EstudanteNotas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            do
            {
            ArrayList estudantes = new ArrayList();
            Console.WriteLine("1.Insira os dados do estudante");
            Console.WriteLine("2.Lista dos estudantes");
            Console.WriteLine("3.Nota Media da Turma");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma das opcoes");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        estudantes = Controller.PreencherListaEstudantes();
                        break;
                    case 2:
                        Controller.ImprimirListaEstudantes(estudantes);
                        break;
                    case 3:
                        Controller.NotaMediaDaTurma(estudantes);
                        break;
                    default:
                        Console.WriteLine("Opcao indisponivel");
                        break;
                }
            }
            while(Convert.ToInt32(Console.ReadLine()) != 0);
        }
    }
}
