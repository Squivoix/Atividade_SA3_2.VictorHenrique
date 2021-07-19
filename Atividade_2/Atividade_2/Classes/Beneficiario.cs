
namespace Atividade_2
{
	class Beneficiario : Pessoa, IBeneficiario
	{
		public Beneficiario(string nome, string cpf, string endereco, string telefone) : base(nome, cpf, endereco, telefone) { }

		/// <summary>
		/// Receber uma doação.
		/// </summary>
		/// <param name="doacao">A doação a ser doada.</param>
		public void ReceberDoacao(Doacao d)
		{
			//Recebe a doação
		}
	}
}
