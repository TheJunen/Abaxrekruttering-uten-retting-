using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abaxrekruttering
{
    internal class Båt : Generell_kjøretøy
    {
        private int MaksfartKnop;
        private int KgBruttotonnasje;

        internal Båt(string kjennetegn, int kweffekt, int maksfartknop, int kgbruttotonnasje) : base(kjennetegn, kweffekt)
        {
            MaksfartKnop = maksfartknop;
            KgBruttotonnasje = kgbruttotonnasje;
        }

        internal Båt() : base("", 2)
        {

        }

        internal void SkrivUtInfo(List <Båt> listeAvBåter)
        {
            foreach (var Item in listeAvBåter)
            {
                Item.SkrivUtInfo();
                Console.WriteLine($" MaksfartKnop:{Item.MaksfartKnop}, KgBruttotonnasje:{Item.KgBruttotonnasje}");
            }
        }

        internal void SpørBåtenOmÅKjøre(List<Båt> listeAvBåt, int index)
        {
            SpørKjøretøyOmÅKjøreEllerFly();
            if (spør == "1")
            {
                Console.WriteLine($"Nå kjører: {listeAvBåt[index].Kjennetegn}");
            }
            else if (spør == "2")
            {
                return;
            }
        }
    }
}
