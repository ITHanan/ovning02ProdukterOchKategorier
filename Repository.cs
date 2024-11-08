

namespace ovning02ProdukterOchKategorier
{
    public class Repository<T> where T : IIdentifiable
    {

        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);

        }

        public List<T> GetAll()
        {
            return _items;
        }


        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id)!;
        }

        public void Updater(T newitem)
        {
            var itemThatExisst = GetById(newitem.Id);
            if (itemThatExisst != null)
            {
                int index = _items.IndexOf(itemThatExisst);
                _items[index] = newitem;

                Console.WriteLine("the product has been updated");
            }


        }

        public void Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _items.Remove(item);
            }


        }
    }
}
