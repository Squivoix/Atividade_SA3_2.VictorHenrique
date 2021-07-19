using System;
using System.Collections.Generic;

namespace Atividade_2
{
	class Cadastro : ICadastro
	{
		public List<Doador> Doadores { get; set; }
		public List<Beneficiario> Beneficiarios { get; set; }
		public List<Doacao> Doacoes { get; set; }

		/// <summary>
		/// Cadastrar uma pessoa beneficiária.
		/// </summary>
		/// <param name="nome">O nome da pessoa.</param>
		/// <param name="cpf">O CPF da pessoa.</param>
		/// <param name="endereco">O endereço da pessoa.</param>
		/// <param name="telefone">O telefone da pessoa.</param>
		public bool CadastrarPessoaBeneficiaria(string nome, string cpf, string endereco, string telefone)
		{
			if(PessoaDoadoraConstaNaLista(cpf) || PessoaBeneficiariaConstaNaLista(cpf))
			{
				return false;
			}

			Beneficiarios.Add(new Beneficiario(nome, cpf, endereco, telefone));
			return true;
		}

		/// <summary>
		/// Cadastrar uma pessoa doadora.
		/// </summary>
		/// <param name="nome">O nome da pessoa.</param>
		/// <param name="cpf">O CPF da pessoa.</param>
		/// <param name="endereco">O endereço da pessoa.</param>
		/// <param name="telefone">O telefone da pessoa.</param>
		public bool CadastrarPessoaDoadora(string nome, string cpf, string endereco, string telefone)
		{
			if(PessoaDoadoraConstaNaLista(cpf) || PessoaBeneficiariaConstaNaLista(cpf))
			{
				return false;
			}

			Doadores.Add(new Doador(nome, cpf, endereco, telefone));
			return true;
		}

		/// <summary>
		/// Cadastrar uma pessoa doadora mensalista.
		/// </summary>
		/// <param name="nome">O nome da pessoa.</param>
		/// <param name="cpf">O CPF da pessoa.</param>
		/// <param name="endereco">O endereço da pessoa.</param>
		/// <param name="telefone">O telefone da pessoa.</param>
		public bool CadastrarPessoaDoadoraMensal(string nome, string cpf, string endereco, string telefone)
		{
			if(PessoaDoadoraConstaNaLista(cpf) || PessoaBeneficiariaConstaNaLista(cpf))
			{
				return false;
			}
			
			Doadores.Add(new DoadorMensal(nome, cpf, endereco, telefone, DateTime.Now));
			return true;
		}

		/// <summary>
		/// Mostrar a lista de doações.
		/// </summary>
		/// <returns></returns>
		public List<Doacao> MostrarListaDeDoacoes()
		{
			return Doacoes;
		}

		/// <summary>
		/// Mostrar as doações de certo data.
		/// </summary>
		/// <param name="data">A data a ser especificada.</param>
		/// <returns></returns>
		public Doacao MostrarListaDeDoacoes(DateTime data)
		{
			//Testar para ver se dá tudo certinho.
			return Doacoes.Find(x => x.DataDoacao == data);
		}

		/// <summary>
		/// Mostrar a lista de pessoas cadastradas.
		/// </summary>
		public List<Doador> MostrarListaDeDoadores()
		{
			return Doadores;
		}

		public List<Beneficiario> MostrarListaDeBeneficiarios()
		{
			return Beneficiarios;
		}

		/// <summary>
		/// Registrar as doações feitas.
		/// </summary>
		/// <param name="data">A data da doação.</param>
		/// <param name="doador">A pessoa que doou.</param>
		/// <param name="beneficiario">A pessoa que recebeu.</param>
		public void RegistrarDoacoes(DateTime data, Pessoa doador, Pessoa beneficiario)
		{
			Doacoes.Add(new Doacao(data, doador, beneficiario));
		}

		#region Funções Privadas
		/// <summary>
		/// Procura se uma pessoa beneficiária já existe com o mesmo CPF.
		/// </summary>
		/// <param name="cpf">O CPF a ser procurado.</param>
		/// <returns></returns>
		private bool PessoaBeneficiariaConstaNaLista(string cpf)
		{
			return Beneficiarios.Contains(Beneficiarios.Find(x => x.CPF == cpf));
		}

		/// <summary>
		/// Procura se uma pessoa doadora já existe com o mesmo CPF.
		/// </summary>
		/// <param name="cpf">O CPF a ser procurado.</param>
		/// <returns></returns>
		private bool PessoaDoadoraConstaNaLista(string cpf)
		{
			return Doadores.Contains(Doadores.Find(x => x.CPF == cpf));
		}
		#endregion
	}
}
