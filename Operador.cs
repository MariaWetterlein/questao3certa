using System;

namespace Funcionario;
class Operador : Funcionario
 
 
{
	public Operador(string nome, double salarioBase, string cargo) : base(nome, salarioBase, cargo) {}
}
public override double CalcularSalario()
	{
		return SalarioBase;
	}

	public override void RegistrarPonto()
	{
		Console.WriteLine($"{Nome} (Operador) registrou o ponto.");
	}
