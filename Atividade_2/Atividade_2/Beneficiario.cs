
namespace Atividade_2
{
	class Beneficiario : IBeneficiario
	{
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }

		public void ReceberDoacao(Doacao doacao)
		{
			
		}
	}
}
