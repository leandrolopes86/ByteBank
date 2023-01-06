using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Menu
    {
        public static void MenuAnterior()
        {
            Console.WriteLine();
            Console.Write("Digite qualquer tecla para voltar ao menu anterior... ");
            Console.ReadKey();
        }

        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Inicial");
            Console.WriteLine();
            Console.WriteLine("[1] - Inserir nova conta");
            Console.WriteLine("[2] - Deletar uma conta");
            Console.WriteLine("[3] - Listar contas registradas");
            Console.WriteLine("[4] - Detalhes de uma conta");
            Console.WriteLine("[5] - Total armazenado no banco");
            Console.WriteLine("[6] - Manipular conta");
            Console.WriteLine("[0] - Sair do menu");
            Console.Write("[X] - Digite a opção desejada: ");
        }
        public static void MenuLogado()
        {
            Console.WriteLine("Opção [6]: ");
            Console.WriteLine("[1] - Depósito");
            Console.WriteLine("[2] - Saque");
            Console.WriteLine("[3] - Transferencia");
            Console.WriteLine("[4] - Para fazer LOGOUT");
            Console.Write("[X] - Digite a opção desejada: ");
        }
    }
}
