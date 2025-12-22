using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class Pielegniarka : Pracownik
    {

        private readonly List<Dyzur> _listaDyzurow = new List<Dyzur>(); //tworze listę raz, a potem moge ją modyfikować, ale nie nadpisywać


        public Pielegniarka(int id, string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo, List<Dyzur> listaDyzurow) : base(id, imie, nazwisko, pesel, nazwaUzytkownika, haslo)
        {
            if (listaDyzurow != null)
            {
                _listaDyzurow.AddRange(listaDyzurow);
            }
        }

        public List<Dyzur> PokazListeDyzurow
        {
            get
            {
                return _listaDyzurow;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public IReadOnlyList<Pracownik> WyswietlListeLekarzyPielegniarek()
        {
            return Szpital.SzpitalInstance.WyswietlListeLekarzyPielegniarek();

        }

        public void DodajDyzur(Dyzur dyzur)
        {
            if (SprawdzLiczbeDyzurowWMiesiacu(dyzur) >= 10)
            {
                Console.WriteLine("Nie można miec więcej niż 10 dyżurów miesięcznie");
                return;
            }

            if (SprawdzDyzurDzienPoDniu(dyzur))
            {
                Console.WriteLine("Nie można mieć dyzuru dzień po dniu");
                return;
            }

            _listaDyzurow.Add(dyzur);
            Console.WriteLine("Dodano dyżur");
        }

        public IReadOnlyList<Dyzur> PokazDyzurWybranejOsoby(string imie, string nazwisko)
        {
            return Szpital.SzpitalInstance.PokazDyzurWybranejOsoby(imie, nazwisko);

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
                {
                    liczbaDyzurowDanyMiesiac++;
                }

            }

            return liczbaDyzurowDanyMiesiac;
        }
    }
}

