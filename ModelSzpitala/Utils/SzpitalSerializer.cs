using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace ModelSzpitala.Utils
{
    public static class SzpitalSerializer
    {

        private static readonly string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"SzpitalApp");

        private static readonly string FilePath = Path.Combine(FolderPath, "szpital.json");

        public static void Zapisz(Szpital szpital)
        {

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            var niceFormat = new JsonSerializerOptions
            {
                WriteIndented = true, //nadaje ładny format JSON-owi
            };

            string json = JsonSerializer.Serialize(szpital, niceFormat);
            File.WriteAllText(FilePath, json);
        }


        public static Szpital? Wczytaj()
        {
            if (!File.Exists(FilePath))
              return null;

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<Szpital>(json);
            
        }
    }
}
