using System.Text.RegularExpressions;

namespace RegularExpression;

public class SimpleRexegg
{
    public void RexeggSimple()
    {
        string s1 = @"apple:green:3 banana:yellow:5";
        var myRegex = new Regex(@"(\w+):(\w+):(\d+)");

///////// The six main tasks we're likely to have ////////

// Task 1: Is there a match?
        Console.WriteLine("*** Is there a Match? ***");
        if (myRegex.IsMatch(s1)) Console.WriteLine("Yes");
        else Console.WriteLine("No");

// Task 2: How many matches are there?
        MatchCollection allMatches = myRegex.Matches(s1);
        Console.WriteLine("\n" + "*** Number of Matches ***");
        Console.WriteLine(allMatches.Count);

// Task 3: What is the first match?
        Console.WriteLine("\n" + "*** First Match ***");
        Match oneMatch = myRegex.Match(s1);
        if (oneMatch.Success)    {
            Console.WriteLine("Overall Match: "+ oneMatch.Groups[0].Value);
            Console.WriteLine("Group 1: " + oneMatch.Groups[1].Value);
            Console.WriteLine("Group 2: " + oneMatch.Groups[2].Value);
            Console.WriteLine("Group 3: " + oneMatch.Groups[3].Value);
        }

// Task 4: What are all the matches?
        Console.WriteLine("\n" + "*** Matches ***");
        if (allMatches.Count > 0)    {
            foreach (Match someMatch in allMatches)    {
                Console.WriteLine("Overall Match: " + someMatch.Groups[0].Value);
                Console.WriteLine("Group 1: " + someMatch.Groups[1].Value);
                Console.WriteLine("Group 2: " + someMatch.Groups[2].Value);
                Console.WriteLine("Group 3: " + someMatch.Groups[3].Value);
            }
        }

// Task 5: Replace the matches
// simple replacement: reverse groups
        string replaced = myRegex.Replace(s1, 
            delegate(Match m) {
                return m.Groups[3].Value + ":" +
                       m.Groups[2].Value + ":" +
                       m.Groups[1].Value;
            }
        );
        Console.WriteLine("\n" + "*** Replacements ***");
        Console.WriteLine(replaced);

// Task 6: Split
// Let's split at colons or spaces
        string[] splits = Regex.Split(s1, @":|\s");
        Console.WriteLine("\n" + "*** Splits ***");
        foreach (string split in splits) Console.WriteLine(split);

        Console.WriteLine("\nPress Any Key to Exit.");
        Console.ReadKey();
    }
}