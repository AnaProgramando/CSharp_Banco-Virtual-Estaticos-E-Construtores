using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualEstaticosEConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banco Virtual - Estáticos e Construtores: \r\n");

            Console.WriteLine("Total de Contas registradas até o momento: " + ContaCorrente.TotalContas);
            
            Console.WriteLine("____________________________________________________________________ \r\n");

            ContaCorrente conta = new ContaCorrente(123, 12345678);
            Console.WriteLine("O número da agência é " + conta.Agencia + ".");
            Console.WriteLine("O número da conta é " + conta.NumConta + ".");

            Console.WriteLine("____________________________________________________________________ \r\n");

            Console.WriteLine("Total de Contas registradas até o momento: " + ContaCorrente.TotalContas);
            
            Console.WriteLine("____________________________________________________________________ \r\n");

            ContaCorrente contaFulano = new ContaCorrente(321, 87654321);
            Console.WriteLine("O número da agência do Fulano é " + contaFulano.Agencia + ".");
            Console.WriteLine("O número da conta do Fulano é " + contaFulano.NumConta + ".");

            Console.WriteLine("____________________________________________________________________ \r\n");

            Console.WriteLine("Total de Contas registradas até o momento: " + ContaCorrente.TotalContas);

            Console.ReadLine();
        }
    }
}
