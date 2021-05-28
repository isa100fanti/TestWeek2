using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    enum LivelloImportanza
    {
        Alto = 1,
        Medio,
        Basso
    }
    class Task
    {
        public string Descrizione { get; set; }
        public DateTime DataScadenza { get; set; }
        public LivelloImportanza Level { get; set; }

        public override string ToString()
        {
            string importanza;
            
            //if(LivelloImportanza.Alto == Level)
            //{
            //    importanza = "Alto";
            //}
            return $"Descrizione: {Descrizione}, DataScadenza: {DataScadenza.ToShortDateString()}, Livello importanza: {Level}";
        }
    }
}
