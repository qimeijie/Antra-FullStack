namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Entity> repository = new GenericRepository<Entity>();
            Entity entity1 = new Entity() { Id = 1 };
            Entity entity2 = new Entity() { Id = 2 };
            repository.Add(entity1);
            repository.Add(entity2);
            foreach (Entity entity in repository.GetAll())
            {
                Console.WriteLine(entity.Id); // 1 2
            }
            repository.Remove(entity1);
            foreach (Entity entity in repository.GetAll())
            {
                Console.WriteLine(entity.Id); // 2
            }
        }
    }
}
