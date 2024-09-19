using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha10_MetodoseClasses
{
    internal class Pessoa
    {
        private String nome;
        private int idade;
        private String sexo;
        private String estadoCivil;

        public Pessoa(string nome, int idade, String sexo, String estadoCivil)
        {
            this.nome = nome;
            this.idade = idade;

            if (sexo.ToUpper().Equals("F"))
            {
               this.sexo = "Femenino";
            }
            else if (sexo.ToUpper().Equals("M"))
            {
                 this.sexo = "Masculino";
            }

            if (estadoCivil.ToUpper().Equals("S"))
            {
                this.estadoCivil = "Solteiro(a)";
            }
            else if (estadoCivil.ToUpper().Equals("C"))
            {
                this.estadoCivil = "Casado(a)";
            }
            else if (estadoCivil.ToUpper().Equals("D"))
            {
                this.estadoCivil = "Divorciado(a)";
            }
            else if (estadoCivil.ToUpper().Equals("V"))
            {
                this.estadoCivil = "Viuvo(a)";
            }
        }

        public Pessoa()
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

        public String getSexo()
        {
            return this.sexo;
        }

        public void setSexo(String sexo)
        {
            if (sexo.ToUpper().Equals('F'))
            {
                this.sexo = "Femenino";
            }
            else if (sexo.Equals('M'))
            {
                this.sexo = "Masculino";
            }
        }

        public String getEstadoCivil()
        {
            return this.estadoCivil;
        }

        public void setEstadoCivil(String estadoCivil)
        {
            if (estadoCivil.ToUpper().Equals('S'))
            {
                this.estadoCivil = "Solteiro(a)";
            }
            else if (estadoCivil.Equals('C'))
            {
                this.estadoCivil = "Casado(a)";
            }
            else if (estadoCivil.Equals('D'))
            {
                this.estadoCivil = "Divorciado(a)";
            }
            else if (estadoCivil.Equals('V'))
            {
                this.estadoCivil = "Viuvo(a)";
            }
        }

      

       

        
        public String VizualizarPessoa()
        {
            return "Nome: " + this.nome + "\nIdade: " + this.idade + "\nSexo: " + this.sexo + "\nEstado Civil: "+this.estadoCivil;
        }

    }


}
