using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        public string Titolo {  get; set; }
        public DateTime Data {  get; set; }
        public int Capienza {  get; set; }
        public int PostiPrenotati {  get; set; }

        public Evento() 
        {
            
        }

    }
}
