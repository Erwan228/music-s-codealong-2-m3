namespace Handlekurv
{
    public class Handlekurv
    {
        public List<Produkt> Produktliste;
        public Handlekurv()
        {
            Produktliste = new List<Produkt>();
        }
        public void visKurv(Handlekurv handleKurv)
        {
            if (handleKurv.Produktliste.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom!!!");
                return;
            }
            Console.WriteLine("Handle kurv:");
            int totalBeløp = 0;
            foreach (Produkt produkt in handleKurv.Produktliste)
            {
                Console.WriteLine($"{produkt.Navn} {produkt.Pris}kromer");
                totalBeløp += produkt.Pris;
            }
            Console.WriteLine("Totalbeløp: " + totalBeløp + "kromer");
        }
    }
}
