using static System.Console;

//Program to calculate how many times a person has voted for president in US
class PresidentialVotes
{
    static int timesVoted;
    const int ageLimit = 18;

    //function to calculate times voted given age
    public static void CalcTimesVoted(int age)
    {
        //check if over age limit
        if (age >= ageLimit)
        {
            timesVoted = (age - 18) / 4;
            WriteLine($"You have voted for {timesVoted} president(s).");
        }
        //return error message if too young to vote
        else
        {
            WriteLine("You are not old enough to vote yet.");
        }
    }

    public static void Main(string[] args)
    {
        WriteLine("Please enter your age: ");
        int age = int.Parse(ReadLine());
        CalcTimesVoted(age);
    }
}