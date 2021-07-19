using System;

namespace Atividade_2
{
	abstract class Pessoa : IPessoa
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public DateTime DataCadastro { get; set; }

		protected Pessoa(string nome, string cpf, string endereco, string telefone, DateTime data)
		{
			Nome = nome;
			CPF = cpf;
			Endereco = endereco;
			Telefone = telefone;
			DataCadastro = data;
		}
	}
}
