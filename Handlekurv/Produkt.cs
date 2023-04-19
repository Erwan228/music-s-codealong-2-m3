namespace Handlekurv
{
    public class Produkt
    {
        public string Navn { get; private set; }
        public int Pris { get; private set; }
        public int Antall { get; private set; }
        public Produkt(string navn, int pris)
        {
            Navn = navn;
            Pris = pris;
            Antall = 1;
        }
    }
}
