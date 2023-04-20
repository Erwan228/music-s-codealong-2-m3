namespace Handlekurv
{
    internal class Orderline
    {
        public Produkt Product { get; }
        public int Antall { get; private set; }
        public Orderline(Produkt produkt, int antall = 1)
        {
            Product = produkt;
            Antall = antall;
        }
        public void AddItem(int itemsToAdd = 1)
        {
            Antall += itemsToAdd;
        }
        public int GetTotal()
        {
            return Product.Pris * Antall;
        }


    }
}


