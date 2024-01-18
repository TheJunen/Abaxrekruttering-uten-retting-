using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abaxrekruttering
{
    internal class Bil : Generell_kjøretøy
    {
        private string Registreringsnummer;
        private int MaksfartIKmITimen;
        private string Farge;
        private string Type;

        internal Bil(string registreringsnummer, int kweffekt, int maksfartikmitimen, string farge, string type) : base("", kweffekt)
        {
            Registreringsnummer = registreringsnummer;
            MaksfartIKmITimen = maksfartikmitimen;
            Farge = farge;
            Type = type;
        }

        internal Bil() : base("", 0)
        {

        }

        internal void SkrivUtInfo(List <Bil> listeAvBiler)
        {
            foreach (var Item in listeAvBiler)
            {
                Console.WriteLine(
                $"Registreringsnummer:{Item.Registreringsnummer}, KwEffekt:{Item.KwEffekt}," +
                $" MaksfartIKmITimen:{Item.MaksfartIKmITimen}, Farge:{Item.Farge}, Type:{Item.Type}");
            }
        }

        internal void SammenligneBiler(List<Bil> listeAvBiler, int index1, int index2)
        {
            Console.WriteLine(
                $"bil 1 reg. nr:{listeAvBiler[index1].Registreringsnummer} | bil 2 reg. nr:{listeAvBiler[index2].Registreringsnummer}" +
                $" bil 1 KwEffekt:{listeAvBiler[index1].KwEffekt} | bil 2 KwEffekt:{listeAvBiler[index2].KwEffekt}" +
                $" bil 1 MaksfartIKmITimen:{listeAvBiler[index1].MaksfartIKmITimen} | bil 2 MaksfartIKmITimen:{listeAvBiler[index2].MaksfartIKmITimen}" +
                $" bil 1 Farge:{listeAvBiler[index1].Farge} | bil 2 Farge:{listeAvBiler[index2].Farge}" +
                $" bil 1 Type:{listeAvBiler[index1].Type} | bil 2 Type:{listeAvBiler[index2].Type}"
                ); 
        }

        internal void SpørBilenOmÅKjøre(List<Bil> listeAvBil, int index)
        {
            SpørKjøretøyOmÅKjøreEllerFly();
            if (spør == "1")
            {
                Console.WriteLine($"Nå kjører: {listeAvBil[index].Registreringsnummer}");
            }
            else if (spør == "2")
            {
                return;
            }
        }
    }
}
