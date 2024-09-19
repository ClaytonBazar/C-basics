using System;

public class Funcionario
{
	private long codigo;
	private string nome;
	private int diasTrabalhados;
	private double sadarioDiario;
	private double salarioMensal;

    public Funcionario()
    {
    }

    public Funcionario(long codigo, string nome, int diasTrabalhados, double sadarioDiario)
    {
        this.codigo = codigo;
        this.nome = nome;
        this.diasTrabalhados = diasTrabalhados;
        this.sadarioDiario = sadarioDiario;
        this.salarioMensal = this.sadarioDiario * this.diasTrabalhados;
    }

    public long Codigo{ get; set; }
    public string Nome{ get; set; }
    public int DiasTrabalhados{ get; set; }
    public double SalarioDiario{ get; set; }
    public double SalarioMensal{ get; set; }

    private void calcularSalario()
    {
        this.salarioMensal = this.SalarioDiario * this.diasTrabalhados;
    }

}
