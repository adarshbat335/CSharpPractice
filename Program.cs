using System;



class Program
{
    // The Main method is where the program starts executing.
    static void Main()
    {

        // for type casting follow this 
        //  Char To Int To Long To Float To Double(smaller to larger data type)
        // called as implicit casting(automatic-no data loss happens here)
        // opposite is explicit casting(manual-data loss may happen here)
        int number = 10;
        double doubleNumber = number; // implicit casting
        Console.WriteLine("implicit casting from int to double:" + doubleNumber);
        double number2 = 9.5444;
        int intNumber = (int)number2; // explicit casting
        Console.WriteLine("explicit casting from double to int:" + intNumber);
        Console.WriteLine("how many dairymilk do you want");
        string Dairymilk = Console.ReadLine();
        Console.WriteLine("i will give" + Convert.ToInt32(Dairymilk) + 4);
        // as  writeline returns a string we converted the dairymilk to integer
        //but as + concatenates it will give 44.
        //as it takes the i will give as a string so essentially our dailymilk also becomes a string
        //to avoid this we can use braces so that it does the addition first and then 
        // concatenates the string in the beginning as follows
        Console.WriteLine("i will give:" + (Convert.ToInt32(Dairymilk) + 4));
    }
}