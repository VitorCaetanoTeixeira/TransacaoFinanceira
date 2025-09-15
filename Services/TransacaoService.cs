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
            var origem = _contas.GetById(operacao.contaOrigem);
            var destino =  _contas.GetById(operacao.contaDestino);
            if(operacao.valor <= 0){
                Console.WriteLine($"Nào é possivel fazer transferencias com valor menor ou igual a zero");
                return;
            }

            if(!origem.Debitar(operacao.valor)){
                
                Console.WriteLine($"Transacao número {operacao.correlationId} foi cancelada por falta de saldo");
                return;
            }

            destino.Creditar(operacao.valor);
            Console.WriteLine($"Transacao número {operacao.correlationId} foi efetuada com sucesso!! Saldo atual conta Origem:{origem.saldo} Saldo atual conta Destino:{destino.saldo}");
               

        }
    }
}