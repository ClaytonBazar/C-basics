namespace Ficha11Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario("Clayton", 20, 15000, 8, 200);
            Funcionario func2 = new Funcionario("Hercio", 19, 14000, 12, 150);
            Console.WriteLine(func.toString());

            Boolean igual = func.Equals(func2);

            Console.WriteLine(igual);
            int totFunc = Funcionario.numfunc;
            Console.WriteLine("NUmero total de Funcionarios "+totFunc);

            Console.WriteLine(func2.toString());
            double salarioBonus =  Funcionario.Salario(12, 150);
            double salario = func.getSalario();
            double salarioTot = salarioBonus + salario;
            Console.WriteLine("O salario total apos os bonus é de: " + salarioTot);

        }
    }
}
