// constructors are basically special methods and it saves times and the advantage of creating constructor is that it saves time 

// it can be used to set initial values for the fields 

class Car
{
    public string color ;
    public Car(string colorName)
    {
     color = colorName;       
    }

    static void Main(string[] args)
    {
        Car newObj = new Car("Red");
        Console.WriteLine(newObj.color);
    }
}


// we can use as many parameters as we want 

class Car1
{
    public string color;
    public string name;
    public Car1(string colorName , string nameOfCar)
    {
        color = colorName;
        name = nameOfCar;
    }

    static void Main(string[] args)
    {
        Car1 newObj = new Car1("Red","Safari");
        Console.WriteLine(newObj.color + newObj.name);
    }
}


//properties are declared to achieve encapsulisation means hiding sensitive information from the users 


class Car2
{
    public string Name { get; set; }
}

class program
{
    static void Main(string[] args)
    {
        Car2 car2 = new Car2();
        Console.WriteLine(car2.Name);

    }
}


// enczpsulaton reduces the chances of messing up your own code or your code to get messed up by someone else 
