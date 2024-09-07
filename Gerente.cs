using System;
namespace Funcionario;
class Gerente : Funcionario
{
	public Gerente(string nome, double salarioBase, string cargo) : base(nome, salarioBase, cargo) { }
}
public override double CalcularSalario()
	{
		
		return SalarioBase + 500;
	}

	public override void RegistrarPonto()
	{
		
		
		Console.WriteLine($"{Nome} (Gerente) registrou ponto");
	}
