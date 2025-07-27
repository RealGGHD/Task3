namespace Task3;

public class Input
{
    /// <summary>
    /// Get input from user
    /// </summary>
    public static int Get(int end, int usedIndex = 9999)
    {
        while (true)
        {
            Console.Write("Your selection: ");
            string? message = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Input cannot be empty. Try again.");
                continue;
            }
            if (ExtraCheck(message)) continue;
            if (!int.TryParse(message, out int answer))
            {
                Console.WriteLine("Invalid selection. Try again.");
                continue;
            }

            if ((answer < 0) || (answer > end))
            {
                Console.WriteLine($"Your answer not fits. It should be in range from 0..{end}.");
                continue;
            }
            if (answer >= usedIndex) answer += 1; //After computer selected dice, we should fix index from user
            return answer;
        }
    }
    /// <summary>
    /// Extra check for additional commands
    /// </summary>
    private static bool ExtraCheck(string message)
    {
        switch (message)
        {
            case "X":
                Environment.Exit(0);
                return true;
            case "?":
                var diceList = Run.GetDiceList();
                var matrix = ProbabilityCalculator.Calculate(diceList);
                ProbabilityTablePrinter.Print(matrix, diceList);
                return true;
            default:
                return false;
        }
    }
}