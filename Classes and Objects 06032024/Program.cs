// creating a class 

class Car // it is good practice to start uppercase when naming a class
{
    string color = "red"; // variables declared inside class are called fields or attributes

    static void Main(string[] args) { 
    Car myObj = new Car();
    Console.WriteLine (myObj.color);
    }
}

// multiple objects 

class Truck
{
    string color = "Blue";
    static void Main(string[] args)
    {
        Truck myObj = new Truck();
        Console.WriteLine (myObj.color);
        Truck myObj2 = new Truck();
        Console.WriteLine (myObj2.color);
    }
}


// multiple classes 

class Airplane
{
   public string color = "red";
}

class Program
{
    static void Main(String[] args)
    {
        Airplane myObj = new Airplane();

        Console.WriteLine(myObj.color);
    }
}


// class members 

// fields and methods inside the class are called members

class MyCar
{
    string color= " red";  
    string name = "safari";
    public void speed()
    {
        Console.WriteLine(" This car runs at 100kmph");
    }

    static void Main(string[] args)
    {
        MyCar myObj = new MyCar();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.name);
        myObj.speed(); 
        
        MyCar myObj1 = new MyCar();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj1.name);
        myObj1.speed();
    }
}

class MyTruck
{
    public string color ;
    string name ;
    public void speed()
    {
        Console.WriteLine(" This car runs at 100kmph");
    }

    static void Main(string[] args)
    {
        MyTruck myObj = new MyTruck();
        myObj.color = "red";
        myObj.name = "safari";
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.name);

        MyTruck myObj1 = new MyTruck();
        myObj1.color = "red";
        myObj1.name = "safari";
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj1.name);
    }
}