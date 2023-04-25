using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualEstaticosEConstrutores
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}

        //Bloqueado o acesso aos dados, ou seja, é possível viualizar, mas não editar
        public static int TotalContas { get; private set; }

        private int _agencia;
        public int Agencia 
        { 
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        public int NumConta { get; set; }

        //Valor padrão do saldo inicial da conta é de 100 e não 0
        private double _saldo = 100;


        // Propriedade Saldo
        public double Saldo
        {
            get
            {
                // O [saldo] é um campo privado que pode ser usado em uma propriedade.
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numConta)
        {
            // Bloqueado para que não posssa criar uma nova conta sem a agência e número da conta
            // No Program ficará como: ContaCorrente conta = new ContaCorrente(conta.Agencia, conta.NumConta)
            Agencia = agencia;
            NumConta = numConta;

            //Contador do número total de contas criadas
            TotalContas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }


        //Void, pois a função não tem retorno
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
