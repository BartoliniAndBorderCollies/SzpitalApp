namespace ModelSzpitala
{
    public abstract class Pracownik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; } //bo 11 znakowy (A int jest 10) poza tym moze zaczynac sie od 0 a int obcina zera
        public string NazwaUzytkownika { get; set; }
        public string Haslo { get; set; }

        public Pracownik(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            NazwaUzytkownika = nazwaUzytkownika;
            Haslo = haslo;

        }

        public override string ToString()
        {
            return $"{Imie}, {Nazwisko}, ({GetType().Name})";
        }


    }
}
