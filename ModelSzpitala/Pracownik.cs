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
        public string Salt {  get; set; }

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
            Pesel = pesel;
            NazwaUzytkownika = nazwaUzytkownika;
            UstawHaslo(haslo);
        }

        public void UstawHaslo(string haslo)
        {
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
