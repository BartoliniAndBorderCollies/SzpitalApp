using ModelSzpitala;
using ModelSzpitala.Utils;

namespace SzpitalApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Szpital? wczytanySzpital = SzpitalSerializer.Wczytaj();

            if(wczytanySzpital != null)
            {
                wczytanySzpital.OdbudujOstatnieId();
                Szpital.UstawInstancje(wczytanySzpital);
            }
            else
            {
                Szpital.InicjalizujDomyslnie();
            }



                Application.Run(new LoginForm());
        }
    }
}