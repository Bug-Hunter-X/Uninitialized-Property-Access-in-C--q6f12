public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // Initialize MyProperty in the constructor
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing MyProperty after initialization
        Console.WriteLine(MyProperty);
    }
}

//Alternative solution with default value
public class ExampleClass2
{
    public int MyProperty { get; set; } = 0;

    public ExampleClass2()
    {
        //MyProperty is already set to 0
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty);
    }
} 