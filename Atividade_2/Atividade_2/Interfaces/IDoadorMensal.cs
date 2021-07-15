
namespace Atividade_2
{
	interface IDoadorMensal : IDoador
	{
		//Doa mensalmente
		void DoacaoMensal(Doacao doacao, Beneficiario beneficiario);
	}
}
