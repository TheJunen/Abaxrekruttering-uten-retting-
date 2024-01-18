namespace Oppgave_Abaxrekruttering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biler:");
            Bil bil = new Bil();
            List<Bil> ListeAvBiler = new List<Bil>();
            ListeAvBiler.AddRange(new List<Bil>
            {
                new Bil("NF123456", 147, 200, "Grønn", "Lett Kjøretøy"),
                new Bil("NF654321", 150, 195, "Blå", "Lett Kjøretøy"),
            });
            bil.SkrivUtInfo(ListeAvBiler);
            bil.SammenligneBiler(ListeAvBiler, 0, 1);
            bil.SpørBilenOmÅKjøre(ListeAvBiler, 0);
            Console.WriteLine("Flyer:");
            Fly fly = new Fly();
            List<Fly> ListeAvFly = new List<Fly>();
            ListeAvFly.AddRange(new List<Fly>
            {
                new Fly("LN1234", 1000, 30, 2, 10, "jetfly")
            });
            fly.SkrivUtInfo(ListeAvFly);
            fly.SpørFlyetOmÅFly(ListeAvFly, 0);
            Console.WriteLine("Båter:");
            Båt båt = new Båt();
            List<Båt> ListeAvBåter = new List<Båt>();
            ListeAvBåter.AddRange(new List<Båt>
            {
                new Båt("ABC123", 100, 30, 500),
                new Båt("DOF999", 80, 25, 400)
            });
            båt.SkrivUtInfo(ListeAvBåter);
            båt.SpørBåtenOmÅKjøre(ListeAvBåter, 0);
        }
    }
}