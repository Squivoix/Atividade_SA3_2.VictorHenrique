using System;
using System.Collections.Generic;

namespace Atividade_2
{
	class Cadastro : ICadastro
	{
		public List<Doador> Doadores { get; set; }
		public List<Beneficiario> Beneficiarios { get; set; }
		public List<Doacao> Doacoes { get; set; }

		public void CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone)
		{
			Beneficiarios.Add(new Beneficiario(nome, cpf, endereco, telefone));
		}

		public void CadastrarPessoaDoadora(string nome, string cpf, string endereco, string telefone)
		{
			Doadores.Add(new Doador(nome, cpf, endereco, telefone));
		}

		public void CadastrarPessoaDoadoraMensal(string nome, string cpf, string endereco, string telefone)
		{
			Doadores.Add(new DoadorMensal(nome, cpf, endereco, telefone));
		}

		public List<Doacao> MostrarListaDeDoacoes()
		{
			return Doacoes;
		}

		public Doacao MostrarListaDeDoacoes(DateTime data)
		{
			//Testar para ver se dá tudo certinho.
			return Doacoes.Find(x => x.DataDoacao == data);
		}

		public void MostrarListaDePessoas()
		{

		}

		public void RegistrarDoacoes(DateTime data, Pessoa doador, Pessoa beneficiario, ItemDoacao item)
		{
			Doacoes.Add(new Doacao(data, doador, beneficiario, item));
		}
	}
}
