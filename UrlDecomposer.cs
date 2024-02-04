using static System.Console;

//Program that takes URL as input and breaks up components into string array
class UrlDecomposer
{
    //Decomposer function performs desired formatting and returns url as string array
    public static string[] Decomposer(string url)
    {
        //remove 'www.', replace '-' with whitespace, and split array elements at '/'
        string[] newUrl = url[4..].Replace('-', ' ').Split('/');
        return newUrl;
    }

    public static void Main(string[] args)
    {
        WriteLine("Enter your URL: ");
        string url = ReadLine();
        string[] urlArr = Decomposer(url);

        WriteLine($"Decomposed URL:");
        for (int i = 0; i < urlArr.Length; i++)
        {
            //increasing indent for readability
            var indent = new string(' ', i * 2);
            WriteLine($"{indent} -> {urlArr[i]}");
        }
    }
}

