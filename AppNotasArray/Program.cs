using System.ComponentModel.DataAnnotations;

namespace AppNotasArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inserir a capacidade do array via teclado
            Console.WriteLine("Insira o numero de alunos que deseja inserir");

            String num = Console.ReadLine();
            int n = int.Parse(num);
            //declarar o array
            double[] notas = new double[n];
            //declaracao de variaveis
            double soma = 0;
            double media = 0;
            double Notamaior = notas[0];
            //Inserir as notas no sistema
            for (int i = 0; i < n; i++)
            {
                //Validar as notas inseridas
                if ((notas[i] >= 0) || (notas[i] <= 20))
                {
                    Console.WriteLine("Insira as notas desejadas");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("As notas inseridas nao respeitam as delimitacoes predifinidas");
                    break;
                }
                    //somar as notas
                    soma += notas[i];
                    media = soma / notas.Length;

                    if (notas[i] > Notamaior)
                    {
                        Notamaior = notas[i];

                    }

            }


            //Imprimir a soma e a media
            Console.WriteLine($"O valor da soma das notas inseridas é de {soma}");
            Console.WriteLine($"A media das notas é de {media}");

            //Imprimir a nota maxima
            Console.WriteLine($"A maior nota inserida é  {Notamaior}");
        }
    }
}
