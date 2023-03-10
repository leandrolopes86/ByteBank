using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Conta
    {
        public string Titular { get; private set; }
        public string Cpf { get; private set; }
        public string Senha { get; private set; }
        public double Saldo { get; private set; }
        public int NumConta { get; private set; }

        public Conta()
        {
        }

        public Conta(string titular, string cpf, string senha, double saldo, int numConta)
        {
            Titular = titular;
            Cpf = cpf;
            Senha = senha;
            Saldo = saldo;
            NumConta = numConta;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor;
        }

        public void Transferencia(Conta contaOrigem, Conta contaDestino, double valor)
        {
            contaOrigem.Saldo = contaOrigem.Saldo - valor;
            contaDestino.Saldo = contaDestino.Saldo + valor;
        }

        public override string ToString()
        {
            return $"Conta Número #{NumConta}\nTitular: {Titular}\nCPF: {Cpf}\nSaldo: {Saldo:F2}";
        }    
    }
}
