class Program
{
    static void Main()
    {
        //LINQ = Language Integrated Query
        //LINQ makes working with collections much simpler
        //LINQ is a type of declarative programming like SQL

        List<int> scores = [93, 12, 42, 64, 23, 46, 77, 87, 76, 90];

        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[i] > 80)
            {
                Console.WriteLine($"Found a score greater than 80 : {scores[i]}");
            }
        }

        //Equivalent of the above code in LINQ
        //differed execution
        IEnumerable<int> scoresGreaterThan80 = from score in scores where score > 80 select score;
        foreach (int score in scoresGreaterThan80)
        {
            Console.WriteLine($"Found a score greater than 80 : {score}");
        }

        IEnumerable<int> scoresGreaterThan80SortedDesc = from score in scores where score > 80 orderby score descending select score;
        foreach (int score in scoresGreaterThan80SortedDesc)
        {
            Console.Write($"{score} ");
        }
        Console.WriteLine("");

        IEnumerable<int> scoresGreaterThan80SortedAsc = from score in scores where score > 80 orderby score ascending select score;
        foreach (int score in scoresGreaterThan80SortedAsc)
        {
            Console.Write($"{score} ");
        }
        Console.WriteLine("");

        IEnumerable<string> scoresGreaterThan80SortedAscString = from score in scores where score > 80 orderby score ascending select $"Score : {score}";

        Console.WriteLine($"Number of scores = {scoresGreaterThan80SortedAscString.Count()}");

        foreach (string scoreString in scoresGreaterThan80SortedAscString)
        {
            Console.WriteLine(scoreString);
        }

        //to convert IEnumerable<T> to List<T>
        List<string> scoresGreaterThan80SortedAscListofStrings = scoresGreaterThan80SortedAscString.ToList();
        //or
        List<string> scoresGreaterThan80SortedAscListofStringsCopy = [.. scoresGreaterThan80SortedAscString];

        //LINQ compiles down to a sequnece of method calls on the object
        //the above query actually looks like 
        //the thing inside () beside Where is called as lambda function
        //the below thing is called as method query
        IEnumerable<int> scoreMethodQuery = scores.Where(score => score > 80);
        foreach (int score in scoreMethodQuery)
        {
            Console.WriteLine($"Found a score greater than 80 : {score}");
        }

        IEnumerable<int> scoreMethodQueryDesc = scores.Where(score => score > 80).OrderByDescending(score => score);
        foreach (int score in scoreMethodQuery)
        {
            Console.WriteLine($"Found a score greater than 80 : {score}");
        }
       
    }
}
