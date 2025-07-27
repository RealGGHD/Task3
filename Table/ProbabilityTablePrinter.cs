namespace Task3;
using ConsoleTables;

public class ProbabilityTablePrinter
{
    private const string HelpMessage = "Probability of the win fоr the user:";
    /// <summary>
    /// Print table of probabilities
    /// </summary>
    public static void Print(double[,] probabilities, List<Dice> diceList)
    {
        var table = Template(diceList);
        for (int i = 0; i < diceList.Count; i++)
        {
            var row = new List<string> { diceList[i].Print() };
            for (int j = 0; j < diceList.Count; j++)
            {
                if (i == j)
                {
                    row.Add("0.3333".Substring(1));
                }
                else
                {
                    row.Add(probabilities[i, j].ToString("0.0000").Substring(1));
                }
            }
            table.AddRow(row.ToArray());
        }
        table.Write(Format.Alternative);
    }
    /// <summary>
    /// Template for table of probabilities
    /// </summary>
    private static ConsoleTable Template(List<Dice> diceList)
    {
        Console.WriteLine(HelpMessage);
        var headers = new List<string> { "User dice v" };
        headers.AddRange(diceList.Select(d => d.Print()));
        var table = new ConsoleTable(headers.ToArray());
        return table;
    }
}