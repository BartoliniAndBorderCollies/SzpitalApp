using ModelSzpitala.Security;
using System.Text.Json.Serialization;

namespace ModelSzpitala
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Lekarz), "lekarz")]
    [JsonDerivedType(typeof(Pielegniarka), "pielegniarka")]
    [JsonDerivedType(typeof(Administrator), "administrator")]
    public abstract class Pracownik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; } //bo 11 znakowy (A int jest 10) poza tym moze zaczynac sie od 0 a int obcina zera
        public string NazwaUzytkownika { get; set; }
        public string HashHasla { get; set; }
        public string Salt { get; set; }

        [JsonIgnore]
        public virtual string OpisDoComboBoxu
        {
            get
            {
                return $"{Imie} {Nazwisko} (PESEL: {Pesel})";
            }
        }


        protected Pracownik()
        {
            // tylko dla deserializacji
        }


        public Pracownik(string imie, string nazwisko, string pesel, string nazwaUzytkownika, string haslo)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            UstawPesel(pesel);
            NazwaUzytkownika = nazwaUzytkownika;
            UstawHaslo(haslo);
        }

        private void UstawPesel(String pesel)
        {
            if (string.IsNullOrWhiteSpace(pesel))
                throw new ArgumentException("Pesel nie może być pusty.");

            if(!pesel.All(char.IsDigit))
                throw new ArgumentException("Pesel nie może zawierać liter");

            if (pesel.Length != 11)
                throw new ArgumentException("PESEL musi mieć dokładnie 11 cyfr.");

            Pesel = pesel;
        }

        private void WalidujHaslo(string haslo)
        {

            if (string.IsNullOrWhiteSpace(haslo))
                throw new ArgumentException("Hasło nie może być puste.");

            if (haslo.Length < 6)
                throw new ArgumentException("Hasło nie może być krótsze niż 6 znaków.");

            if (!haslo.Any(char.IsUpper))
                throw new ArgumentException("Hasło musi zawierać co najmniej 1 wielką literę.");

            if (!haslo.Any(char.IsDigit))
                throw new ArgumentException("Hasło musi zawierać co najmniej 1 cyfrę.");
        }

        public void UstawHaslo(string haslo)
        {
            WalidujHaslo(haslo);

            Salt = PasswordHasher.GenerateSalt();
            HashHasla = PasswordHasher.HashPassword(haslo, Salt);
        }

        public bool SprawdzHaslo(string haslo)
        {
            var hash = PasswordHasher.HashPassword(haslo, Salt);
            return hash == HashHasla;
        }

        public override string ToString()
        {
            return $"{Imie}, {Nazwisko}, ({GetType().Name})";
        }


    }
}
