namespace CMP1903M_Workshop_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: File currently has to be in bin next to .exe  
            List<Street> streets = Street.StreetListFromStringList(Read.ReadList("Week 2 Street Codes.txt"));
            foreach (Street street in streets)
            {
                Console.Write(street.GiveNumbers());
                Console.WriteLine(street.ChecksumStreet());
            }
        }
    }
}
