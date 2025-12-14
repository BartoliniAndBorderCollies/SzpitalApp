using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    internal class Dyzur
    {
        public Pracownik Pracownik {  get; set; }
        public DateTime DataRozpoczecia { get; set; }
        public DateTime DataZakonczenia { get; set; }

        public Dyzur(Pracownik pracownik, DateTime dataRozpoczecia, DateTime dataZakonczenia)
        {
            Pracownik = pracownik;
            DataRozpoczecia = dataRozpoczecia;
            DataZakonczenia = dataZakonczenia;
        }

    }
}
