namespace Ficha10_MetodoseClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pes = new Pessoa("Nome",18,"m","d");
            Console.WriteLine(pes.VizualizarPessoa());
        }
    }
}
