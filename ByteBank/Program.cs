using System;
using System.Drawing;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            List<Conta> contas = new List<Conta>();

            do
            {
                Console.Clear();
                Menu.ShowMenu();
                opcao = int.Parse(Console.ReadLine());
                while (opcao > 6)
                {
                    Console.Write("Opção inválida. Informe uma opção válida: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine();
                        GerenciaConta.AdicionaConta(contas);
                        Menu.MenuAnterior();
                        break;

                    case 2:
                        Console.WriteLine();
                        GerenciaConta.BuscarContas(contas);
                        GerenciaConta.RemoveConta(contas);
                        Console.WriteLine("Lista de Contas Atualizada: ");
                        Console.WriteLine();
                        GerenciaConta.BuscarContas(contas);
                        Menu.MenuAnterior();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Lista de Contas Cadastradas.");
                        Console.WriteLine();
                        GerenciaConta.BuscarContas(contas);
                        Menu.MenuAnterior();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Resumo da Conta.");
                        Console.WriteLine();
                        GerenciaConta.DetalheConta(contas);
                        Menu.MenuAnterior();
                        break;
                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Valor total no Banco");
                        Console.WriteLine();
                        Console.WriteLine($"Total armazenado no banco: R${GerenciaConta.TotalBanco(contas):F2}");
                        Menu.MenuAnterior();
                        break;
                    case 6:
                        Conta contaLogada = LoginUsuarios.Login(contas);
                        do
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(contaLogada);
                            Console.WriteLine($"O que vamos fazer hoje, {contaLogada.Titular}?");
                            Console.WriteLine();
                            Menu.MenuLogado();
                            opcao = int.Parse(Console.ReadLine());
                            while (opcao > 4)
                            {
                                Console.Write("Opção inválida, digite novamente: ");
                                opcao = int.Parse(Console.ReadLine());
                            }
                            Console.WriteLine();
                            switch (opcao)
                            {
                                case 1:
                                    Console.WriteLine(" DEPÓSITO ");
                                    Console.WriteLine();
                                    ManipulaConta.Deposito(contaLogada);
                                    Console.WriteLine("Digite qualquer tecla para fazer outra transação... ");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.WriteLine(" SAQUE ");
                                    Console.WriteLine();
                                    ManipulaConta.Saque(contaLogada);
                                    Console.WriteLine("Digite qualquer tecla para fazer outra transação... ");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine(" TRANSFERÊNCIA ");
                                    Console.WriteLine();
                                    ManipulaConta.Transferencia(contas, contaLogada);
                                    Console.WriteLine("Digite qualquer tecla para fazer outra transação... ");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (opcao != 4);
                        Console.WriteLine("Obrigado por usar nossos serviços!");
                        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal...");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
            Console.WriteLine("");
        }               
    }
}
