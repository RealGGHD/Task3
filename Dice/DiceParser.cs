namespace Task3;

public class DiceParser
{
    
    /// <summary>
    /// Parse arguments: From array of string To int jagged array.
    /// </summary>
    public static List<Dice> Parse(string[] args)
    {
        List<Dice> diceList = new List<Dice>();
        foreach (var arg in args)
        {
            Dice dice = new Dice();
            string[] sideSet = arg.Split(',');
            foreach (var side in sideSet)
            {
                dice.AddFace(int.Parse(side));
            }
            diceList.Add(dice);
        }
        return diceList;
    }
}