using System;
using System.Collections.Generic;

namespace Atividade_2
{
	interface ICadastro
	{
		//Cadastro das pessoas e das doações
		List<Doador> Doadores { get; set; }
		List<Beneficiario> Beneficiarios { get; set; }
		List<Doacao> Doacoes { get; set; }

		List<Doador> MostrarListaDeDoadores();
		List<Beneficiario> MostrarListaDeBeneficiarios();

		List<Doacao> MostrarListaDeDoacoes();
		Doacao MostrarListaDeDoacoes(DateTime data);

		bool CadastrarPessoaDoadora(string nome, string cpf, string endereco, string telefone);
		bool CadastrarPessoaDoadoraMensal(string nome, string cpf, string endereco, string telefone);
		bool CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone);
		void RegistrarDoacoes(DateTime data, Pessoa doador, Pessoa beneficiario);
	}
}
