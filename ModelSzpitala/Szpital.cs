using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala
{
    public class Szpital
    {
        //SINGELTON
        private static Szpital? _szpital;

        private int _ostatnieId = 1;

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

        public List<Pracownik> DostepDoListyPracownikow
        {
            get
            {
                return _listaPracownikow;
            }

            set
            {
                _listaPracownikow.Clear();
                if (value != null)
                    _listaPracownikow.AddRange(value);
            }
        }

        public Szpital()
        {
            // PUSTY – tylko dla deserializacji
        }



        //Dla deserializacji

        private void DodajAdministratoraStartowego()
        {
            if (_listaPracownikow.Count == 0)
            {
                _listaPracownikow.Add(
                    new Administrator("admin", "admin", "00000000001", "admin", "admin"));
            }
        }


        public static void UstawInstancje(Szpital szpital)
        {
            _szpital = szpital;
        }


        public static void InicjalizujDomyslnie()
        {
            _szpital = new Szpital();
            _szpital.DodajAdministratoraStartowego();
        }


        public void OdbudujOstatnieId()
        {
            if (_listaPracownikow.Count == 0)
            {
                _ostatnieId = 1;
            }
            else
            {
                _ostatnieId = _listaPracownikow.Max(p => p.Id) + 1;
            }
        }

        //--------------------------------------------------------------------------------------------------


        public void DodajPracownika(Pracownik pracownik)
        {
            pracownik.Id = _ostatnieId++;
            _listaPracownikow.Add(pracownik);
        }


        public void UsunPracownika(String pesel)
        {
            Pracownik? pracownikDoUsuniecia = SzukajPracownikaPoPeselu(pesel);

            if (pracownikDoUsuniecia != null)
            {
                _listaPracownikow.Remove(pracownikDoUsuniecia);
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

                if (pracownik is Lekarz || pracownik is Pielegniarka)
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
                if (pracownik.Imie == imie && pracownik.Nazwisko == nazwisko && pracownik is Lekarz lekarz)
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
            Specjalnosc specjalnoscLekarza = lekarz.Specjalnosc;

            foreach (Pracownik pracownik in _listaPracownikow)
            {

                if (pracownik is Lekarz lekarzZListyDyzurow &&
                    lekarzZListyDyzurow.Specjalnosc == specjalnoscLekarza &&
                    lekarzZListyDyzurow != lekarz)
                {
                    foreach (Dyzur dyzuryLekarzaZListy in lekarzZListyDyzurow.PokazListeDyzurow)
                    {
                        if (dyzuryLekarzaZListy.DataRozpoczecia.Date == dataDyzuru)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;

        }

        public Pracownik? Zaloguj(string user, string haslo)
        {
            foreach (Pracownik pracownik in _listaPracownikow)
            {
                if (pracownik.NazwaUzytkownika == user && pracownik.SprawdzHaslo(haslo))
                {
                    return pracownik;
                }

            }
            return null;
        }

        public Pracownik? SzukajPracownika(string imie, string nazwisko)
        {

            foreach (Pracownik pracownik in _listaPracownikow)
            {
                if (pracownik.Imie == imie && pracownik.Nazwisko == nazwisko)
                {

                    return pracownik;
                }
            }
            return null;
        }
    }
}
