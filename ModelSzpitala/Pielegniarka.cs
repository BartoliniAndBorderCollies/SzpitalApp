using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class Pielegniarka : Pracownik
    {
        [JsonInclude]
        private List<Dyzur> _listaDyzurow = new List<Dyzur>();

        [JsonConstructor]
        protected Pielegniarka()
        {
            // tylko dla deserializacji
        }

        public Pielegniarka(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo, List<Dyzur> listaDyzurow) : base(imie, nazwisko, pesel, nazwaUzytkownika, haslo)
        {
            if (listaDyzurow != null)
            {
                _listaDyzurow.AddRange(listaDyzurow);
            }
        }

        [JsonIgnore]
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

        public string DodajDyzur(Dyzur dyzur)
        {
            if (SprawdzLiczbeDyzurowWMiesiacu(dyzur) >= 10)
            {
                
                return "Nie można mieć więcej niż 10 dyżurów miesięcznie";
            }

            if (SprawdzDyzurDzienPoDniu(dyzur))
            {
                return "Nie można mieć dyżuru dzień po dniu, ani w ten sam dzień!";
               
            }

            _listaDyzurow.Add(dyzur);
            return "Dyżur dodany";
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
                    dyzur.DataRozpoczecia.Date == d.DataZakonczenia.Date ||
                    dyzur.DataRozpoczecia.Date == d.DataRozpoczecia.Date)
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

        public void UsunDyzur(Dyzur dyzur)
        {
            _listaDyzurow.Remove(dyzur);

        }
    }
}

