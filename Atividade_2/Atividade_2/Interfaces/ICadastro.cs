using System;
using System.Collections.Generic;

namespace Atividade_2
{
	interface ICadastro
	{
		//Cadastro das pessoas e das doações
		List<Doador> Doadores { get; set; }
		List<Beneficiario> Beneficiarios { get; set; }
		Dictionary<int, Doacao> Doacoes { get; set; }

		void MostrarListaDePessoas();

		void MostrarListaDeDoacoes();
		void MostrarListaDeDoacoes(DateTime data);

		void CadastrarPessoaDoadora();
		void CadastrarPessoaDoadoraMensal();

		void CadastrarPessoaBeneficiaria();

		void RegistrarDoacoes(int id, Doacao doacao);
	}
}
