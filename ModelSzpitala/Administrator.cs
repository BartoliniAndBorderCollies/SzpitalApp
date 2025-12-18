using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    internal class Administrator : Pracownik
    {

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
