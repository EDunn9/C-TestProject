// Visual Changes
Console.Title = "C# Demo Program"; // Sets the title of the window to "C# Demo Program"
Console.ForegroundColor = ConsoleColor.Green; // Changes the color of the text to green
Console.WindowHeight = 40; // Sets the window height to 40 lines 

// Visible program outputs and inputs
Console.Write("Enter your name: "); // Prints the text in quotations to the console
string userInput = Console.ReadLine(); // Input line for user input that is saved to a string variable after hitting enter
Console.WriteLine("Thank you " + userInput); // Creates a new line of text that includes what the user typed

// Exit the program
Console.ReadKey(); // Checks for a key press and closes the program on press



