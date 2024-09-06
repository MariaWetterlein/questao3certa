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

	 public abstract double CalcularSalario();
		 public abstract void RegistarPonto();
}		 