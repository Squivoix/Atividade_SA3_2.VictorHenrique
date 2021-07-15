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

		void MostrarListaDePessoas();

		List<Doacao> MostrarListaDeDoacoes();
		Doacao MostrarListaDeDoacoes(DateTime data);

		void CadastrarPessoaDoadora(string nome, string cpf, string endereco, string telefone);
		void CadastrarPessoaDoadoraMensal(string nome, string cpf, string endereco, string telefone);

		void CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone);

		void RegistrarDoacoes(DateTime data, Pessoa doador, Pessoa beneficiario, ItemDoacao item);
	}
}
