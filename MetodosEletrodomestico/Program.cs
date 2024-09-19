namespace MetodosEletrodomestico
{
    internal class Program
    {
        static void Main(string[] args)
        {    
                Console.WriteLine("Insira o nome do Eletrodomestico");
                String nome = Console.ReadLine();

                Console.WriteLine("Insira a marca do Eletrodomestico");
                String marca = Console.ReadLine();

                Console.WriteLine("Insira o ano de fabrico do Eletrodomestico");
                int anoFabrico= Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Insira o preco do Eletrodomestico");
                double preco = Convert.ToDouble(Console.ReadLine());


           

            Eletrodomestico elet1 = new Eletrodomestico("Fogao Eletrico", "Defy", 2020, 3000);
                Eletrodomestico elet2 = new Eletrodomestico();
                Eletrodomestico elet3 = new Eletrodomestico(nome, marca, anoFabrico, preco);
                Eletrodomestico elet4 = new Eletrodomestico();
            
                elet2.setNome("Tostadeira");
                elet2.setMarca("Philips");
                elet2.setAnoFabrico(2012);
                elet2.setPreco(1800);

            Console.WriteLine("Insira o nome do Eletrodomestico");
            String nome2 = Console.ReadLine();

            Console.WriteLine("Insira a marca do Eletrodomestico");
            String marca2 = Console.ReadLine();

            Console.WriteLine("Insira o ano de fabrico do Eletrodomestico");
            int anoFabrico2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insira o preco do Eletrodomestico");
            double preco2 = Convert.ToDouble(Console.ReadLine());

            elet4.setNome(nome2);
                elet4.setMarca(marca2);
                elet4.setAnoFabrico(anoFabrico2);
                elet4.setPreco(preco2);
            
                Console.WriteLine(elet1.vizualizarEletrodomestico());
                Console.WriteLine(elet2.vizualizarEletrodomestico());
                Console.WriteLine(elet3.vizualizarEletrodomestico());
                Console.WriteLine(elet4.vizualizarEletrodomestico());
           
        }
    }
}
