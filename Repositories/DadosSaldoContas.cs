using System.Collections.Generic;
using System.Linq;
using TransacaoFinanceira.Domain;

namespace TransacaoFinanceira.Repositories{
    public class DadosSaldoContas{
        private readonly List<Conta> _contas;

        public DadosSaldoContas()
        {
            _contas = new List<Conta>
            {
                new Conta(938485762, 180),
                new Conta(347586970, 1200),
                new Conta(2147483649, 0),
                new Conta(675869708, 4900),
                new Conta(238596054, 478),
                new Conta(573659065, 787),
                new Conta(210385733, 10),
                new Conta(674038564, 400),
                new Conta(563856300, 1200)
            };
        }

        public Conta GetById(long numeroConta) => _contas.First(c => c.numero == numeroConta);

    }
}