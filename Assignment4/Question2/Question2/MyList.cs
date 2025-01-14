namespace Question2
{
    internal class MyList<T>
    {
        private List<T> list;
        public MyList() { 
            list = new List<T>();
        }
        public void Add(T element) 
        { 
            list.Add(element);
        }
        public T Remove(int index) 
        {
            if (index >= list.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            T element = list[index];
            list.RemoveAt(index);
            return element;
        }
        public bool Contains(T element) 
        {
            return list.Contains(element);
        }
        public void Clear() 
        {
            list.Clear();
        }
        public void InsertAt(T element, int index) 
        { 
            list.Insert(index, element);
        }
        public void DeleteAt(int index) 
        { 
            list.RemoveAt(index);
        }
        public T Find(int index) 
        {
            if (index >= list.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            return list[index];
        }
    }
}
