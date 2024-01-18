using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abaxrekruttering
{
    internal class Fly : Generell_kjøretøy
    {
        private int MeterVingespenn;
        private int TonnLasteevne;
        private int TonnEgenvekt;
        private string Flyklasse;

        internal Fly(string kjennetegn, int kweffekt, int metervingespenn, int tonnlasteevne, int tonnegenvekt, string flyklasse) : base(kjennetegn, kweffekt)
        {
            MeterVingespenn = metervingespenn;
            TonnLasteevne = tonnlasteevne;
            TonnEgenvekt = tonnegenvekt;
            Flyklasse = flyklasse;
        }

        internal Fly() : base("", 0)
        {

        }

        internal void SkrivUtInfo(List <Fly> listeAvFly)
        {
            foreach (var Item in listeAvFly)
            {
                    /*((Fly)Item)*/Item.SkrivUtInfo(); //vet jeg kan endre navn på en av methodene siden de overloader, men test. obs endring: Her vil den alltid velge base method siden det ikke er override.
                    Console.WriteLine(
                    $" MeterVingespenn:{Item.MeterVingespenn}, TonnLasteevne:{Item.TonnLasteevne},"+
                    $" TonnEgenvekt:{Item.TonnEgenvekt}, Flyklasse:{Item.Flyklasse}"
                    );
            }
        }

        internal void SpørFlyetOmÅFly(List<Fly> listeAvFly, int index)
        {
            SpørKjøretøyOmÅKjøreEllerFly();
            if (spør == "1")
            {
                Console.WriteLine($"Nå flyr: {listeAvFly[index].Kjennetegn}");
            }
            else if (spør == "2")
            {
                return;
            }
        }


    }
}
