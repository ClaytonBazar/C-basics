using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudanteNotas.Model;

namespace EstudanteNotas
{
    public class Controller
    {
        Estudante estudante = new Estudante();
        public static ArrayList PreencherListaEstudantes()
        {

            Console.WriteLine("Digite a capacidade do array");
            int capacidade = int.Parse(Console.ReadLine());
            ArrayList estudantes = new ArrayList();

            for (int i = 0; i < capacidade; i++)
            {
                Console.WriteLine("Codigo: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Sexo: ");
                string sexo = Console.ReadLine();
                Console.WriteLine("curso: ");
                string curso = Console.ReadLine();
                Console.WriteLine("Digite a primeira nota: ");
                double teste1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a Segunda nota: ");
                double teste2 = double.Parse(Console.ReadLine());
                estudantes.Add(new Estudante(codigo, nome, sexo, curso, teste1, teste2));
            }
            return estudantes;
        }

        public static void ImprimirListaEstudantes(ArrayList estudantes)
        {
            foreach (Estudante estudante in estudantes)
            {
                Console.WriteLine(estudante.toString());
            }
        }

        public static double NotaMediaDaTurma(ArrayList estudantes)
        {
            double soma = 0;
            foreach (Estudante estudante in estudantes)
            {
                soma += estudante.calcularMedia();
            }
            return soma / estudantes.Count;
        }

        public static void RetornarAgrupado(ArrayList estudantes)
        {
            double media = estudante.calcularMedia();
            if (media >= 14 && media <=20)
            {

            }
        }

    }
}
