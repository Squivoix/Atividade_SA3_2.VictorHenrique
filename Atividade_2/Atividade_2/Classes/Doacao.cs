using System;

namespace Atividade_2
{
	
	class Doacao : IDoacao
	{
		public int Id { get; set; }
		public DateTime DataDoacao { get; set; }
		public Pessoa Doador { get; set; }
		public Pessoa Beneficiario { get; set; }

		private static int TotalId = 1;

		public Doacao(DateTime data, Pessoa doador, Pessoa beneficiario)
		{
			Id = TotalId++;
			DataDoacao = data;
			Doador = doador;
			Beneficiario = beneficiario;
		}

	}
}
