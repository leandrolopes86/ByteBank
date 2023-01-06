using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class GerenciaConta
    {
        public static void AdicionaConta(List<Conta> contas)
        {
            Console.WriteLine($"Digite os dados da nova conta:");
            Console.Write("Nome do Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Crie uma senha: ");
            string senha = ValidaSenha.getPassword();
            //string senha = Console.ReadLine();
            Console.Write("Digite o depósito inicial: R$");
            double saldo = double.Parse(Console.ReadLine());
            Random numAleatorioParaConta = new Random();
            int numConta = numAleatorioParaConta.Next(0000, 9000);
            Console.WriteLine($"O número da sua conta será: #{numConta}");
            contas.Add(new Conta(nome, cpf, senha, saldo, numConta));
            Console.WriteLine();
            Console.WriteLine($"Conta criada com sucesso {nome}!!");
        }

        public static void RemoveConta(List<Conta> contas)
        {
            Console.Write("Digite o numero da conta que você deseja deletar? #");
            int procurarConta = int.Parse(Console.ReadLine());
            Conta c = contas.Find(x => x.NumConta == procurarConta);
            contas.Remove(c);
            while (c == null)
            {
                Console.Write("Conta inválida, digite novamente o número: #");
                procurarConta = int.Parse(Console.ReadLine());
                c = contas.Find(x => x.NumConta == procurarConta);
                contas.Remove(c);
            }
            Console.WriteLine($"Conta número #{c.NumConta} Removida com sucesso.");
            Console.WriteLine();
        }

        public static void BuscarContas(List<Conta> contas)
        {
            if (contas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada!");
            }
            else
            {

                foreach (Conta obj in contas)
                {
                    Console.WriteLine(obj.ToString());
                    Console.WriteLine();
                }
            }
        }
        public static double TotalBanco(List<Conta> contas)
        {
            double soma = 0;
            foreach (Conta obj in contas)
            {
                soma += obj.Saldo;
            }
            return soma;
        }
        public static void DetalheConta(List<Conta> contas)
        {
            Console.WriteLine("Contas: ");
            foreach (Conta obj in contas)
            {
                Console.WriteLine("#" + obj.NumConta.ToString());
            }
            Console.WriteLine();
            Console.Write("Qual o número da conta que você quer consultar? #");
            int procurarConta = int.Parse(Console.ReadLine());
            Conta c = contas.Find(x => x.NumConta == procurarConta);
            while (c == null)
            {
                Console.Write("Conta inválida, digite novamente o número: #");
                procurarConta = int.Parse(Console.ReadLine());
                c = contas.Find(x => x.NumConta == procurarConta);
            }
            foreach (Conta obj in contas)
            {
                if (obj == c)
                {
                    Console.WriteLine();
                    Console.WriteLine("Detalhes da conta: ");
                    Console.WriteLine(obj.ToString());
                }
            }
        }
    }
}
