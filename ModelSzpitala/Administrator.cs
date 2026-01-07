using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class Administrator : Pracownik
    {

        [JsonConstructor]
        protected Administrator()

        {
            // tylko dla deserializacji
        }

        public Administrator(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo) : base(imie, nazwisko, pesel,nazwaUzytkownika, haslo)
        {
        
        }

        public void DodajNowegoPracownika(Pracownik pracownik)
        {
            Szpital.SzpitalInstance.DodajPracownika(pracownik);
        }

        public string WyswietlListeWszystkichPracownikow()
        {
            return Szpital.SzpitalInstance.WyswietlListeWszystkichPracownikow();
        }

        public void UsunPracownika(String pesel)
        {
            Szpital.SzpitalInstance.UsunPracownika(pesel);
        }

    }
}
