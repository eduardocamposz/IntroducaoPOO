using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo_inicial;
        public Conta(long numero)
        {
            _numero = numero;        
        }
        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo_inicial = saldo;
        }
        public long Numero 
        { 
            get
            {  
                return _numero;
            }
        }
        public decimal Saldo
        {
            get
            {
                return _saldo_inicial;
            }
            set
            {
                _saldo_inicial = value;
            }
        }
        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }
    }
}
