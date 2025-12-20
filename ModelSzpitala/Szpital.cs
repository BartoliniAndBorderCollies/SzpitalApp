using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    internal class Szpital
    {
        //SINGELTON
        private static Szpital _szpital;

        private readonly List<Pracownik> _listaPracownikow = new List<Pracownik>();

        public static Szpital SzpitalInstance
        {
            get
            {
                if (_szpital == null)
                {
                    _szpital = new Szpital();
                }
                return _szpital;
            }
        }

        public IReadOnlyList<Pracownik> DostepDoListyPracownikow
        {
            get
            {
                return _listaPracownikow;
            }
        }


        // prywatny konstruktor - nikt poza klasą Szpital nie może wywołać new Szpital()
        private Szpital()
        {       //administrator startowy
                Administrator administrator = new Administrator("admin", "admin", "00000000001", "admin", "admin");
                _listaPracownikow.Add(administrator);
        }

        public void DodajPracownika(Pracownik pracownik)
        {
            _listaPracownikow.Add(pracownik);
        }


        public void UsunPracownika(String pesel)
        {
            Pracownik? pracownikDoUsuniecia = SzukajPracownikaPoPeselu(pesel);

            if (pracownikDoUsuniecia != null)
            {
                _listaPracownikow.Remove(pracownikDoUsuniecia);
            }
            else
            {
                Console.WriteLine("Nie mozna usunac nieistniejacego pracownika");
                return;

            }
        }

        public string WyswietlListeWszystkichPracownikow()
        {

            StringBuilder sb = new StringBuilder();

            foreach (Pracownik pracownik in DostepDoListyPracownikow)
            {
                sb.AppendLine(pracownik.ToString()); //w innym przypadku zwróciłbym tylko pierwszego pracownika: return pracownik.ToString()

            }
            return sb.ToString();
        }
        private Pracownik? SzukajPracownikaPoPeselu(string pesel)
        {

            foreach (Pracownik pracownik in _listaPracownikow)
            {
                if (pracownik.Pesel == pesel)
                {
                    return pracownik;
                }
            }

            Console.WriteLine("Nie znaleziono pracownika o podanym peselu");
            return null;
        }

        public IReadOnlyList<Pracownik> WyswietlListeLekarzyPielegniarek()
        {
            List<Pracownik> listaLekarzyPielegniarek = new List<Pracownik>();

            foreach (Pracownik pracownik in _listaPracownikow)
            {
                
                if(pracownik is Lekarz || pracownik is Pielegniarka)
                {
                    listaLekarzyPielegniarek.Add(pracownik);
                }
            }

            return listaLekarzyPielegniarek;

        }

        public IReadOnlyList<Dyzur> PokazDyzurWybranejOsoby(string imie, string nazwisko)
        {

            IReadOnlyList<Dyzur> listaDyzurow = new List<Dyzur>();

            foreach (Pracownik pracownik in _listaPracownikow)
            {
                if(pracownik.Imie == imie && pracownik.Nazwisko == nazwisko && pracownik is Lekarz lekarz)
                {
                    listaDyzurow = lekarz.PokazListeDyzurow; 
                }

                if (pracownik.Imie == imie && pracownik.Nazwisko == nazwisko && pracownik is Pielegniarka pielegniarka)
                {
                    listaDyzurow = pielegniarka.PokazListeDyzurow;
                }
            }

            return listaDyzurow.ToList();
        }

        internal bool CzyDyzurMaLekarzTakaSamaSpecjalizacja(Lekarz lekarz, Dyzur dyzur)
        {
            DateTime dataDyzuru = dyzur.DataRozpoczecia.Date;
            Specjalnosc specjalnoscLekarza = lekarz.PokazSpecjalnosc;

            foreach (Pracownik pracownik in _listaPracownikow)
            {
               
                if(pracownik is Lekarz lekarzZListyDyzurow && 
                    lekarzZListyDyzurow.PokazSpecjalnosc == specjalnoscLekarza &&
                    lekarzZListyDyzurow != lekarz)
                {
                    foreach(Dyzur dyzuryLekarzaZListy in lekarzZListyDyzurow.PokazListeDyzurow)
                    {
                        if(dyzuryLekarzaZListy.DataRozpoczecia.Date == dataDyzuru)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;

        }
    }
}
