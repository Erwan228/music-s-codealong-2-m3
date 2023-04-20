namespace Handlekurv
{
    internal class Orderline
    {
        public Produkt _Produkt { get; }
        public int Antall { get; private set; }
        public Orderline(Produkt produkt, int antall = 1)
        {
            _Produkt = produkt;
            Antall = antall;
        }
    }
}
