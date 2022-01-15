using System;

namespace Tickets
{
    public class Cliente
    {
        //valutare se il numero ha 10 caretteri, accettato se le 10 cifre sono tutte numeriche. se 10 cifre e una lettere Scrivere numero errato.
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Cellulare
        {
            get
            {
                return Cellulare;
            }
            set
            {

                if (value.Length != 10)
                    throw new Exception("numero errato, inserire 10 numeri");

                else if (value.Length == 10)
                {
                    try
                    {
                        int numero;
                        numero = Convert.ToInt32(value);
                    }
                    catch (Exception)
                    {
                        throw new Exception("numero inserito, non è un numero");
                    }
                }
                else
                     Cellulare = value;

            }
        }
        public bool Genere { get; set; }

    }
}
