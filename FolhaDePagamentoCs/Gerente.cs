using System;

namespace FolhaDePagamentoCs
{
	public class Gerente : FuncionarioHora
	{
		private decimal bonus;

		public Gerente(string nome, double horas, decimal bonus)
			: base(nome, 100, horas)
		{
			
			this.bonus = bonus;
		}

		public override decimal GetSalario()
		{
			return base.GetSalario() + bonus;
		}
	}
}
