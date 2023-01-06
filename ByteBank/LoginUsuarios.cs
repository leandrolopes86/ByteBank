using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class LoginUsuarios
    {
        public static Conta Login(List<Conta> contas)
        {
            foreach (Conta obj in contas)
            {
                Console.WriteLine($"Número da conta: #{obj.NumConta}\nTitular: {obj.Titular}");
                Console.WriteLine();
            }
            Conta c;
            do
            {
                Console.Write("Digite o número da conta que você quer fazer login: #");
                int numContaLogin = int.Parse(Console.ReadLine());
                Console.Write("Digite a sua senha: ");
                string senhaLogin = ValidaSenha.getPassword();
                //string senhaLogin = Console.ReadLine();
                Console.WriteLine();
                c = contas.Find(x => x.NumConta == numContaLogin && x.Senha == senhaLogin);
                if (c == null)
                {
                    Console.WriteLine("Número da conta ou senha inválidos. Tente novamente.");
                    Console.WriteLine();
                }
            } while (c == null);
            return c;
        }
    }
}
