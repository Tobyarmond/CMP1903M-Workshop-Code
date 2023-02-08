namespace CMP1903M_Workshop_Code;

public class Street
{
    private int _num1;
    private int _num2;
    private int _num3;
    private int _num4;
    private int _check;
    
    public Street(int num1, int num2, int num3, int num4, int check)
    {
        _num1 = num1;
        _num2 = num2;
        _num3 = num3;
        _num4 = num4;
        _check = check;
    }
    
    public static List<Street> StreetListFromStringList(IEnumerable<string> list)
    {
        List<Street> streets = new List<Street>();
        foreach (string str in list)
        {
            int[] numbers = new int[5];
            int countChar = 0;
            foreach (char c in str)
            {
                if (c is '[' or ']')
                {
                }
                else
                {
                    // This needs to convert to an int because char get value is a double.
                    numbers[countChar] = Convert.ToInt32(char.GetNumericValue(c));
                    countChar++;  
                }
            }
            streets.Add(new Street(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]));
        }

        return streets;
    }

    public bool ChecksumStreet()
    {
        int multiple = _num1 * _num2 * _num3 * _num4;
        int add = 0;
        int remainder;
        while (multiple > 0)
        {
            remainder = multiple % 10;
            add += remainder;
            //multiple =- remainder;
            multiple = multiple / 10;
        }
        remainder = add % 10;
        //add -= remainder;
        add /= 10;
        return add + remainder == _check;
    }
}

