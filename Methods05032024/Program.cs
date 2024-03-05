//method is a block of code which can be defined once and can be used multiple times, and it runs only when it is called

class Program
{
    static void MyMethod()
    {
        Console.WriteLine("Hey This is Learner!");
    }

    static void Main(string[] args)
    {
        MyMethod();
    }
}

//method parameters " parameters are the variables passed inside the method
// parameters are specified after the Method name
class Program1
{
    static void MyMethod(string fname)// here fname is parameter 
    {
        Console.WriteLine(fname + "Deep Singh");
    }

    static void Main(string[] args)
    {
        MyMethod("Kiran");  // when parameter is defined inside the method it is called arguement
    }
}

// we can define multiple parameters

class Program2
{
    static void MyMethod(string name , int age )
    {
        Console.WriteLine(name + "is" + age);
    }

    static void Main(string[] args)
    {
        MyMethod("kirandeep", 25);// here same number of arguement must be passed as parameters and must be passed in same order
    }
}

//Default parameters

class Program3
{
    static void MyMethod(string country = " India ")
    {
        Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
        MyMethod();
        MyMethod("sweden");
    }
}

// return values 

// if we want our method to return some value then we will not use void then we will use int, double etc 
class Program4
{
    static int MyMethod(int a)
    {
        return a + 5; // here we have to define retuen value inside the method   
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(3));
    }
}

class Program5
{
    static int MyMethod(int a, int b)
    {
        return a + b;   
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(3,5));
    }
}


class Program6
{
    static int MyMethod(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int c = MyMethod(3,5);
        Console.WriteLine(c);
    }
}


//Method Overloading
class Program7
{
    static int MyMethod(int a, int b)
    {
        return a + b;
    }
    static double MyMethod(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int myNum1 = MyMethod(3,5);  
        double myNum2 = MyMethod(3.5,5.4);
        Console.WriteLine(myNum1);
        Console.WriteLine(myNum2);  
    }
}