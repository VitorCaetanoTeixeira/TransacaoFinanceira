using System;

namespace TransacaoFinanceira.Domain
{
 public class Operacao{
        public int correlationId;
        public DateTime data;
        public long contaOrigem;
        public long contaDestino;
        public decimal valor;

        public Operacao(int correlationId, DateTime data, long contaOrigem, long contaDestino, decimal valor){
            this.correlationId = correlationId;
            this.contaOrigem = contaOrigem;
            this.contaDestino = contaDestino;
            this.valor = valor;
            this.data = data;
        }
        
    }
}