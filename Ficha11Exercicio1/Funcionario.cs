using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha11Exercicio1
{
    internal class Funcionario

    {
        private String nome;
        private int idade;
        private double salario;
        private float tempoTrabalho;
        private int diasTrabalho;
        public static int numfunc;

        public Funcionario(string nome, int idade, double salario, float tempoTrabalho, int diasTrabalho)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.tempoTrabalho = tempoTrabalho;
            this.diasTrabalho = diasTrabalho;
            numfunc++;
        }

        public Funcionario()
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

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public float getTempoTrabalho()
        {
            return this.tempoTrabalho;
        }

        public void setTempoTrabalho(float tempoTrabalho)
        {
            this.tempoTrabalho = tempoTrabalho;
        }

        public int getdiasTrabalho()
        {
            return this.diasTrabalho;
        }

        public void setDiasTrabalho(int diasTrabalho)
        {
            this.diasTrabalho = diasTrabalho;
        }


        public String toString()
        {
            return "Nome:"+ this.nome + "\n" + "Idade:" + this.idade + "\n" + "Salario:" +this.salario +"\n" +"Tempo de Trabalho:" +this.tempoTrabalho +"\n" +"Dias de Trabalho:" +this.diasTrabalho +"\n";
        }

        public override bool Equals(object? obj)
        {
            return obj is Funcionario funcionario &&
                   nome == funcionario.nome;
        }
        public static double Salario(int diasTrabalho, double tempoTrabalho)
        {
            return (diasTrabalho * tempoTrabalho);
        }

    }
}
