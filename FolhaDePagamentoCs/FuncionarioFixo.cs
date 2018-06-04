using System;

namespace FolhaDePagamentoCs
{
	public abstract class FuncionarioFixo : Funcionario
	{
		private decimal valor;

		public FuncionarioFixo(string nome, decimal valor)
			: base(nome)
		{
			this.valor = valor;
		}

		public override decimal GetSalario()
		{
			return valor;
		}
	}
}
