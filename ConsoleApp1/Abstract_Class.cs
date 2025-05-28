using System;

public abstract class Abstractclass
{
    // Abstract class can have abstract methods, which must be implemented by derived classes.
    public abstract void AbstractMethod();

    // Abstract class can also have non-abstract methods.
    public void NonAbstractMethod()
    {
        Console.WriteLine("This is a non-abstract method in an abstract class.");
    }
    // Abstract class can have properties.
    public abstract int AbstractProperty { get; set; }
    // Abstract class can have fields.
    public int field;
    // Abstract class can have constructors.
    public Abstractclass()
    {
        Console.WriteLine("Abstract class.");
        Console.WriteLine("---------------");
        field = 10; // Initializing the field in the constructor.
        Console.WriteLine("This is a constructor of an abstract class.");
        Console.WriteLine("Field value: " + field);
    }
}
public class DerivedClass : Abstractclass
{
    // Implementing the abstract method.
    public override void AbstractMethod()
    {
        Console.WriteLine("This is an implementation of the abstract method.");
    }

    // Implementing the abstract property.
    public override int AbstractProperty { get; set; }

    public DerivedClass()
    {
        Console.WriteLine("This is a constructor of the derived class.");
    }
}   

