using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] stringArray = { "Hello", "How", "Are", "You" };
        Console.WriteLine("Hello, How, Are, You");
        Console.WriteLine("Select an Index of the Array.");
        int index = Convert.ToInt32(Console.ReadLine());
        
        if (index > 3)
        {
            Console.WriteLine("That is out of the index range!");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(stringArray[index]);           
        }

        
        int[] intArray = { 1, 5, 6, 13, 24 };
        Console.WriteLine("1, 5, 6, 13, 24");
        Console.WriteLine("Select an Index of this Array.");
        int index1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(intArray[index1]);

        if (index1 > 4)
        {
            Console.WriteLine("That is out of the index range!");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(intArray[index]);
        }

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Jello");
        stringList.Add("Mellow");
        stringList.Add("Yellow");
        Console.WriteLine("Hello, Jello, Mellow, Yellow");
        Console.WriteLine("Choose an Index for this Array.");
        int index2 = Convert.ToInt32(Console.ReadLine());

        if (index2 > 3)
        {
            Console.WriteLine("That is out of the index range!");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine(stringList[index]);
            Console.Read();
            return;
        }
           
    }
}

