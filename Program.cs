namespace ovning02ProdukterOchKategorier
{
    public class Program
    {
        static void Main(string[] args)
        {

            Repository<Produkt> produktRepository = new Repository<Produkt>();


            var produktRepo = new Repository<Produkt>();


            produktRepo.Add(new Produkt { Id = 1, Namn = "computer", Pris = 1500 });
            produktRepo.Add(new Produkt { Id = 2, Namn = "USB", Pris = 39 });
            produktRepo.Add(new Produkt { Id = 3, Namn = "laptop", Pris = 7000 });



            //Visa produkter

            Console.WriteLine("The available products are:\n ");

            foreach (var produkt in produktRepo.GetAll())
            {
                Console.WriteLine($"Id: {produkt.Id} product: {produkt.Namn}, pris: {produkt.Pris}");
            }

            // Kategorihantering
            var kategoriRepo = new Repository<Kategori>();
            kategoriRepo.Add(new Kategori { Id = 1, Namn = "elctrisity" });

            // Visa kategorier
            foreach (var kategori in kategoriRepo.GetAll())
            {
                Console.WriteLine($"class: {kategori.Namn}");
            }

            //upbate produkt 
            Console.WriteLine("\nproduct befor updating is : ");

            foreach (var produkt in produktRepo.GetAll())
            {
                Console.WriteLine($"Id: {produkt.Id} product: {produkt.Namn}, pris: {produkt.Pris}");
            }

            var updatedProdukt = new Produkt { Id = 1, Namn = "Mobile ", Pris = 13000 };
            produktRepo.Updater(updatedProdukt);

            Console.WriteLine("\nThe Produkt after updating");
            foreach (var produkt in produktRepo.GetAll())
            {
                Console.WriteLine($"Id: {produkt.Id} product: {produkt.Namn}, pris: {produkt.Pris}");

            }

            //delete produkt 
            produktRepo.Remove(3);

            Console.WriteLine("\nproduct efter deleting");

            foreach (var produkt in produktRepo.GetAll())
            {

                Console.WriteLine($"ID: {produkt.Id} produkt name {produkt.Namn} Prise: {produkt.Pris} ");

            }
        }





    }




}




