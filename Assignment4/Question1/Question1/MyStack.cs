namespace Question1
{
    internal class MyStack<T>
    {
        private Stack<T> stack;
        public MyStack()
        {
            stack = new Stack<T>();
        }
        public int Count() { return stack.Count; }
        public T Pop()
        {
            return stack.Pop();
        }
        public void Push(T item)
        {
            stack.Push(item);
        }
    }
}
