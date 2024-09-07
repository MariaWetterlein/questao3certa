
using System;
namespace Funcionario;
class Program
{
	static void Main(string[] args)
	{
		Funcionario gerente = new Gerente("João", 3000);
		Funcionario operador = new Operador("Maria", 1500);

		Console.WriteLine($"{gerente.Nome} - Salário: {gerente.CalcularSalario()}");
		gerente.RegistrarPonto();

		Console.WriteLine($"{operador.Nome} - Salário: {operador.CalcularSalario()}");
		operador.RegistrarPonto();
	}
}
