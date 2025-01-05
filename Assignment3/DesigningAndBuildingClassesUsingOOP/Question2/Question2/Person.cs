namespace Question2
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public abstract void Description();

    }
}
