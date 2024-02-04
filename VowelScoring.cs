using static System.Console;

//Program that scores words/sentences based on vowel usage and frequency
class VowelScoring
{
    //Dictionary to map vowels to designated score
    public static Dictionary<char, int> vowelScores = new()
    {
        {'a', 1}, {'e', 2}, {'i', 3}, {'o', 4}, {'u', 5}, {'y', 9}
    };
        

    //method to take string input and score based on vowels used
    public static int ScoreInput(string input)
    {
        int totalScore = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (vowelScores.TryGetValue(input[i], out int score))
            {
                totalScore += score;
            }
        }
        return totalScore;
    }

    public static void Main(string[] args)
    {
        WriteLine("Enter your word or phrase: ");
        string input = ReadLine().ToLower();
        int finalScore = ScoreInput(input);
        WriteLine($"Your score: {finalScore}");
    }
}