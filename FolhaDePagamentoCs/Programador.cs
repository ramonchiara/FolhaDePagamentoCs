using System;

namespace FolhaDePagamentoCs
{
	public class Programador : FuncionarioHora
	{
		public Programador(string nome, decimal valor, double horas)
			: base(nome, valor, horas)
		{
			
		}

		public override string GetLinha2()
		{
			return "Programador";
		}
	}
}
