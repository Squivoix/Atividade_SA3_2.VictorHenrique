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
						/*string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaDoadora(nome, cpf, endereco, telefone);*/
						Menu.CadastrarPessoaDoadora("Victor", "047.902.671", "Rua Machado de Assis", "(43) 9");
						Menu.CadastrarPessoaDoadora("Ana", "047.905", "Rua Diacuí", "(43) 9 9822");
						Menu.CadastrarPessoaDoadoraMensal("Lais Vieira", "000", "Rua 10 de Dezembro", "+55 (43) 9 9615-7624");
						Menu.CadastrarPessoaDoadoraMensal("Patrich Dal Magro", "9", "Rua Lamborghini", "9 9615-7628");
						break;
					}

					case 2: //Cadastrar Pessoa Doadora Mensal.
					{
						/*string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaDoadoraMensal(nome, cpf, endereco, telefone);*/
						break;
					}

					case 3: //Cadastrar Pessoa Beneficiária.
					{
						/*string nome, cpf, endereco, telefone;

						Console.Write("\nDigite o Nome da Pessoa: "); nome = Console.ReadLine();
						Console.Write("Digite o CPF da Pessoa: "); cpf = Console.ReadLine();
						Console.Write("Digite o Endereço da Pessoa: "); endereco = Console.ReadLine();
						Console.Write("Digite o Telefone da Pessoa: "); telefone = Console.ReadLine();

						Menu.CadastrarPessoaBeneficiaria(nome, cpf, endereco, telefone);*/
						Menu.CadastrarPessoaBeneficiaria("Victor Henrique Dal Magro", "147.902.671-80", "Rua Diacuí, 222", "(43) 9 8476-0031");
						Menu.CadastrarPessoaBeneficiaria("Ana Beatriz Dal Magro", "147.905.999-80", "Rua Diacuí, 222", "(43) 9 9822-4910");
						Menu.CadastrarPessoaBeneficiaria("Lais Vieira dos Santos", "100.111.222-33", "Rua Diacuí, 222", "(43) 9 9615-7624");
						Menu.CadastrarPessoaBeneficiaria("Patrich Dal Magro", "199.888.777-66", "Rua Diacuí, 222", "(43) 9 9615-7628");
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
						Menu.RealizarDoacao(Menu.c1.Doadores[0], Menu.c1.Beneficiarios[0]);
						Menu.RealizarDoacao(Menu.c1.Doadores[1], Menu.c1.Beneficiarios[1]);
						Menu.RealizarDoacao(Menu.c1.Doadores[2], Menu.c1.Beneficiarios[2]);
						Menu.RealizarDoacao(Menu.c1.Doadores[3], Menu.c1.Beneficiarios[3]);
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
