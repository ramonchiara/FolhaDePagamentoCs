using System;
using System.Collections.Generic;

namespace FolhaDePagamentoCs
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<Funcionario> funcionarios = new List<Funcionario>();

			funcionarios.Add(new Gerente("Maria", 160, 1000));
			funcionarios.Add(new ProgramadorJr("José", 176));
			funcionarios.Add(new ProgramadorPl("Augusto", 160));
			funcionarios.Add(new ProgramadorSr("Alice", 128));
			funcionarios.Add(new Vendedor("Thiago", 10000));
			funcionarios.Add(new Faxineiro("Ana", 720, "DIURNO"));
			funcionarios.Add(new Faxineiro("João", 680, "NOTURNO"));

			Console.Write("Ordenar por (N)ome ou (S)alário? ");
			string opcao = Console.ReadLine();
			switch (opcao) {
			case "n":
			case "N":
				funcionarios.Sort();
				break;
			case "s":
			case "S":
				funcionarios.Sort(new OrdenaPorSalario());
				break;
			}

			decimal total = 0;
			foreach (Funcionario f in funcionarios) {
				Console.WriteLine("{0,-10} {1,8:F2}", f.GetNome(), f.GetSalario());
				total += f.GetSalario();
			}
			Console.WriteLine("-------------------");
			Console.WriteLine("{0,-10} {1,8:F2}", "Total", total);
		}
	}
}
