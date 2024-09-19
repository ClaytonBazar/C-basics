using System;

public class Estudante

{
    private long codigo;
    private String nome;
    private long numEstudante;
    private double nota1;
    private double nota2;
    private double media;
    public Estudante()
	{

	}

    public Estudante(long codigo, string nome, long numEstudante, double nota1, double nota2)
    {
        this.codigo = codigo;
        this.nome = nome;
        this.numEstudante = numEstudante;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.media = (this.nota1 + this.nota2) / 2;
    }

    public long getCodigo()
    {
        return this.codigo;
    }

    public void setCodigo( long codigo)
    {
        this.codigo = codigo;
    }

    public String getNome()
    {
        return this.nome;
    }

    public void setNome(String nome)
    {
        this.nome = nome;
    }

    public long getNumEstudante()
    {
        return numEstudante;
    }

    public void setNumEstudante(long numEstudante)
    {
        this.numEstudante = numEstudante;
    }

    public double getNota1()
    {
        return this.nota1;
    }
    public void setNota1(double nota1)
    {
        this.nota1 = nota1;
    }

    public double getNota2()
    {
        return this.nota2;
    }
    public void setNota2(double nota2)
    {
        this.nota2 = nota2;
    }

    public double getMedia()
    {
        return this.media;
    }
    public void setMedia(double media)
    {
        this.media = media;
    }

    private void calcularMedia()
    {
        this.media = (this.nota1 + this.nota2) / 2;
    }

    public String ToString()
    {
        return "Codigo: "+this.codigo +"Nome: "+ this.nome +"Nota 1: "+ this.nota1 +"Nota 2: "+ this.nota2 +"Media: "+ this.media;
    }
}
