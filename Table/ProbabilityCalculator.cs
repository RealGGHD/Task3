namespace Task3;

public class ProbabilityCalculator
{
    private const int DecimalPlaces = 4;
    /// <summary>
    /// Calculate matrix of probabilities
    /// </summary>
    public static double[,] Calculate(List<Dice> diceList)
    {
        int n = diceList.Count;
        double[,] matrix = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = 0.3333;
                }
                else
                {
                    matrix[i, j] = CalculateWinProbability(diceList[i], diceList[j]);
                }
            }
        }
        return matrix;
    }
    /// <summary>
    /// Calculate win probability between 2 dices
    /// </summary>
    private static double CalculateWinProbability(Dice diceA, Dice diceB)
    {
        int wins = 0;
        var facesA = diceA.GetFacesArray();
        var facesB = diceB.GetFacesArray();
        int total = facesA.Length * facesB.Length;
        foreach (var a in facesA)
        {
            foreach (var b in facesB)
            {
                if (a > b) wins++;
            }
        }
        return Math.Round((double)wins / total, DecimalPlaces);
    }
}