internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

using system;
var recordList = new List<MyClass>(Dog);
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new MyClass(Dog);

            Console.WriteLine("Enter the value for ");
            myClass.myProperty = Console.ReadLine();

            recordList.Add(myClass);
        }
    }
}

public class Dog
{  
    public string Name {get; set; }
    public int Age {get; set; }

}

// Print out the list of records using Console.WriteLine()