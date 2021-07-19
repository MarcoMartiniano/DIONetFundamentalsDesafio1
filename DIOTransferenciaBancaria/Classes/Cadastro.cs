using DIOTransferenciaBancaria.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOTransferenciaBancaria.Classes
{
    class Cadastro
    {
		// Atributos
				
		private TipoConta TipoConta { get; set; }
		private double Saldo { get; set; }
		private string Nome { get; set; }
		private bool isAlugado { get; set; }

		// Métodos
		public Cadastro(TipoConta tipoConta, double saldo, string nome, bool isAlugado)
		{
			this.TipoConta = tipoConta;
			this.Saldo = saldo;
			this.Nome = nome;
			this.isAlugado = isAlugado;
		}

		public void MudarStatus(int valorStatus)
		{
            switch (valorStatus)
            {
				//true
				case 1:
					isAlugado = true;
					Console.WriteLine("Status do cliente {0} é {1}", this.Nome, this.isAlugado);
					break;
				//false
				case 2:
					isAlugado = false;
					Console.WriteLine("Status do cliente {0} é {1}", this.Nome, this.isAlugado);
					break;
				default:
					Console.WriteLine("Valor Status infavlido");
					break;
			}
			
		}


		public void DepositarConta(double valorDeposito)
		{
			this.Saldo += valorDeposito;
			Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
		}



		public override string ToString()
		{
			string retorno = "";
			retorno += "TipoConta " + this.TipoConta + " | ";
			retorno += "Nome " + this.Nome + " | ";
			retorno += "Saldo " + this.Saldo + " | ";
			retorno += "Filme Alugado " + this.isAlugado;
			return retorno;
		}


	}
}
