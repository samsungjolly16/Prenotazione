using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
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
                value.Replace(" ", "");
                if (value.Length != 10)
                    throw new Exception("numero incompeto o troppo grande, inserire 10 numeri");

                else if (value.Length == 10)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        char c = value[i];
                        bool vf = char.IsDigit(c);
                        if (vf == false)
                        {
                            throw new Exception("hai inserito un valore errato");
                        }
                    }
                }
                else
                    Cellulare = value;
            }
        }
        internal bool Maschio;
        public char GetGenere()
        {
            char c;
            if (Maschio)
                c = 'M';
            else
                c = 'F';
            return c;
        }
         
        public void SetGenere(bool vf)
        {
                Maschio = vf;
        }
        public override string ToString()
        {
            return $"{Nome}  {Cognome}";
        }
    }
}
