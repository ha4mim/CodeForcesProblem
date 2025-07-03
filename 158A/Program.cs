using System;
using System.Linq;

public class NextRound
{
    public static void Main(string[] args)
    {
        string? firstLine = Console.ReadLine();
        if (firstLine == null) return;
        string[] firstLineParts = firstLine.Split(' ');
        int n = int.Parse(firstLineParts[0]);
        int k = int.Parse(firstLineParts[1]);

        string? scoresLine = Console.ReadLine();
        if (scoresLine == null) return;
        string[] scoresStr = scoresLine.Split(' ');
        int[] scores = new int[n];
        for (int i = 0; i < n; i++)
        {
            scores[i] = int.Parse(scoresStr[i]);
        }

        int kthScore = scores[k - 1];
        int count = 0;

        foreach (int score in scores)
        {
            if (score > 0 && score >= kthScore)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
