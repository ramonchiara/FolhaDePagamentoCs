using System;

namespace FolhaDePagamentoCs
{
	public abstract class FuncionarioHora : Funcionario
	{
		private decimal valor;
		private double horas;

		public FuncionarioHora(string nome, decimal valor, double horas)
			: base(nome)
		{
			this.valor = valor;
			this.horas = horas;
		}

		public override decimal GetSalario()
		{
			return Convert.ToDecimal(horas) * valor;
		}
	}
}
