
namespace Atividade_2
{
	interface IBeneficiario : IPessoa
	{
		//Alguém que recebe uma doação
		void ReceberDoacao(Doacao doacao);
	}
}
