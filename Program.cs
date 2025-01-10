string? readResult = null;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10:");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        int numericValue = 0;
        validNumber = int.TryParse(readResult, out numericValue);

        if (validNumber == false)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
        else if (numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
            validNumber = false;
        }
        else
        {
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
            validNumber = true;
        }
    }
} while (validNumber == false);