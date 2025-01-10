public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //This is where the bug might occur
        if (MyProperty == 0) 
        {
            throw new DivideByZeroException("MyProperty cannot be zero.");
        }

        int result = 10 / MyProperty;
        Console.WriteLine(result);
    }
}