
namespace Atividade_2
{
	class Doador : Pessoa, IDoador
	{

		public Doador(string nome, string cpf, string endereco, string telefone) : base(nome, cpf, endereco, telefone) { }

		/// <summary>
		/// Doar alguma coisa para um certo beneficiário.
		/// </summary>
		/// <param name="doacao">A doação a ser feita.</param>
		/// <param name="beneficiario">O beneficiário que receberá.</param>
		public void Doar(Doacao d, Beneficiario b)
		{
			b.ReceberDoacao(d);
		}
	}
}
