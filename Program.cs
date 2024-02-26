// Visual Changes
Console.Title = "C# Demo Program"; // Sets the title of the window to "C# Demo Program"
Console.ForegroundColor = ConsoleColor.Green; // Changes the color of the text to green

// Visible program outputs and inputs
Console.Write("Enter your name: "); // Prints the text in quotations to the console
string? userInput = Console.ReadLine(); // Input line for user input that is saved to a string variable after hitting enter
Console.WriteLine("Thank you " + userInput +"\n"); // Creates a new line of text that includes what the user typed

// Create methods for executing mathematical operations

// Create a method for executing mathematical operations
static void Add() {
    Console.Write("Please input two numbers that you would like to add\n Number 1: "); 
    int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
    Console.Write(" Number 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number1 + " added by " + number2 + " = " + (number1+number2));
}

// Create a method for executing mathematical operations
static void Subtract() {
    Console.Write("Please input two numbers that you would like to subtract\n Number 1: "); 
    int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
    Console.Write(" Number 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number1 + " subtracted by " + number2 + " = " + (number1-number2));
}

static void Multiply() {
    Console.Write("Please input two numbers that you would like to multiply\n Number 1: "); 
    int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
    Console.Write(" Number 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number1 + " multiplied by " + number2 + " = " + number1*number2);
}

static void Divide() {
    Console.Write("Please input two numbers that you would like to divide\n Number 1: "); 
    int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
    Console.Write(" Number 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(number1 + " divided by " + number2 + " = " + number1/number2);
}


// Creates menu options for user to select
string? choice;
do {
    Console.WriteLine("Select a mathematical operation to apply to two numbers: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
    choice = Console.ReadLine();
    int chosen = Convert.ToInt32(choice);
    switch (chosen) {
        case 1:
            Add();
            break;
        case 2:
            Subtract();
            break;
        case 3:
            Multiply();
            break;
        case 4:
            Divide();
            break;
    }
    }
    while (choice != null);


Console.Write("Please input two numbers that you would like to multiply\n Number 1: "); 
int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
Console.Write(" Number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 + " multiplied by " + number2 + " = " + number1*number2);


// Exit the program
Console.ReadKey(); // Checks for a key press and closes the program on press



