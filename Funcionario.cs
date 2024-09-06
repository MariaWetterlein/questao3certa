using System;

namespace Funcionario;

abstract class Funcionario 
{
	public string Nome { get; set; }
	public double SalarioBase { get; set; }

	public Funcionario(string nome, double salarioBase)
	{
		Nome = nome;
		SalarioBase = salarioBase;
	}
}