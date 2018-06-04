using System;
using System.Collections.Generic;

namespace FolhaDePagamentoCs
{
	public class OrdenaPorSalario : IComparer<Funcionario>
	{
		public int Compare(Funcionario o1, Funcionario o2)
		{
			return (int)(o1.GetSalario() - o2.GetSalario());
		}
	}
}
