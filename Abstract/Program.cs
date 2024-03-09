abstract class Animal
{
    public abstract void animalSound();
    public void sheep()
    {
        Console.WriteLine(" The sheep say meeheh meeheh");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("This is Animal Sound");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myObj = new Dog();
        myObj.animalSound();
        myObj.sheep();
    }
}