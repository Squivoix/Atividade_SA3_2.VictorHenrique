
namespace Atividade_2
{
	interface IDoadorMensal : IDoador
	{
		//Doa mensalmente
		void DoacaoMensal(Doacao d, Beneficiario b);
	}
}
