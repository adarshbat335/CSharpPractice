using System;

// The Program class is the entry point for your application.
class Program
{
    // The Main method is where the program starts executing.
    static void Main()
    {
<<<<<<< HEAD
        // --- Floating-Point Data Types (Numbers with decimals) ---

        // float: A 32-bit floating-point type with 6-9 significant digits of precision.
        // It requires an 'f' suffix to be a float.
        float myFloat = 1.12345678f;
        Console.WriteLine($"This is a float: {myFloat}");

        // double: A 64-bit floating-point type with 15-17 significant digits of precision.
        // It is the default for decimal numbers, so no suffix is needed.
        // The number will be rounded because a double can't store this many digits accurately.
        double myDouble = 1.123456789123456789123456789;
        Console.WriteLine($"This is a double: {myDouble}");

        // --- Integer Data Types (Whole Numbers) ---

        // long: A 64-bit integer that can store very large numbers.
        // It can hold values from -9 quintillion to +9 quintillion.
        long largeNumber = 3123456789L; // The 'L' suffix is a good practice for long literals.
        Console.WriteLine($"This is a long: {largeNumber}");

        // int: A 32-bit integer.
        // Its range is from -2,147,483,648 to 2,147,483,647.
        // The number below, 3,123,456,789, is outside this range.
        // This line will cause a compile-time error because the value is too large.
        // Uncommenting this line will break the code!
        // int outOfRangeNumber = 3123456789;

        // An int variable with a value that fits in its range.
        int numberThatFits = 2123456789;
        Console.WriteLine($"This is a valid int: {numberThatFits}");


        // --- Console Methods ---
        // Console.WriteLine() is an overloaded method that can display many data types. 
        //It acts like a translator, converting values (like an integer) into a string representation (text in quotes) for display.
        Console.WriteLine("Hello, batman!");

        //the char data type is used to store a single character
        //it is enclosed in single quotes
        //A char is stored as a 16-bit integer representing its Unicode value.
        // For instance, the character 'A' is stored as the number 65
        // random: when i store a char in an int variable it will store its unicode value 
        char Adarshv = 'b';
        Console.WriteLine(Adarshv);
        int Adarsh = 'b';
        Console.WriteLine(Adarsh);
        char Adarshd = '2';
        Console.WriteLine(Adarshd);


        // the bool data type can hold only two values:true or false and is used with conditions. 
        // bool takes 1 bit
        bool isadarshcoding = true;
        Console.WriteLine(isadarshcoding);
        ;
        if (isadarshcoding)
        {
            Console.WriteLine("Adarsh is coding");
        }
        else
        {
            Console.WriteLine("Adarsh is not coding");
        }
        //up until now we studied the value data types that stores the values 
        //whereas there are reference data types that store the address of the values like string,object and array
        /*
        bool: 1 bit
        char: 2 bytes (16 bits)
        int: 4 bytes (32 bits)
        float: 4 bytes (32 bits)
        double: 8 bytes (64 bits)
        long: 8 bytes (64 bits)
        */



    }

=======

        // --- Displaying Text to the Console ---

        // Console.WriteLine(): Displays text and then moves the cursor to the next line.
        Console.WriteLine("Hello, World!");

        // Console.Write(): Displays text, but the cursor remains on the same line.
        Console.Write("Hello, World!");

        // Because the previous line used Console.Write(), "Good Work" appears on the same line.
        Console.WriteLine("Good Work");

        // This line pauses the program to allow you to see the output from the above commands.
        // It waits for you to press Enter before continuing.
        Console.ReadLine();

        // --- Reading a Line of User Input ---

        // Console.ReadLine(): Reads an entire line of input from the user until the Enter key is pressed.
        // The input is always returned as a string.
        Console.WriteLine("What's your name?"); // Prompts the user for input.
        string name = Console.ReadLine(); // Stores the user's input in the 'name' variable.
        Console.WriteLine("Hello " + name); // Displays a greeting with the user's input.

        // This second ReadLine() call keeps the console window open at the end of the program,
        // allowing you to see all the output before the window closes.(in the older versions console used to close when the program excution ends)
        Console.ReadLine();

        // --- Reading a Single Character of User Input ---

        // Console.Read(): Reads a single character from the console.even if you write alpha it will read only a.
        // The value is returned as an integer, representing its ASCII value (e.g., 'a' is 97).
        Console.WriteLine("Press your favorite alphabet");
        int alphabet = Console.Read();

        // The output will display the integer ASCII value of the character you typed.
        Console.WriteLine("Your favorite alphabet is " + alphabet);

        //remember:the readline method returns an string and the read method returns an integer(ascii value of the character)

    }
>>>>>>> origin/main
}
