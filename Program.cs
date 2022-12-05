namespace Advent_Of_Code_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myScore = 0;
            int strategyScore = 0;

            string input = "start";
            Dictionary<string, int> matchupScores = new()
            {
                {"A X", 4 },
                {"A Y", 8 },
                {"A Z", 3 },

                {"B X", 1 },
                {"B Y", 5 },
                {"B Z", 9 },

                {"C X", 7 },
                {"C Y", 2 },
                {"C Z", 6 },

                {"", 0 }
            };
            Dictionary<string, int> strategyScores = new()
            {
                {"A X", 3 },
                {"A Y", 4 },
                {"A Z", 8 },

                {"B X", 1 },
                {"B Y", 5 },
                {"B Z", 9 },

                {"C X", 2 },
                {"C Y", 6 },
                {"C Z", 7 },

                {"", 0 }
            };
            while (input != "")
            {
                input = GetInput($"ROCK PAPER SCISSORS score: {myScore}"); 
                myScore += matchupScores[input];
                strategyScore += strategyScores[input];
            }
            Console.WriteLine($"Final score: {myScore}.  Score by strategy: {strategyScore}.");
        }

        static string GetInput(string prompt)
        {
            bool validResult = false;
            string? input = null;
            while (!validResult)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (input != null)
                {
                    validResult = true;
                }
            }

            return input!;
        }

    }
}