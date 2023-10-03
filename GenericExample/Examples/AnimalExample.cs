namespace GenericExample.Examples
{
    public interface IAnimal
    {
        void Say();
    }

    public class Dog : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Bork bork");
        }
    }

    public class Cat : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Cow : IAnimal
    {
        public void Say()
        {
            Console.WriteLine("Moo!");
        }
    }

    public class AnimalExample
    {
        static List<IAnimal> animals = new List<IAnimal>();

        public void Run()
        {
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cow());

            foreach (IAnimal animal in animals)
            {
                if (animal is Dog)
                    Console.WriteLine("Who is a good boy?");

                animal.Say();
            }
        }
    }
}
