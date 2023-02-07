namespace CMP1903MWorkshopCode;

public static class Stuff
{
    public static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int c = a % b;
            a = b;
            b = c;
        }

        return a;
    }

    public static int Sum(int num)
    {
        int value = 0;
        for (int i = 0; i < num; i++)
        {
            value += i;
        }

        return value;
    }
}   