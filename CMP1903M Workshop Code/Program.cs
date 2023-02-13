using System.Reflection.Emit;
using System.Security.Cryptography;

namespace CMP1903M_Workshop_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Message week3 = new Message();
            // Codes has been placed next to .exe for ease of use
            week3.ReadMessageFromFile("codes.txt");
            IEnumerable<string> answer = Occurance.DecodeLines(week3.Messages);
            foreach (string line in answer)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(Atbash.EncodeLine("Cheese"));
            Console.WriteLine(Atbash.DecodeLine(Atbash.EncodeLine("Quaver")));
            Message week3Write = new Message();
            week3Write.ReadMessageFromInput();
            week3Write.SingleMessage = Atbash.EncodeLine(week3Write.SingleMessage);
            string dayTime = DateTime.Now.ToString("yyyy-mm-dd-h-m");
            week3Write.WriteMessageToFile(dayTime+".txt");
        }
    }
}
