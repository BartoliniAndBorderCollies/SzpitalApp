using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    internal class Lekarz : Pracownik
    {
        private Specjalnosc _specjalnosc;
        private int _numerPWZ;
        private readonly List<Dyzur> _listaDyzurow = new List<Dyzur>(); //tworze liste raz, a potem mogę ją modyfikować, ale nie nadpisywac

        public Lekarz(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo, Specjalnosc specjalnosc, int numerPWZ, List<Dyzur> listaDyzurow) : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo)
        {
            this._specjalnosc = specjalnosc;
            this._numerPWZ = numerPWZ;

            if (listaDyzurow != null)
            {
                _listaDyzurow.AddRange(listaDyzurow);
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSpecjalność: {_specjalnosc}, Numer PWZ: {_numerPWZ}";
        }


        public IReadOnlyList<Pracownik> WyswietlListeLekarzyPielegniarek()
        {
            return Szpital.SzpitalInstance.WyswietlListeLekarzyPielegniarek();
        }


        public void DodajDyzur(Dyzur dyzur)
        {

            if (SprawdzLiczbeDyzurowWMiesiacu(dyzur) >= 10)
            {
                Console.WriteLine("Nie można mieć więcej niż 10 dyżurów miesięcznie");
                return;
            }

            if (SprawdzDyzurDzienPoDniu(dyzur))
            {
                Console.WriteLine("Nie można mieć dyzuru dzień po dniu");
                return;
            }

            _listaDyzurow.Add(dyzur);
        }

        private bool SprawdzDyzurDzienPoDniu(Dyzur dyzur)
        {

            foreach (Dyzur d in _listaDyzurow)
            {
                if (dyzur.DataRozpoczecia.Date == d.DataZakonczenia.Date.AddDays(1) ||
                    dyzur.DataRozpoczecia.Date == d.DataRozpoczecia.Date.AddDays(-1) ||
                    dyzur.DataRozpoczecia.Date == d.DataZakonczenia.Date)
                {
                    return true;
                }
            }

            return false;
        }

        private int SprawdzLiczbeDyzurowWMiesiacu(Dyzur dyzur)
        {
            int liczbaDyzurowDanyMiesiac = 0;
            int month = dyzur.DataRozpoczecia.Month;
            int year = dyzur.DataRozpoczecia.Year;

            foreach (Dyzur d in _listaDyzurow)
            {
                if (d.DataZakonczenia.Month == month && d.DataZakonczenia.Year == year)
                    liczbaDyzurowDanyMiesiac++;
            }

            return liczbaDyzurowDanyMiesiac;
        }
    }
}
