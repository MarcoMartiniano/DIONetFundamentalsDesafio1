using DIOTransferenciaBancaria.Classes;
using DIOTransferenciaBancaria.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOTransferenciaBancaria
{
    class Program
    {
		static List<Cadastro> listContas = new List<Cadastro>();
		static void Main(string[] args)
        {
			string opcaoUsuario = EntradaOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirCadastro();
						break;
					case "3":
						DepositarSaldoCliente();
						break;
					case "4":
						AlugarFilme();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = EntradaOpcaoUsuario();
			}


			Console.WriteLine("A Meme's Locadora agradece por utilizar nossos serviços.");
			Console.ReadLine();
		}

        private static void AlugarFilme()
        {
			Console.WriteLine("Lista Clientes");
			ListarContas();

			Console.Write("Digite o id do cliente: ");
			int entradaIdCliente = int.Parse(Console.ReadLine());

			Console.Write("Digite o status desejado (1- Alugou e 2- Não Alugou): ");
			int statusCliente = int.Parse(Console.ReadLine());

			listContas[entradaIdCliente].MudarStatus(statusCliente);

		}

        private static void DepositarSaldoCliente()
        {
			Console.WriteLine("Inserir saldo para cliente");
			ListarContas();
			Console.Write("Digite o id do cliente: ");
			int entradaIdCliente = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor: ");
			double valorSaldoCliente = double.Parse(Console.ReadLine());

			listContas[entradaIdCliente].DepositarConta(valorSaldoCliente);
		}

        private static string EntradaOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Meme's Locadora!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Colocar Saldo Cliente");
			Console.WriteLine("4- Alugar Filme");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}


		private static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Cadastro cadastro = listContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(cadastro);
			}
		}
		private static void InserirCadastro()
		{
			Console.WriteLine("Inserir um novo cadastro");

			Console.Write("Digite 1 para Conta individual ou 2 para Família: ");
			int entradaTipoConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Cadastro novoCadastro= new Cadastro(tipoConta: (TipoConta)entradaTipoConta,
										saldo: entradaSaldo,
										isAlugado: false,
										nome: entradaNome);
			listContas.Add(novoCadastro);
		}


	}
}
