namespace Question7
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
        public int Red 
        { 
            get 
            {
                return red;
            } 
            set 
            {
                red = checkValue(value);
            } 
        }
        public int Green 
        { 
            get
            {
                return green;
            }
            set
            {
                green = checkValue(value);
            }
        }
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = checkValue(value);
            }
        }
        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = checkValue(value);
            }
        }
        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        private int checkValue(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}
