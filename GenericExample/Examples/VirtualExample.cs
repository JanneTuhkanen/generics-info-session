namespace GenericExample.Examples
{
    public abstract class Computer
    {

        public virtual void StartComputer()
        {
            Console.WriteLine("Screen comes to life");
        }
    }

    public class OldComputer : Computer
    {
    }

    public class ModernLaptop : Computer
    {        
    }

    public class VirtualExample
    {
        public void Run()
        {
            var oldComputer = new OldComputer();

            oldComputer.StartComputer();
        }
    }
}
