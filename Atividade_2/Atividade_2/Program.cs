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
				"4 - Mostrar Lista de Doadores.\n" +
				"5 - Mostrar Lista de Beneficiários.\n" +
				"6 - Mostrar Lista de Doações.\n" +
				"7 - Realizar Doação.\n" +
				"9 - Sair do Programa.\n");

			do
			{
				Console.Write("\nDigite o número do código: "); while(!int.TryParse(Console.ReadLine(), out cod)) { Console.Write("Por favor, digite um número: "); }

				switch(cod)
				{
					case 1 : //Cadastrar Pessoa Doadora.
					{
						string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaDoadora(nome, cpf, endereco, telefone);
						break;
					}

					case 2: //Cadastrar Pessoa Doadora Mensal.
					{
						string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaDoadoraMensal(nome, cpf, endereco, telefone);
						break;
					}

					case 3: //Cadastrar Pessoa Beneficiária.
					{
						string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaBeneficiaria(nome, cpf, endereco, telefone);
						break;
					}

					case 4 : //Mostrar Lista de Doadores.
					{
						Menu.MostrarListaDeDoadores();
						break;
					}

					case 5 : //Mostrar Lista de Beneficários.
					{
						Menu.MostrarListaDeBeneficiarios();
						break;
					}

					case 6: //Mostrar Lista de Doações, com ou sem data específica.
					{
						Menu.MostrarListaDeDoacoes();
						break;
					}

					case 7 : //Realizar Doações.
					{
						string cpfDoador, cpfBene;

						Console.Write("\nDigite o CPF do/a Doador/a: "); cpfDoador = Console.ReadLine();
						Console.Write("\nDigite o CPF do/a Beneficiário/a: "); cpfBene = Console.ReadLine();

						Menu.RealizarDoacao(cpfDoador, cpfBene);
						break;
					}

					case 9 : //Sair do programa
					{
						Console.WriteLine("Saido do programa...");
						break;
					}

					default : //Código não existe
					{
						Console.WriteLine("\nCódigo não existe!");
						break;
					}
				}
			} while(cod != 9);

		}
	}
}
