using static System.Console;

//Program that takes email address from user and checks for validity
class EmailValidator
{
    //Validator function checks conditions that make email invalid
    public static void Validator(string email)
    {
        //get first character of email address
        char firstChar = email[0];
        //check for number or special character at first position
        if (Char.IsNumber(firstChar) || Char.IsSymbol(firstChar))
        {
            WriteLine("First character of email cannot be number or symbol");
            return;
        }
        //check for '@'
        if (!email.Contains('@'))
        {
            WriteLine("Email must contain '@' symbol");
            return;

        }
        //check for '.com' at end
        if (!email.EndsWith(".com"))
        {
            WriteLine("Email must end with '.com'");
            return;

        }
        //return success message
        else
        {
            WriteLine("Your email is valid!");
            return;
        }
    }

    public static void Main(string[] args)
    {
        WriteLine("Please enter your email address: ");
        string email = ReadLine();
        Validator(email);
    }

}