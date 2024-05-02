using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string Titolo;
        public DateTime Data { get; set; }
        public List<Evento> eventi {  get; set; } = new();

        public ProgrammaEventi() 
        {
            Titolo = "ciaociao";
            Data = DateTime.MinValue;
        }

        public ProgrammaEventi(string titolo, DateTime data)
        {
            Titolo = titolo;
            Data = data;
        }

        public void AddEvents(Evento evento)
        {
            eventi.Add(evento);
        }

        public void EmptyList()
        {
            eventi.Clear();
        }

        public void ShowEvents()
        {
            foreach (Evento evento in eventi)
            {
                Console.WriteLine($"{evento.Data} - {evento.Titolo}");
            }
        }
    }
}
