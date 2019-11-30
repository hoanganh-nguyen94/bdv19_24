using System;
using System.IO;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("./input.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string[] names = sr.ReadToEnd().Split(
                        new[] { Environment.NewLine },
                        StringSplitOptions.None
                    );
                    using (StreamWriter outputFile = new StreamWriter("./output.txt"))
                    {
                        outputFile.Write("Hello" + string.Join(" ", names));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
