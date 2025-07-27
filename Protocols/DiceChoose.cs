namespace Task3;

public class DiceChoose
{
    /// <summary>
    /// Choose between dices
    /// </summary>
    public static (int userNum, int computerNum) RunProtocol(bool isUserWin, List<Dice> diceList)
    {
        int userIndex, computerIndex;
        if (isUserWin)
        {
            Console.WriteLine("You make the first move.\nChoose your dice:");
            Menu.Dice(diceList);
            userIndex = Input.Get(diceList.Count - 1);
            Console.WriteLine($"You choose the [{diceList[userIndex].Print()}] dice.");
            computerIndex = Tools.GenerateDifferentIndex(diceList.Count, userIndex);
            Console.WriteLine($"I choose the [{diceList[computerIndex].Print()}] dice.");
            Console.WriteLine("It's time for your roll.");
        }
        else
        {
            computerIndex = Hmac.GenerateFairInt(diceList.Count - 1).Int;
            Console.WriteLine($"I make the first move and choose the [{diceList[computerIndex].Print()}] dice.");
            Menu.Dice(diceList, computerIndex);
            userIndex = Input.Get(diceList.Count - 1, computerIndex);
            Console.WriteLine($"You choose the [{diceList[userIndex].Print()}] dice.");
            Console.WriteLine("It's time for my roll.");
        }
        return (userIndex, computerIndex);
    }
}