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
			
			if(doadores.Count == 0)
			{
				Console.WriteLine("\nLista de doadores está vazio!");
				return;
			}

			int tipo = 0, nome = 0, cpf = 0, endereco = 0, telefone = 0, data = 0, total;

			#region Maiores Valores
			//Seleciona os maiores valores da lista.
			foreach(Doador d in doadores)
			{
				tipo = d is DoadorMensal ? 15 : tipo;

				nome = d.Nome.Length > nome ? d.Nome.Length : nome;
				cpf = d.CPF.Length > cpf ? d.CPF.Length : cpf;
				endereco = d.Endereco.Length > endereco ? d.Endereco.Length : endereco;
				telefone = d.Telefone.Length > telefone ? d.Telefone.Length : telefone;

				data = d.DataCadastro.ToString().Length > data ? d.DataCadastro.ToString().Length : data;
			}
			#endregion
			
			nome = nome < 8 ? 8 : nome;
			cpf = cpf < 3 ? 3 : cpf;
			endereco = endereco < 8 ? 8 : endereco;
			telefone = telefone < 8 ? 8 : telefone;

			total = nome + cpf + endereco + telefone + tipo + data + 5;

			for(int i = 0; i <= total; i++) { if(i == 0) { Console.Write(" "); } else { Console.Write("_"); } }

			Console.WriteLine($"\n|{"Tipo".PadRight(tipo)}|{"Doador/a".PadRight(nome)}|{"CPF".PadRight(cpf)}" +
				$"|{"Endereço".PadRight(endereco)}|{"Telefone".PadRight(telefone)}|{"Data Cadastro".PadRight(data)}|");

			foreach(Doador d in doadores)
			{
				int tamanhoNome = nome < 8 ? 8 : d.Nome.Length < nome ? nome : 0;
				int tamanhoCPF = cpf < 3 ? 3 : d.CPF.Length < cpf ? cpf : 0;
				int tamanhoEndereco = endereco < 8 ? 8 : d.Endereco.Length < endereco ? endereco : 0;
				int tamanhoTelefone = telefone < 8 ? 8 : d.Telefone.Length < telefone ? telefone : 0;
				int tamanhoData = data < 13 ? 13 : d.DataCadastro.ToString().Length < data ? data : 0;

				Console.WriteLine($"|{(d is DoadorMensal ? "Doador/a Mensal" : "Doador/a").PadRight(tipo)}|{d.Nome.PadRight(tamanhoNome)}|" +
					$"{d.CPF.PadRight(tamanhoCPF)}|{d.Endereco.PadRight(tamanhoEndereco)}|{d.Telefone.PadRight(tamanhoTelefone)}|{d.DataCadastro.ToString().PadRight(tamanhoData)}|");
			}
		}
		
		//Mostrar lista de beneficiários.
		public static void MostrarListaDeBeneficiarios()
		{
			List<Beneficiario> beneficiarios = c1.MostrarListaDeBeneficiarios();

			if(beneficiarios.Count == 0)
			{
				Console.WriteLine("\nLista de beneficiários/as está vazia!");
				return;
			}

			int nome = 0, cpf = 0, endereco = 0, telefone = 0, data = 0, total;

			#region Maiores Valores
			//Seleciona os maiores valores da lista.
			foreach(Beneficiario b in beneficiarios)
			{
				nome = b.Nome.Length > nome ? b.Nome.Length : nome;
				cpf = b.CPF.Length > cpf ? b.CPF.Length : cpf;
				endereco = b.Endereco.Length > endereco ? b.Endereco.Length : endereco;
				telefone = b.Telefone.Length > telefone ? b.Telefone.Length : telefone;

				data = b.DataCadastro.ToString().Length > data ? b.DataCadastro.ToString().Length : data;
			}
			#endregion

			nome = nome < 14 ? 14 : nome;
			cpf = cpf < 3 ? 3 : cpf;
			endereco = endereco < 8 ? 8 : endereco;
			telefone = telefone < 8 ? 8 : telefone;

			total = nome + cpf + endereco + telefone + data + 4;

			for(int i = 0; i <= total; i++) { if(i == 0) { Console.Write(" "); } else { Console.Write("_"); } }

			Console.WriteLine($"\n|{"Beneficiário/a".PadRight(nome)}|{"CPF".PadRight(cpf)}|{"Endereço".PadRight(endereco)}" +
				$"|{"Telefone".PadRight(telefone)}|{"Data".PadRight(data)}|");

			foreach(Beneficiario b in beneficiarios)
			{
				int tamanhoNome = nome < 14 ? 14 : b.Nome.Length < nome ? nome : 0;
				int tamanhoCPF = cpf < 3 ? 3 : b.CPF.Length < cpf ? cpf : 0;
				int tamanhoEndereco = endereco < 8 ? 8 : b.Endereco.Length < endereco ? endereco : 0;
				int tamanhoTelefone = telefone < 8 ? 8 : b.Telefone.Length < telefone ? telefone : 0;
				int tamanhoData = data < 13 ? 13 : b.DataCadastro.ToString().Length < data ? data : 0;

				Console.WriteLine($"|{b.Nome.PadRight(tamanhoNome)}|{b.CPF.PadRight(tamanhoCPF)}|{b.Endereco.PadRight(tamanhoEndereco)}" +
					$"|{b.Telefone.PadRight(tamanhoTelefone)}|{b.DataCadastro.ToString().PadRight(tamanhoData)}|");
			}
		}

		//Mostrar toda a lista de doações.
		public static void MostrarListaDeDoacoes()
		{
			List<Doacao> doacoes = c1.MostrarListaDeDoacoes();

			if(doacoes.Count == 0)
			{
				Console.WriteLine("\nA lista de doações está vazia!");
				return;
			}

			int id = 0, data = 0, nomeDoador = 0, cpfDoador = 0, nomeBene = 0, cpfBene = 0, total;

			#region Maiores Valores
			//Seleciona os maiores valores da lista.
			foreach(Doacao d in doacoes)
			{
				id = d.Id.ToString().Length > id ? d.Id.ToString().Length : id;
				data = d.DataDoacao.ToString().Length > data ? d.DataDoacao.ToString().Length : data;

				nomeDoador = d.Doador.Nome.Length > nomeDoador ? d.Doador.Nome.Length : nomeDoador;
				cpfDoador = d.Doador.CPF.Length > cpfDoador ? d.Doador.CPF.Length : cpfDoador;

				nomeBene = d.Beneficiario.Nome.Length > nomeBene ? d.Beneficiario.Nome.Length : nomeBene;
				cpfBene = d.Beneficiario.CPF.Length > cpfBene ? d.Beneficiario.CPF.Length : cpfBene;
			}
			#endregion

			total = id + data + nomeDoador + cpfDoador + nomeBene + cpfBene + 11;

			for(int i = 0; i <= total; i++) { if(i == 0) { Console.Write(" "); } else { Console.Write("_"); } }

			Console.WriteLine($"\n|{"Id".PadRight(id)}|{"Data Doação".PadRight(data)}|{"Nome Doador/a".PadRight(nomeDoador)}|{"CPF Doador/a".PadRight(cpfDoador)}" +
				$"|{"Nome Beneficiário/a".PadRight(nomeBene)}|{"CPF Beneficiário/a".PadRight(cpfBene)}|");

			foreach(Doacao d in doacoes)
			{
				int tamanhoId = id < 2 ? 2 : d.Id.ToString().Length < id ? id : 0;
				int tamanhoData = data < 11 ? 11 : d.DataDoacao.ToString().Length < data ? data : 0;
				int tamanhoNomeDoador = nomeDoador < 13 ? 13 : d.Doador.Nome.Length < nomeDoador ? nomeDoador : 0;
				int tamanhoCPFDoador = cpfDoador < 12 ? 12 : d.Doador.CPF.Length < cpfDoador ? cpfDoador : 0;
				int tamanhoNomeBene = nomeBene < 19 ? 19 : d.Beneficiario.Nome.Length < nomeBene ? nomeBene : 0;
				int tamanhoCPFBene = cpfBene < 18 ? 18 : d.Beneficiario.CPF.Length < cpfBene ? cpfBene : 0;

				Console.WriteLine($"|{d.Id.ToString().PadRight(tamanhoId)}|{d.DataDoacao.ToString().PadRight(tamanhoData)}" +
					$"|{d.Doador.Nome.PadRight(tamanhoNomeDoador)}|{d.Doador.CPF.PadRight(tamanhoCPFDoador)}" +
					$"|{d.Beneficiario.Nome.PadRight(tamanhoNomeBene)}|{d.Beneficiario.CPF.PadRight(tamanhoCPFBene)}|");
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
		public static void RealizarDoacao(string cpf1, string cpf2)
		{
			Doador d = PessoaDoadoraConstaNaLista(cpf1);
			Beneficiario b = PessoaBeneficiariaConstaNaLista(cpf2);

			if(d != null)
			{
				if(b != null)
				{
					c1.RegistrarDoacoes(DateTime.Now, d, b);
				} else
				{
					Console.WriteLine($"Não existe cadastro do CPF {cpf2}!");
				}
			} else
			{
				Console.WriteLine($"Não existe cadastro do CPF {cpf1}!");
			}
		}

		#region Métodos Privados
		static Doador PessoaDoadoraConstaNaLista(string cpf)
		{
			return c1.Doadores.Find(x => x.CPF == cpf);
		}
		static Beneficiario PessoaBeneficiariaConstaNaLista(string cpf)
		{
			return c1.Beneficiarios.Find(x => x.CPF == cpf);
		}
		#endregion
	}
}
