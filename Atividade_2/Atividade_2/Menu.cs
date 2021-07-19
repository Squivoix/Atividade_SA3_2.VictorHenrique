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
		
		//Mostrar lista de doadores.
		public static void MostrarListaDeDoadores()
		{
			List<Doador> doadores = c1.MostrarListaDeDoadores();

			foreach(Doador d in doadores)
			{
				Console.WriteLine($"\n" +
					$"Tipo: {(d is DoadorMensal ? "Doador/a Mensal" : "Doador/a")}\n" +
					$"Nome: {d.Nome}\n" +
					$"CPF: {d.CPF}\n" +
					$"Endereço: {d.Endereco}\n" +
					$"Telefone: {d.Telefone}");
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

			
		}

		//Mostrar doações em certa data.
		public static void MostrarListaDeDoacoesPorData(DateTime data)
		{
			Doacao doacao = c1.MostrarListaDeDoacoes(data);

			/*
			Id
			Data
			Doador
			Beneficiário
			*/
		}


		//Realiza uma doação.
		public static void RealizarDoacao(Pessoa doador, Pessoa beneficiario)
		{
			c1.RegistrarDoacoes(DateTime.Now, doador, beneficiario);
		}
		
	}
}
