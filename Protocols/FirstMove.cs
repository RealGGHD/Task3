namespace Task3;

public class FirstMove
{
    /// <summary>
    /// Who make first move?
    /// </summary>
    public static bool RunProtocol()
    {
        var result = Tools.FairRandom("Try to guess my selection", 1);
        return result.ComputerNumber == result.UserNumber;
    }
}