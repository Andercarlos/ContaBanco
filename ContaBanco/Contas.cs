using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
    class Contas
    {
        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        
        public Contas(string nome, 
                      TipoConta tipoConta, 
                      double saldo, 
                      double credito)
        {
            this.Nome = nome;
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
                    }

     

        public bool depositar(double valor)
        {
            this.Saldo = valor + Saldo;
            Console.WriteLine($"Obrigado, valor de R${Saldo} depositado com sucesso!");
            return true;
        }

        public bool sacar(double valorSaque)
        {
            if(this.Saldo < valorSaque)
            {
                Console.WriteLine($"Saldo insuficiente, Saldo atual: {this.Saldo}");
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                Console.WriteLine($"Valor retirado de R${valorSaque} retirado com sucesso, Saldo atual: {this.Saldo}");
                return true;
            }
           }
        public void Transferir(double valorTransferencia, Contas contaDestino )
        {
            if (this.sacar(valorTransferencia))
            {
                contaDestino.depositar(valorTransferencia);
            }
        }
        
        public override string ToString()
        {
            string mensagem="";
            mensagem += "Nome: " + this.Nome + " | ";
            mensagem += "Saldo: " + this.Saldo + " | ";
            mensagem += "Tipo: " + this.TipoConta + " | ";
            mensagem += "Credito: " + this.Credito + " | ";
            return mensagem;
        }
    }
}
