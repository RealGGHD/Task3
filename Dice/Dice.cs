namespace Task3;

public class Dice
{
    private List<int> _faces;
    /// <summary>
    /// Constructor
    /// </summary>
    public Dice() => _faces = new List<int>();
    /// <summary>
    /// Add value to List<int> faces
    /// </summary>
    public void AddFace(int face) => _faces.Add(face);
    /// <summary>
    /// Get value by index
    /// </summary>
    public int GetValueByIndex(int index) => _faces[index];
    /// <summary>
    /// Get faces
    /// </summary>
    public int GetFacesLength() => _faces.Count();
    /// <summary>
    /// Get faces array
    /// </summary>
    public int[] GetFacesArray() => _faces.ToArray();
    /// <summary>
    /// Print values in string
    /// </summary>
    public string Print() => string.Join(",", _faces);
}