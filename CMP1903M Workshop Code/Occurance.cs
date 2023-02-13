namespace CMP1903M_Workshop_Code;

internal static class Occurance
{
    public static string DecodeLine(string text)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c] += 1;
            }
            else
            {
                charCount.Add(c,1);
            }
        }
        // instantiate empty pair to avoid possible null messages
        KeyValuePair<char,int> selectedChar = new KeyValuePair<char, int>(' ',0);
        foreach (KeyValuePair<char,int> pair in charCount)
        {
            if (pair.Value > selectedChar.Value)
            {
                selectedChar = pair;
            }
        }
        return Convert.ToString(selectedChar.Key);
    }
    
    public static IEnumerable<string> DecodeLines(IEnumerable<string> textFile)
    {
        List<string> answer = new List<string>();
        foreach (string line in textFile)
        {
            answer.Add(DecodeLine(line));
        }
        return answer;
    }
}