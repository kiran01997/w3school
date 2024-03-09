class Car
{
    public string name = "ford";
    public void honk()
    {
        Console.WriteLine("Zoom Zoom");
    }
}

class Mustang : Car
{
    public int model = 1997;
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.name);
        myObj.honk();
    }
}


// if someone wants to keep the class restricted from getting inherited then sealed keyword is used in place of class
