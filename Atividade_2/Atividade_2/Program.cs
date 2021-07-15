using System;

namespace Atividade_2
{
	class Program
	{
		static void Main()
		{
			int cod;

			Console.Write("Códigos:\n" +
				"1 - Cadastrar Pessoa Doadora.\n" +
				"2 - Cadastrar Pessoa Doadora Mensal.\n" +
				"3 - Cadastrar Pessoa Beneficiária.\n" +
				"4 - Mostrar Lista de Pessoas.\n" +
				"5 - Mostrar Lista de Doações.\n" +
				"6 - Realizar Doação.\n" +
				"9 - Sair do Programa.");

			do
			{
				Console.Write("Digite o número do código: "); while(!int.TryParse(Console.ReadLine(), out cod)) { Console.Write("Por favor, digite um número: "); }

				switch(cod)
				{
					case 1 : //Cadastrar Pessoa Doadora.
					{

						break;
					}

					case 2: //Cadastrar Pessoa Doadora Mensal.
					{

						break;
					}

					case 3: //Cadastrar Pessoa Beneficiária.
					{

						break;
					}

					case 4 : //Mostrar Lista de Pessoas.
					{

						break;
					}

					case 5 : //Mostrar Lista de Docações.
					{

						break;
					}

					case 6 : //Realizar Doação.
					{

						break;
					}

					case 9 : //Sair do programa
					{
						Console.WriteLine("Saido do programa...");
						break;
					}

					default : //Código não existe
					{
						Console.WriteLine("\nCódigo não existe!\n");
						break;
					}
				}
			} while(cod != 9);

		}
	}
}
