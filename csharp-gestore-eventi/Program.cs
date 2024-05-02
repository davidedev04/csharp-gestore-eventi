namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Evento evento = new Evento();
            Console.WriteLine("Inserisci il nome dell'evento: ");
            evento.Titolo = Console.ReadLine();

            DateTime date;
            bool error = true;
            
            while (error)
            {
                Console.WriteLine("Inserisci la data dell'evento (gg/MM/yyyy): ");
                string inputDate = Console.ReadLine();

                if (DateTime.TryParse(inputDate, out date))
                {
                    evento.Data = date;
                    error = false;
                }
                else
                {
                    Console.WriteLine("Formato data non valido. Assicurati di inserire la data nel formato corretto (gg/MM/yyyy).");
                    error = true;
                }
            }

            Console.WriteLine("Inserisci il numero di posti totali: ");
            evento.Capienza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quanti posti desideri prenotare? ");
            evento.PostiPrenotati = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Numero di posti prenotati = {evento.PostiPrenotati}");
            Console.WriteLine($"Numero di posti disponibili = {evento.Capienza - evento.PostiPrenotati}");
            evento.DisdiciPosti();*/

            ProgrammaEventi events = new();
            events.ShowEvents();
        }
    }
}
