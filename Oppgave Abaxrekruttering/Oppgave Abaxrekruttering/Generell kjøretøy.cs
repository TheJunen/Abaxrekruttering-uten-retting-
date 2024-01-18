using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oppgave_Abaxrekruttering
{
    internal class Generell_kjøretøy
    {
        public string Kjennetegn;
        public int KwEffekt;
        protected string kjøre_fly => (this.GetType() == typeof(Båt) || this.GetType() == typeof(Bil)) ? "kjøre" : "fly";
        protected string spør;
        public Generell_kjøretøy(string kjennetegn, int kweffekt)
        {
            Kjennetegn = kjennetegn;
            KwEffekt = kweffekt;
        }

        protected void SkrivUtInfo()
        {
            Console.WriteLine($"Kjennetegn:{Kjennetegn}, KwEffekt:{KwEffekt},");
        }

        protected void SpørKjøretøyOmÅKjøreEllerFly()
        {
            Console.WriteLine(
                $"Velkommen til kjøring av {this.GetType().Name} Trykk " +
                $"1 for å {kjøre_fly}, 2 for å ikke {kjøre_fly}");
            spør = Console.ReadLine();

        }
    }
}
