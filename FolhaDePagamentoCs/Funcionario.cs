using System;

namespace FolhaDePagamentoCs
{
	public abstract class Funcionario : Cracha, IComparable<Funcionario>
	{
		private string nome;

		public Funcionario(string nome)
		{
			this.nome = nome;
		}

		public string GetNome()
		{
			return nome;
		}

		public abstract decimal GetSalario();

		public string GetLinha1()
		{
			return nome;
		}

		public abstract string GetLinha2();

		public int CompareTo(Funcionario o)
		{
			return this.nome.CompareTo(o.nome);
		}
	}
}
