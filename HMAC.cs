namespace Task3;
using System.Security.Cryptography;

public class Hmac
{
    private const int KeyLengthInBytes = 32;
    /// <summary>
    /// Key Generator
    /// </summary>
    private static byte[] GenerateKey()
    {
        byte[] key = new byte[KeyLengthInBytes];
        RandomNumberGenerator.Fill(key);
        return key;
    }
    /// <summary>
    /// Fair int/message generator
    /// </summary>
    public static (byte[] Byte, int Int) GenerateFairInt(int end)
    {
        end += 1; //Generation including end number
        int randomNumber = RandomNumberGenerator.GetInt32(0, end);
        return (BitConverter.GetBytes(randomNumber), randomNumber);
    }
    /// <summary>
    /// HMAC Generator
    /// </summary>
    public static (string Key, int RandomNumber, string Hmac) Generate(int end)
    {
        byte[] key = GenerateKey();
        var fairInt = GenerateFairInt(end);
        var hmac = new HMACSHA256(key);
        byte[] hash = hmac.ComputeHash(fairInt.Byte);
        return (Convert.ToHexString(key), fairInt.Int, Convert.ToHexString(hash));
    }
}