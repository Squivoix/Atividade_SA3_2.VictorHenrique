
namespace Atividade_2
{
	class Beneficiario : IBeneficiario
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }

		public Beneficiario(string nome, string cpf, string endereco, string telefone)
		{
			Nome = nome;
			CPF = cpf;
			Endereco = endereco;
			Telefone = telefone;
		}

		public void ReceberDoacao(Doacao doacao)
		{
			//Recebe a doação
		}
	}
}
