namespace Task3;

public class Verification
{
    private const int MinDiceNumber = 3;
    private const int DiceSides = 6;
    private const string ExampleMsg = "Example: 2,2,4,4,9,9 6,8,1,1,8,6 7,5,3,7,5,3";
    /// <summary>
    /// Dices should be 3 or more
    /// </summary>
    private static void VerifyDiceNumber(string[] args)
    {
        if (args.Length < MinDiceNumber) {
            throw new Exception($"Invalid number of dice. It should be >2.\n{ExampleMsg}");
        }
    }
    /// <summary>
    /// Sides in dice should 6
    /// </summary>
    private static void VerifySideNumber(string[] args)
    {
        foreach (string arg in args)
        {
            string[] elements = arg.Split(',');
            if (elements.Length != DiceSides) {
                throw new Exception($"We use a standard 6-sided cube.\n{ExampleMsg}");
            }
        }
    }
    /// <summary>
    /// Each side can convert to int
    /// </summary>
    private static void VerifySideConvert(string[] args)
    {
        foreach (string arg in args)
        {
            string[] elements = arg.Split(',');
            foreach (var element in elements)
            {
                if (!int.TryParse(element, out _))
                {
                    throw new Exception($"Element [{element}] in [{arg}] cannot be converted to int.");
                }
            }
        }
    }
    /// <summary>
    /// Dices should be 3 or more, sides in dice should 6 and each side can convert to int.
    /// </summary>
    public static void Args(string[] args)
    {
        VerifyDiceNumber(args);
        VerifySideNumber(args);
        VerifySideConvert(args);
    }
}