using System;

// The Program class is the entry point for your application.
class Program
{
    // The Main method is where the program starts executing.
    static void Main()
    {

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
}
