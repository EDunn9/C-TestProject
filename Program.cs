// Visual Changes
Console.Title = "C# Demo Program"; // Sets the title of the window to "C# Demo Program"
Console.ForegroundColor = ConsoleColor.Green; // Changes the color of the text to green
Console.WindowHeight = 40; // Sets the window height to 40 lines 

// Visible program outputs and inputs
Console.Write("Enter your name: "); // Prints the text in quotations to the console
string userInput = Console.ReadLine(); // Input line for user input that is saved to a string variable after hitting enter
Console.WriteLine("Thank you " + userInput +"\n"); // Creates a new line of text that includes what the user typed
Console.Write("Please input two numbers that you would like to multiply\n Number 1: "); 
int number1 = Convert.ToInt32(Console.ReadLine()); // Converts user string input into an integer and saves as int variable
Console.Write(" Number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number1 + " multiplied by " + number2 + " = " + number1*number2);


// Exit the program
Console.ReadKey(); // Checks for a key press and closes the program on press



