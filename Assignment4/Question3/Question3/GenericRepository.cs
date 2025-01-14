namespace Question3
{
    internal class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> data; // this should be data from data source
        public GenericRepository() 
        {
            data = new List<T>(); // gets data from data source
        }
        public void Add(T item)
        {
            data.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return data;
        }

        public T GetById(int id)
        {
            return data.FirstOrDefault(item => item.Id == id);
        }

        public void Remove(T item)
        {
            data.Remove(item);
        }

        public void Save()
        {
            // call save method of the data source e.g. database save method
        }
    }
}
