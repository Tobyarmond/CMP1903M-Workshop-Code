using System.Text;

namespace CMP1903M_Workshop_Code
{
    internal static class Atbash
    {
        public static string EncodeLine(string text)
        {
            string output = "";
            text = text.ToUpper();
            for (int i = text.Length-1; i > -1; i--)
            {
                output += Convert.ToString(Convert.ToInt32(text[i]));
            }
            return output;
        }

        public static string DecodeLine(string text)
        {
            string output = "";
            int value = 0;
            for (int i = text.Length -1; i  > -1; i--)
            {
                string letter = "";
                letter += text[i -1];
                letter += text[i];
                value = Convert.ToInt32(letter);
                output += Convert.ToChar(value);
                i--;
            }
            return output;
        }
    }
}
