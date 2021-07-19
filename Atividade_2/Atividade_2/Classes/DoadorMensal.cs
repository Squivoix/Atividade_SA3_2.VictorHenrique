using System;

namespace Atividade_2
{
	class DoadorMensal : Doador, IDoadorMensal
	{
		private DateTime dataCadastro;

		public DoadorMensal(string nome, string cpf, string endereco, string telefone, DateTime data) : base(nome, cpf, endereco, telefone) 
		{
			dataCadastro = data;
		}

		/// <summary>
		/// Doação mensal.
		/// </summary>
		/// <param name="doacao">A doação a ser feita.</param>
		/// <param name="beneficiario">O beneficiário que receberá.</param>
		public void DoacaoMensal(Doacao d, Beneficiario b)
		{
			/*
			Se a diferença da data atual com a data de cadastro for múltipla de 30 dias,
			significa que um mês se passou desde o último dia, ou o dia do cadastro.
			Então realiza a doação.
			*/
			if((DateTime.Now - dataCadastro).Days % 30 == 0)
			{
				Doar(d, b);
			}
		}
	}
}
