namespace MetodosEletrodomestico
{
    internal class Eletrodomestico
    {
        private String nome;
        private String marca;
        private int anoFabrico;
        private double preco;

        public Eletrodomestico(String nome, String marca, int ano, double preco)
        {
            this.nome = nome;
            this.marca = marca;
            this.anoFabrico = ano;
            this.preco = preco;
        }

        public Eletrodomestico()
        {
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getMarca()
        {
            return this.marca;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public int getAnoFabrico()
        {
            return this.anoFabrico;
        }

        public void setAnoFabrico(int ano)
        {
            this.anoFabrico = ano;
        }

        public Double getPreco()
        {
            return this.preco;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public String vizualizarEletrodomestico()
        {
            return "\nNome: " + this.nome + "\nMarca: " + this.marca + "\nAno de Fabrico: " + this.anoFabrico + "\nPreco: " + this.preco;
        }
    }
}
