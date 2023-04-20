namespace Handlekurv
{
    internal class Butikk
    {
        public List<Produkt> produkter = new List<Produkt>
            {
                new Produkt("Fursuit", 36000),
                new Produkt("Duftlys", 400),
                new Produkt("Cosplay", 30000),
                new Produkt("Sverd", 100)
            };
        public List<Orderline> handlekurv = new List<Orderline>();
        public void kjørButikk()
        {
            addToCart(produkter[1]);
            showCart();
            addToCart(produkter[0]);
            showCart();
            addToCart(produkter[1], 5);
            showCart();
            addToCart(produkter[2], 1);
            showCart();
            addToCart(produkter[3], 5);
            showCart();
        }
        public void addToCart(Produkt produkt, int antall = 1)
        {
            bool alreadyExists = false;
            foreach (Orderline orderline in handlekurv)
            {
                if (orderline.Product.Navn == produkt.Navn)
                {
                    alreadyExists = true;
                    orderline.AddItem(antall);
                }
            }
            if (!alreadyExists)
            {
                var bestilling = new Orderline(produkt, antall);
                handlekurv.Add(bestilling);
            }
            Console.WriteLine($"Du har lagt til {antall} x {produkt.Navn}");
            Console.WriteLine();
        }
        public void showCart()
        {
            int totalBeløp = 0;
            foreach (var orderline in handlekurv)
            {
                Console.WriteLine($"{orderline.Antall} {orderline.Product.Navn}, {orderline.Product.Pris} pr produkt = {orderline.GetTotal()}");
                totalBeløp += orderline.GetTotal();
            }
            Console.WriteLine("Totalbeløp er " + totalBeløp);
            Console.WriteLine();
        }
    }
}
