/***************************************
 * 
 * FileName     : Program.cs
 * 
 * Author       : Karumudi Harika
 * 
 * Project      : HelloWorld
 * 
 * Description  : String passed should be written to the stream in lower case.
 * 
 * *************************************/

/// <summary>
/// A LowerStreamWriter class is created which inherits StreamWriter.
/// </summary>
/// <returns>A lower case stream</returns>
public class LowerStreamWriter : StreamWriter
{
    //A constructor which passes the stream of type Stream to its base class
    public LowerStreamWriter(Stream stream) :
        base(stream){ }

    /// <summary>
    /// A function to convert the string into lower case string.
    /// </summary>
    /// <param name="value"></param>
    public override void WriteLine(string value)
    {
        //Coverts to lower case.
        base.WriteLine(value.ToLower());
    }

}
public class Program
{
    /// <summary>
    /// Main program to create a instance of LowerStreamWriter which is a subclass of StreamWriter and StreamWriter is subclass of TextWriter.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        TextWriter textWriter = new LowerStreamWriter(Console.OpenStandardOutput());

        textWriter.WriteLine("Hello, World!");

        textWriter.Flush();
    }
}
