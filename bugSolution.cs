public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //Check to prevent division by zero
        if (MyProperty == 0)
        {
            Console.WriteLine("Cannot divide by zero. Returning default value.");
            return; // Or throw a custom exception with more context
        }

        int result = 10 / MyProperty;
        Console.WriteLine(result);
    }
} 