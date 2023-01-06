using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class ManipulaConta
    {       
        public static void Deposito(Conta contaLogada)
        {
            Console.Write("Qual o valor do depósito: R$");
            double valor = double.Parse(Console.ReadLine());
            contaLogada.Deposito(valor);
            Console.WriteLine($"Depósito de R${valor:F2} efetuado com sucesso para {contaLogada.Titular}! ");
            Console.WriteLine();
        }

        public static void Saque(Conta contaLogada)
        {
            Console.Write("Qual o valor do saque: R$");
            double valor = double.Parse(Console.ReadLine());
            if (contaLogada.Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para realizar a operação!");

            }
            else
            {
                contaLogada.Saque(valor);
                Console.WriteLine($"Saque de R${valor:F2} efetuado com sucesso de {contaLogada.Titular}");
                Console.WriteLine();
            }
        }

        public static void Transferencia(List<Conta> contas, Conta contaLogada)
        {
            Conta contaOrigem = contaLogada;
            Console.WriteLine();
            foreach (Conta obj in contas)
            {
                Console.WriteLine($"Número da conta: #{obj.NumConta}\nTitular:{obj.Titular}");
                Console.WriteLine();
            }
            Console.Write("Digite o número da conta de destino: #");
            int procurarConta = int.Parse(Console.ReadLine());
            Conta contaDestino = contas.Find(x => x.NumConta == procurarConta);
            Console.WriteLine();
            while (contaDestino == null)
            {
                Console.Write("Conta inválida, digite novamente o número da conta: #");
                procurarConta = int.Parse(Console.ReadLine());
                contaDestino = contas.Find(x => x.NumConta == procurarConta);
                Console.WriteLine();
            }
            while (contaDestino == contaOrigem)
            {
                Console.Write("A Conta de destino não pode ser a mesma da origem.\nDigite novamente o número da conta: #");
                procurarConta = int.Parse(Console.ReadLine());
                contaDestino = contas.Find(x => x.NumConta == procurarConta);
                Console.WriteLine();
                if (contaDestino == null)
                {
                    Console.Write("Conta inválida, digite novamente o número da conta: #");
                    procurarConta = int.Parse(Console.ReadLine());
                    contaDestino = contas.Find(x => x.NumConta == procurarConta);
                    Console.WriteLine();
                }
            }
            Console.Write("Digite o valor: R$");
            double valorTransferencia = double.Parse(Console.ReadLine());
            if (contaLogada.Saldo < valorTransferencia)
            {
                Console.WriteLine("Saldo insuficiente para realizar essa operação!");
            }
            else
            {
                contaDestino.Transferencia(contaOrigem, contaDestino, valorTransferencia);
                Console.WriteLine();
                Console.WriteLine("Transfêrencia realizada com sucesso!");
                Console.WriteLine();
                Console.WriteLine($" Valor \nR${valorTransferencia:F2}");
                Console.WriteLine();
                Console.WriteLine($" Conta de Origem \nNúmero #{contaOrigem.NumConta}\nTitular: {contaOrigem.Titular}");
                Console.WriteLine();
                Console.WriteLine($" Conta de Destino \nNúmero #{contaDestino.NumConta}\nTitular: {contaDestino.Titular}");
                Console.WriteLine();
            }
        }
    }
}
