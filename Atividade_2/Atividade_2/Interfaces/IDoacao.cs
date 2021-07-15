using System;

namespace Atividade_2
{
	interface IDoacao
	{
		//Uma doação
		int Id { get; set; }
		DateTime DataDoacao { get; set; }
		Pessoa Doador { get; set; }
		Pessoa Beneficiario { get; set; }
		ItemDoacao ItemDoacao { get; set; }
	}
}
