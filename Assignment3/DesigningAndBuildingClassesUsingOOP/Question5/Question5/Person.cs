﻿namespace Question5
{
    internal abstract class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            protected set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
                }
                age = value;
            }
        }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Description();
        public void Introduce()
        {
            Console.WriteLine($"{Utility.Greeting()}, my name is {Name}.");
        }
        public virtual decimal CalculateSalary()
        {
            return 0;
        }
        public void DisplaySalary()
        {
            Console.WriteLine($"{Name}'s salary: {CalculateSalary():C}");
        }
    }
}