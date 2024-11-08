namespace ovning02ProdukterOchKategorier
{
    public class Produkt : IIdentifiable

    {


        public int Id { get; set; }

        public string Namn { get; set; }


        public double Pris { get; set; }

    }
}
