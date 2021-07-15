
namespace Atividade_2
{
	class Doador : IDoador
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }

		public Doador(string nome, string cpf, string endereco, string telefone)
		{
			Nome = nome;
			CPF = cpf;
			Endereco = endereco;
			Telefone = telefone;
		}

		public void Doar(Doacao doacao, Beneficiario beneficiario)
		{
			beneficiario.ReceberDoacao(doacao);
		}
	}
}
