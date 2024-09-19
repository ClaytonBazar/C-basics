namespace Notas_dos_Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Digite a primeira nota:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a Segunda nota:");
                double nota2 = double.Parse(Console.ReadLine());

                if ((nota1 > 0) && (nota1 <= 20) && (nota2 > 0) && (nota2 <= 20))
                {
                    double media = (nota1 + nota2) / 2;
                    Console.WriteLine("O valor da media e " + media);
                }
                else
                {
                    Console.WriteLine("Introduza valores no intervalo de 0 a 20");
                    continue;
                }
                i++;
            } while (i < 20);
        }
    }
}
