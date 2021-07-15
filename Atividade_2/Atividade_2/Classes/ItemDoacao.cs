
namespace Atividade_2
{
	class ItemDoacao : IItemDoacao
	{
		string Nome;
		int Quantia;

		public ItemDoacao(string nome, int quantia)
		{
			Nome = nome;
			Quantia = quantia;
		}
	}
}
