using System;
using DDDSample1.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DDDSample1.Domain.Entregas
{
    [Owned]
    public class EntregaTempoRetirar : IValueObject{
        public Double TempoRetirarEntrega { get; private set;}
        
        public EntregaTempoRetirar(Double tempoRetirarEntrega){
            /*if(!validaTempo(tempoRetirarEntrega)){
                throw new BusinessRuleValidationException("O valor do tempo tem de ser superior a 0");
            }*/
            this.TempoRetirarEntrega=tempoRetirarEntrega;
        }

        private static bool validaTempo (Double tempoRetirarEntrega){
            return tempoRetirarEntrega > 0;
        }
    }
    
}