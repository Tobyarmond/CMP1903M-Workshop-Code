namespace CMP1903M_Workshop_Code;

public static class Read
{
    public static IEnumerable<string> ReadList(string fileName)
    {
        try
        {
            return File.ReadLines(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}