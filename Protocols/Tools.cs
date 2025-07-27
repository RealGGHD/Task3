namespace Task3;

public class Tools
{
    private const string SelectMessage = "I selected a random value in the range";
    /// <summary>
    /// Fair random number protocol
    /// </summary>
    public static (int ComputerNumber, int UserNumber) FairRandom(string info, int end)
    {
        var result = Hmac.Generate(end);
        Console.WriteLine($"{SelectMessage} 0..{end}. (HMAC={result.Hmac})");
        Console.WriteLine(info); //Additional information
        Menu.Range(end);
        int answer = Input.Get(end);
        Console.WriteLine($"My selection: {result.RandomNumber} (KEY={result.Key})");
        return (result.RandomNumber, answer);
    }
    /// <summary>
    /// Generate different index
    /// </summary>
    public static int GenerateDifferentIndex(int maxIndex, int excludeIndex)
    {
        int index;
        do
        {
            index = Hmac.GenerateFairInt(maxIndex - 1).Int;
        } while (index == excludeIndex);
        return index;
    }
}