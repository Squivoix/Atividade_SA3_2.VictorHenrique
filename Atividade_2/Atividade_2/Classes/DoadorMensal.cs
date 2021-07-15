
namespace Atividade_2
{
	class DoadorMensal : Doador, IDoadorMensal
	{
		public DoadorMensal(string nome, string cpf, string endereco, string telefone) : base(nome, cpf, endereco, telefone) { }

		public void DoacaoMensal(Doacao doacao, Beneficiario beneficiario)
		{
			Doar(doacao, beneficiario);
		}
	}
}
