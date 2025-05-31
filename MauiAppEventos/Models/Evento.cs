using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int DuracaoEmDias
        {
            get
            {
                TimeSpan intervalo = (DataTermino - DataInicio);
                return (intervalo.Days+1);
            }
        }
        

        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
                
    }
}
