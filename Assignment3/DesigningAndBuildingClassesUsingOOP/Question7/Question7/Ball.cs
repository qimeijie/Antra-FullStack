namespace Question7
{
    internal class Ball
    {
        private int size;
        private readonly Color color;
        public int Size
        {
            get { return size; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size must be greater than 0.");
                }
                size = value;
            }
        }
        public int ThrowCount { get; set; }
        public Ball(int size, Color color)
        {
            Size = size;
            this.color = color ?? throw new ArgumentNullException(nameof(color));
            ThrowCount = 0;
        }
        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                ThrowCount++;
            }
        }

    }
}
