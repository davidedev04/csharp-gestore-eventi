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
            Titolo = string.Empty;
            Data = DateTime.MinValue;
            Capienza = 0;
            PostiPrenotati = 0;
        }

        public Evento(string titolo, DateTime data, int capienza) 
        {
            Titolo = titolo;
            Data = data;
            Capienza = capienza;
            PostiPrenotati = 0;
        }

        public void PrenotaPosti(int postiAggiunti)
        {
            int sum = PostiPrenotati + postiAggiunti;
        }

        public void DisdiciPosti(int postiDisdetti)
        {
            Console.WriteLine("Vuoi disdire dei posti (si/no)? ");
            int sum = PostiPrenotati - postiDisdetti;
        }

        public override string ToString()
        {
            Data.ToString("dd/MM/yyyy");
            Console.WriteLine($"{Data} - {Titolo}");
            return base.ToString();
        }

    }
}
