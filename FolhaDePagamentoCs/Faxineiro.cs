using System;

namespace FolhaDePagamentoCs
{
	public class Faxineiro : FuncionarioFixo
	{
		private string turno;

		public Faxineiro(string nome, decimal valor, string turno)
			: base(nome, valor)
		{
			this.turno = turno;
		}

		public override decimal GetSalario()
		{
			decimal adicional = 0;

			if (turno == "NOTURNO") {
				adicional = 0.05M * base.GetSalario();
			}

			return base.GetSalario() + adicional;
		}

		public override string GetLinha2()
		{
			return string.Format("Faxineiro {0}", turno.ToLower());
		}
	}
}
