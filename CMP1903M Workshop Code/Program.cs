namespace CMP1903M_Workshop_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 2
            //EITHER:
            //Read in the text file if you want (or are able) [HINT: read into a list of strings]
            //Split the first four numbers
            //TODO: File currently has to be in bin next to .exe  
            List<Street> streets = Street.StreetListFromStringList(Read.ReadList("Week 2 Street Codes.txt"));



            //OR:
            //Manual (check each street code individually without reading them in automatically)
            //long, tedious, etc, etc
            //7778[8] is a correct street code
            //Second two variables here are to use when calculating the checksum
            int streetCode = 7778;
            int checkSum = 8;
            int total = 1;
            int total2 = 0;

            foreach (Street street in streets)
            {
                Console.WriteLine(street.ChecksumStreet());
            }
          

            //Multiply all the numbers together in the 4 digit code (7*7*7*8)
            //Can do it by using the mod '%' operator and the divide '/' operator
            //Reduce streetCode by 1 digit each time through the loop
            


            //Add the digits of the multiplication total together
            //infinite loop until the total gets to one digit - the checksum
            //Use 'break;' to break out of the loop
           
  
            //Check if the final checksum is the same as the checksum in the street code.
            

        }
    }
}
