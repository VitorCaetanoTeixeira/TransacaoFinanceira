using System;
using TransacaoFinanceira.Domain;
using TransacaoFinanceira.Repositories;

namespace TransacaoFinanceira.Services
{
    public class TransacaoService
    {   
        private readonly DadosSaldoContas _contas;

        public TransacaoService(DadosSaldoContas contas){
            _contas = contas;
        }

        public void Transferir(Operacao operacao){
            var contaOrigem = _contas.GetById(operacao.contaOrigem);
            var contaDestino =  _contas.GetById(operacao.contaDestino);
            if(operacao.valor <= 0){
                Console.WriteLine($"Nào é possivel fazer transferencias com valor menor ou igual a zero");
                return;
            }

            if(!contaOrigem.Debitar(operacao.valor)){
                
                Console.WriteLine($"Transacao número {operacao.correlationId} foi cancelada por falta de saldo");
                return;
            }

            contaDestino.Creditar(operacao.valor);
            Console.WriteLine($"Transacao número {operacao.correlationId} foi efetuada com sucesso!! Novos saldos: Conta Origem: {contaOrigem.saldo} | Conta Destino: {contaDestino.saldo}");
               

        }
    }
}