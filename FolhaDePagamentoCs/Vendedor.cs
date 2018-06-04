using System;

namespace FolhaDePagamentoCs
{
	public class Vendedor : FuncionarioFixo
	{
		private decimal vendas;

		public Vendedor(string nome, decimal vendas)
			: base(nome, 2000)
		{
			this.vendas = vendas;
		}

		public override decimal GetSalario()
		{
			return base.GetSalario() + 0.1M * vendas;
		}

		public override string GetLinha2()
		{
			return "Vendedor";
		}
	}
}
