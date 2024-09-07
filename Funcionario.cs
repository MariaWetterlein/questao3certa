using System;

namespace Funcionario;

abstract class Funcionario 
{
	public string Nome { get; set; }
	public string Cargo { get; set; }
	public double SalarioBase { get; set; }

	public Funcionario(string nome, double salarioBase, string cargo)
	{
		Nome = nome;
		SalarioBase = salarioBase;
		Cargo = cargo;
		
	}

	 public abstract double CalcularSalario();
		 public abstract void RegistrarPonto();
}		 