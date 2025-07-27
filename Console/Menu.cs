namespace Task3;

public class Menu
{
    /// <summary>
    /// Menu for selection in range
    /// </summary>
    public static void Range(int end)
    {
        end += 1; //Print including end number
        for (int i = 0; i < end; i++)
        {
            Console.WriteLine($"{i} - {i}");
        }
        Tools();
    }
    /// <summary>
    /// Menu for selection in List<Dice>
    /// </summary>
    public static void Dice(List<Dice> diceList, int usedIndex = -1)
    {
        List<Dice> newDices = new List<Dice>(diceList);
        if (usedIndex != -1)
        {
            newDices.RemoveAt(usedIndex);
        }

        for (int i = 0; i < newDices.Count; i++)
        {
            Console.WriteLine($"{i} - {newDices[i].Print()}");
        }
        Tools();
    }
    /// <summary>
    /// Menu for extra tools
    /// </summary>
    private static void Tools()
    {
        Console.WriteLine("X - exit");
        Console.WriteLine("? - help");
    }
}