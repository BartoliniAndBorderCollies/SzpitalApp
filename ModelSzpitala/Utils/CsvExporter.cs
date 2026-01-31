using ModelSzpitala.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSzpitala.Utils
{
    public static class CsvExporter
    {

        public static void EksportujHistorieLogowan(IReadOnlyList<ZdarzenieLogowania> ListaLogowan, string sciezkaDoZapisu)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Data;User;Sukces");

            foreach (ZdarzenieLogowania logowanie in ListaLogowan)
            {
                string linia = $"{logowanie.DataLogowania};" + $"{logowanie.NazwaUsera};" + $"{logowanie.Sukces}";
                stringBuilder.AppendLine(linia);

            }

            File.WriteAllText(sciezkaDoZapisu, stringBuilder.ToString(), Encoding.UTF8);
        }

        public static void EksportujListeDyzurowDanejOsoby(IReadOnlyList<Dyzur> listaDyzurow, string sciezkaDoZapisu, Pracownik pracownik)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Pracownik; Data_rozpoczecia; Data_zakonczenia");

            foreach (Dyzur dyzur in listaDyzurow)
            {
                string linia = $"{pracownik.NazwaUzytkownika};" + $"{dyzur.DataRozpoczecia};" + $"{dyzur.DataZakonczenia}";
                stringBuilder.AppendLine(linia);

            }

            File.WriteAllText(sciezkaDoZapisu, stringBuilder.ToString(), Encoding.UTF8);
        }
    }
}
