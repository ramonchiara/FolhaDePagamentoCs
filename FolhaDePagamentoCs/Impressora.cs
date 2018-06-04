using System;

namespace FolhaDePagamentoCs
{
	public class Impressora
	{
		public void Imprimir(Cracha cracha)
		{
			Console.WriteLine("+----------------------+");
			Console.WriteLine("| {0,20} |", cracha.GetLinha1());
			Console.WriteLine("| {0,20} |", cracha.GetLinha2());
			Console.WriteLine("+----------------------+");
		}
	}
}
