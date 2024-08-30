Code inside a console application:

```csharp
static void Main(string[] args)
{
    TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());
    textWriter.WriteLine("Hello, World!");
    textWriter.Flush();
}
```

# Task
Modify this code such that any string passed should be written to the Stream in lower case. So the output in this case should instead read: **hello, world!**

# Do you see inheritance and polymorphism?
Yes, there is inheritence with LowerStreamWriter, StreamWriter, TextWriter(Abstract Class in .NET) and polymorphism in function WriteLine. 

# Design
Classes - TextWriter(Abstract Class), StreamWriter(Inherits TextWriter), LowerStreamWriter(Inherits StreamWriter).

All three contains WriteLine but in subclasses it overrides the same function of the base class.
![Class Diagram](https://github.com/Harikak09/LowerCaseStreamWriter/blob/master/Image/class_diagram.jpg?raw=true)





