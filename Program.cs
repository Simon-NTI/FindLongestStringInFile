namespace FindLongestStringInFile;

class Program
{
    static void Main(string[] args)
    {

        string? path = Console.ReadLine();
        string longestString = "";

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    if(line.Length > longestString.Length)
                    {
                        Console.WriteLine(line);
                        longestString = line;
                    }
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Could not read file");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("The longest string found was:");
            Console.WriteLine(longestString);
        }
    }
}
