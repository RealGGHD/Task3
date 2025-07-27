namespace Task3;

public class SideChoose
{
    /// <summary>
    /// Choose sides in dices
    /// </summary>
    public static int RunProtocol(bool isUserWin, Dice userDice, Dice computerDice)
    {
        var random = Tools.FairRandom("Add your number modulo 6.", 5);
        int index = (random.ComputerNumber + random.UserNumber) % 6;
        Console.WriteLine($"The fair number generation result is {random.ComputerNumber} + {random.UserNumber} = {index} (mod 6).");
        Dice selectedDice;
        string rollOwner;
        if (isUserWin)
        {
            selectedDice = userDice;
            rollOwner = "Your";
        }
        else
        {
            selectedDice = computerDice;
            rollOwner = "My";
        }
        int result = selectedDice.GetValueByIndex(index);
        Console.WriteLine($"{rollOwner} roll result is {result}.");
        return result;
    }
}