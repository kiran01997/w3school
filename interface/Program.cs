interface IAnimal
{
    public void animalSound();
}

class Dog : IAnimal
{
    public void animalSound() {
        Console.WriteLine(" This is Animal Sound ");
    }
 }

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.animalSound();
    }
}


//Multiple Interface

interface IFirstInterface
{
    void firstInterface();
}

interface ISecondInterface
{
    void secondInterface();
}

class DemoClass : IFirstInterface, ISecondInterface
{
    public void firstInterface() {
        Console.WriteLine(
        "this is first interface");
    }

    public void secondInterface()
    {
        Console.WriteLine("this is second ");
    }
}



class Program1
{
    static void Main(string[] args)
    {
        DemoClass demo = new DemoClass();
        demo.firstInterface();
        demo.secondInterface();
    }
}

