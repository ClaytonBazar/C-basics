using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudanteNotas.Model
{
    public class Estudante
    {
        private int codigo;
        private string nome, sexo, curso;
        private double teste1, teste2;

        public Estudante(int codigo, string nome, string sexo, string curso, double teste1, double teste2)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.sexo = sexo;
            this.curso = curso;
            this.teste1 = teste1;
            this.teste2 = teste2;
        }

        public Estudante()
        {
        }

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getSexo()
        {
            return sexo;
        }
        public void setCSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string getCurso()
        {
            return curso;
        }
        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public double getTeste1()
        {
            return teste1;
        }
        public void setTeste1(int teste1)
        {
            this.teste1 = teste1;
        }

        public double getTeste2()
        {
            return teste2;
        }
        public void setTeste2(int teste2)
        {
            this.teste2 = teste2;
        }

        public double calcularMedia()
        {
            return (teste1 + teste2) / 2;
        }

        public string toString()
        {
            return codigo + " - " + nome + " - " + sexo + " - " + curso + " - " + teste1 + " - " + teste2 + " - " + calcularMedia();
        }
    }
}
