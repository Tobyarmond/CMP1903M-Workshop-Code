namespace CMP1903MWorkshopCode;

public class Vector
{
    private int _x;
    private int _y;
    
    public int Y
    {
        get => _y;
        set => _y = value;
    }

    public int X
    {
        get => _x;
        set => _x = value;
    }

    public Vector(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public static Vector operator - (Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static int Distance(Vector v)
    {
        int a_b = (v.X * v.X) + (v.Y * v.Y);
        return Convert.ToInt32(Math.Sqrt(a_b));
    }
}