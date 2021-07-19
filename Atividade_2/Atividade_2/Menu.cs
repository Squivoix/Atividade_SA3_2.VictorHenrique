using System;
using System.Collections.Generic;

namespace Atividade_2
{
	static class Menu
	{
		private static Cadastro c1 = new Cadastro();

		//Cadastro de pessoa beneficiária.
		public static void CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone)
		{
			if(c1.CadastrarPessoaBeneficiaria(nome, cpf, endereco, telefone))
			{
				Console.WriteLine($"Cadastro de {nome} realizado com sucesso!");
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
				Console.WriteLine($"Cadastro de {nome} realizado com sucesso!");
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
				Console.WriteLine($"Cadastro de {nome} realizado com sucesso!");
			} else
			{
				Console.WriteLine($"O CPF: {cpf}, já consta na lista de doadores ou beneficiários!");
			}
		}
		
		//Mostrar toda a lista de doações.
		public static void MostrarListaDeDoacoes()
		{
			List<Doacao> Doacoes = c1.MostrarListaDeDoacoes();

			foreach(Doacao d in Doacoes)
			{
				/*
				Id
				Data
				Doador
				Beneficiário
				*/
			}
		}
		
		//Mostrar doações em certa data.
		public static void MostrarListaDeDoacoesPorData(DateTime data)
		{
			Doacao Doacao = c1.MostrarListaDeDoacoes(data);

			/*
			Id
			Data
			Doador
			Beneficiário
			*/
		}
		
	}
}
