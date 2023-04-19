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
            var handlekurv = new Handlekurv();
            handlekurv.visKurv(handlekurv);
            buy(handlekurv, fursuit);
            buy(handlekurv, duftlys);
            handlekurv.visKurv(handlekurv);

        }
        public static void buy(Handlekurv handleKurv, Produkt product, int count)
        {

        }
        public static void buy(Handlekurv handleKurv, Produkt product)
        {
            handleKurv.Produktliste.Add(product);
            Console.WriteLine($"Du har kjøpt 1 {product.Navn} til {product.Pris}kromer!");
        }
    }
}
