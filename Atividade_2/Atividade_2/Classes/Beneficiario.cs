using System;

namespace Atividade_2
{
	class Beneficiario : Pessoa, IBeneficiario
	{
		public Beneficiario(string nome, string cpf, string endereco, string telefone, DateTime data) : base(nome, cpf, endereco, telefone, data) { }

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
