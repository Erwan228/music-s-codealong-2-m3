namespace Handlekurv
{
    public class Butikk
    {
        public string Name { get; private set; }
        public Butikk()
        {
            Name = "Erwans nichebutikk";
        }
        public void runShop()
        {
            var fursuit = new Produkt("Fursuit", 36000);
            var sverd = new Produkt("Sverd", 500);
            var duftlys = new Produkt("Duftlys", 400);
            var cosplay = new Produkt("Cosplay", 30000);
        }
    }
}
