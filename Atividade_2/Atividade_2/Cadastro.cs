using System;
using System.Collections.Generic;

namespace Atividade_2
{
	class Cadastro : ICadastro
	{
		public List<Doador> Doadores { get; set; }
		public List<Beneficiario> Beneficiarios { get; set; }
		public Dictionary<int, Doacao> Doacoes { get; set; }

		public void CadastrarPessoaBeneficiaria()
		{

		}

		public void CadastrarPessoaDoadora()
		{

		}

		public void CadastrarPessoaDoadoraMensal()
		{

		}

		public void MostrarListaDeDoacoes()
		{

		}

		public void MostrarListaDeDoacoes(DateTime data)
		{

		}

		public void MostrarListaDePessoas()
		{

		}

		public void RegistrarDoacoes(int id, Doacao doacao)
		{

		}
	}
}
