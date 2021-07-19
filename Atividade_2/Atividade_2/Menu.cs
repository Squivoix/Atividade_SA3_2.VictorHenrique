using System;
using System.Collections.Generic;

namespace Atividade_2
{
	static class Menu
	{
		public static Cadastro c1 = new Cadastro();

		//Cadastro de pessoa beneficiária.
		public static void CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone)
		{
			if(c1.CadastrarPessoaBeneficiaria(nome, cpf, endereco, telefone))
			{
				Console.WriteLine($"Cadastro de beneficiário/a {nome} realizado com sucesso!");
			} else
			{
				Console.WriteLine($"O CPF: {cpf}, já consta na lista de doadores ou beneficiários!");
			}
		}

		//Cadastro de pessoa doadora.
		public static void CadastrarPessoaDoadora(string nome, string cpf, string endereco, string telefone)
		{
			if(c1.CadastrarPessoaDoadora(nome, cpf, endereco, telefone))
			{
				Console.WriteLine($"Cadastro de doador/a {nome} realizado com sucesso!");
			} else
			{
				Console.WriteLine($"O CPF: {cpf}, já consta na lista de doadores ou beneficiários!");
			}
		}
		
		//Cadastro de pessoa doadora mensal.
		public static void CadastrarPessoaDoadoraMensal(string nome, string cpf, string endereco, string telefone)
		{
			if(c1.CadastrarPessoaDoadoraMensal(nome, cpf, endereco, telefone))
			{
				Console.WriteLine($"Cadastro de doador/a mensal {nome} realizado com sucesso!");
			} else
			{
				Console.WriteLine($"O CPF: {cpf}, já consta na lista de doadores ou beneficiários!");
			}
		}
		
		//Mostrar lista de doadores em uma tabela.
		public static void MostrarListaDeDoadores()
		{
			List<Doador> doadores = c1.MostrarListaDeDoadores();
			
			int nome = 0, cpf = 0, endereco = 0, telefone = 0, total;

			#region Maiores Valores
			//Seleciona os maiores valores da lista.
			foreach(Doador d in doadores)
			{
				if(d.Nome.Length > nome)
				{
					nome = d.Nome.Length;
				}

				if(d.CPF.Length > cpf)
				{
					cpf = d.CPF.Length;
				}
				
				if(d.Endereco.Length > endereco)
				{
					endereco = d.Endereco.Length;
				}
				
				if(d.Telefone.Length > telefone)
				{
					telefone = d.Telefone.Length;
				}
			}
			#endregion
			
			nome = nome < 8 ? 8 : nome;
			cpf = cpf < 3 ? 3 : cpf;
			endereco = endereco < 8 ? 8 : endereco;
			telefone = telefone < 8 ? 8 : telefone;

			total = nome + cpf + endereco + telefone + 4;

			Console.WriteLine($"\n{nome} | {cpf} | {endereco} | {telefone} | {total}\n");

			for(int i = 0; i <= total; i++) { Console.Write("_"); }

			Console.WriteLine($"\n|{"Doador/a".PadRight(nome)}|{"CPF".PadRight(cpf)}|{"Endereço".PadRight(endereco)}|{"Telefone".PadRight(telefone)}|");

			foreach(Doador d in doadores)
			{
				int tamanhoNome = nome < 8 ? 8 : d.Nome.Length < nome ? nome : 0;
				int tamanhoCPF = cpf < 3 ? 3 : d.CPF.Length < cpf ? cpf : 0;
				int tamanhoEndereco = endereco < 8 ? 8 : d.Endereco.Length < endereco ? endereco : 0;
				int tamanhoTelefone = telefone < 8 ? 8 : d.Telefone.Length < telefone ? telefone : 0;

				Console.WriteLine($"|{d.Nome.PadRight(tamanhoNome)}|{d.CPF.PadRight(tamanhoCPF)}|{d.Endereco.PadRight(tamanhoEndereco)}|{d.Telefone.PadRight(tamanhoTelefone)}|");
			}
		}
		
		//Mostrar lista de beneficiários.
		public static void MostrarListaDeBeneficiarios()
		{
			List<Beneficiario> beneficiarios = c1.MostrarListaDeBeneficiarios();

			foreach(Beneficiario b in beneficiarios)
			{
				Console.WriteLine($"\n" +
					$"Tipo: Beneficiário/a" +
					$"Nome: {b.Nome}\n" +
					$"CPF: {b.CPF}\n" +
					$"Endereço: {b.Endereco}\n" +
					$"Telefone: {b.Telefone}");
			}
		}

		//Mostrar toda a lista de doações.
		public static void MostrarListaDeDoacoes()
		{
			List<Doacao> doacoes = c1.MostrarListaDeDoacoes();

			foreach(Doacao d in doacoes)
			{
				Console.WriteLine($"\n" +
					$"Id: {d.Id}\n" +
					$"Data: {d.DataDoacao}\n" +
					$"Nome Doador: {d.Doador.Nome}\n" +
					$"CPF Doador: {d.Doador.CPF}\n" +
					$"Nome Beneficiário: {d.Beneficiario.Nome}\n" +
					$"CPf Beneficiário: {d.Beneficiario.CPF}");
			}
		}

		//Mostrar doações em certa data.
		public static void MostrarListaDeDoacoesPorData(DateTime data)
		{
			Doacao d = c1.MostrarListaDeDoacoes(data);

			Console.WriteLine($"\n" +
					$"Id: {d.Id}\n" +
					$"Data: {d.DataDoacao}\n" +
					$"Nome Doador: {d.Doador.Nome}\n" +
					$"CPF Doador: {d.Doador.CPF}\n" +
					$"Nome Beneficiário: {d.Beneficiario.Nome}\n" +
					$"CPf Beneficiário: {d.Beneficiario.CPF}");
		}

		//Realiza uma doação.
		public static void RealizarDoacao(Pessoa doador, Pessoa beneficiario)
		{
			c1.RegistrarDoacoes(DateTime.Now, doador, beneficiario);
		}

	}
}
