namespace CMP1903M_Workshop_Code
{
    internal class Message
    {
        //private field
        private IEnumerable<string>? _messages;
        private string? _singleMessage;

        public IEnumerable<string>? Messages
        {
            get => _messages;
            set => _messages = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string? SingleMessage
        {
            get => _singleMessage;
            set => _singleMessage = value ?? throw new ArgumentNullException(nameof(value));
        }

        //read the message to encrypt from a file
        public void ReadMessageFromFile(string filename)
        {
            Messages = File.ReadLines(filename);
        }

        public void WriteMessageToFile(string filename)
        {
            if (SingleMessage != null) File.WriteAllText(filename, SingleMessage);
        }

        //read the message to encrypt from input
        public void ReadMessageFromInput()
        {
            Console.WriteLine("Enter your message to encode...");
            SingleMessage = Console.ReadLine();
        }
    }
}
