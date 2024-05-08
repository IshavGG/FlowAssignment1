using System;

public class Base
{
    public Base()
    {
        Console.WriteLine("ctor from Base class with Name");
    }


    public virtual void DoWork()
    {
        Console.WriteLine("DoWork from Base class");
    }

}

public class A : Base
{
    public A()
    {
        Console.WriteLine("ctor from A class with Name");
    }

    public virtual void DoWork()
    {
        Console.WriteLine("DoWork from A class");
    }
}

// method hiding concept -> 


public class B : A
{
    public B()
    {
        Console.WriteLine("ctor from B class with Name");
    }

    public new void DoWork()
    {
        Console.WriteLine("DoWork from B class");
    }
}

