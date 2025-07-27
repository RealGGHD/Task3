namespace Task3;

class Run
{
    private const string WelcomeMessage = "Let's determine who makes the first move.";
    static List<Dice> diceList;
    static void Main(string[] args)
    {
        Verification.Args(args);
        
        Console.WriteLine(WelcomeMessage);
        diceList = DiceParser.Parse(args);
        
        bool isUserFirst = FirstMove.RunProtocol();
        var (userIndex, computerIndex) = DiceChoose.RunProtocol(isUserFirst, diceList);
        
        int firstRoll = SideChoose.RunProtocol(isUserFirst, diceList[userIndex], diceList[computerIndex]);
        int secondRoll = SideChoose.RunProtocol(!isUserFirst, diceList[userIndex], diceList[computerIndex]);

        int userRoll = isUserFirst ? firstRoll : secondRoll;
        int computerRoll = isUserFirst ? secondRoll : firstRoll;
        
        if (userRoll > computerRoll)
            Console.WriteLine($"You are the winner! ({userRoll} > {computerRoll})");
        else if (userRoll < computerRoll)
            Console.WriteLine($"You are the looser! ({userRoll} < {computerRoll})");
        else
            Console.WriteLine($"Good job! ({userRoll} = {computerRoll})");
    }
    public static List<Dice> GetDiceList() => diceList;
}