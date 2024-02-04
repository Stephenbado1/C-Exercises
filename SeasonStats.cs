using static System.Console;

//Program that takes scores from user and generates common stats
class SeasonStats
{
    //method to calculate and display desired stats
    public static void StatCalc(List<int> scores)
    {
        int sum = scores.Sum();
        double avg = scores.Average();
        int min = scores.Min();
        int max = scores.Max();
        WriteLine($"\nSeason Low: {min}\n" +
                  $"Season High: {max}\n" +
                  $"Season Average: {avg:f2}\n" +
                  $"Season Total: {sum}");
    }

    public static void Main(string[] args)
    {
        int score = new();
        int game = 1;
        List<int> scores = new();
        //while loop to get unlimited user input scores and store in list
        while (score != -1)
        {
            WriteLine($"Enter score for game {game} (Enter '-1' when done):");
            score = int.Parse(ReadLine());
            if (score == -1) break;
            scores.Add(score);
            game++;
        }
        StatCalc(scores);
    }
}