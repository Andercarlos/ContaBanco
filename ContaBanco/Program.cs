using System;
using System.Collections.Generic;

namespace ContaBanco
{
    class Program
    {
        static List<Contas> Todas = new List<Contas>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Adicionar- 1\n Sair- 0");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0) { 
            switch (opcao) 
            {
                case 1:
                    Adicionar();
                    foreach(Contas a in Todas)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                    
            }
            }



            static void Adicionar()
            {
                Console.WriteLine("Nome?");
                string NomeEntrada = Console.ReadLine();

                Console.WriteLine("Tipo da conta 1 ou 2");
                int TipoEntrada = int.Parse(Console.ReadLine());

                Console.WriteLine("Saldo");
                double SaldoEntrada = double.Parse(Console.ReadLine());

                Console.WriteLine("Crédito Inicial?");
                double CreditoInicial = double.Parse(Console.ReadLine());

                Contas NovaConta = new Contas(tipoConta: (TipoConta)TipoEntrada,
                                            nome: NomeEntrada,
                                            saldo: SaldoEntrada,
                                            credito: CreditoInicial
                                            );
                Todas.Add(NovaConta);


            }
       

        }

    }
}
