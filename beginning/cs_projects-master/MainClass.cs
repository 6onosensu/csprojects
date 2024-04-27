namespace words
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            string menuText = @"
            translation of a word: t 'word'
            to show all words: show
            to edit a word: edit
            to check your words knowledge: test
            : ";

            while (true)
            {
                Console.Write(menuText);
                string userInput = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrEmpty(userInput))
                {
                    continue;
                }

                if (userInput == "quit")
                {
                    break;
                }

                List<string> engWords = new List<string>();
                List<string> rusWords = new List<string>();
                try
                {
                    if (userInput.StartsWith("t "))
                    {

                    }
                    else if (userInput.StartsWith("show"))
                    {
                        foreach (string row in File.ReadAllLines(@"engWords.txt"))
                        {
                            engWords.Add(row);
                        }
                        foreach (string row in File.ReadAllLines(@"rusWords.txt"))
                        {
                            rusWords.Add(row);
                        }
                    }
                    else if (userInput.StartsWith("edit"))
                    {

                    }
                    else if (userInput.StartsWith("test"))
                    {

                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    continue;
                }
            }
        }

        /*
        Console.WriteLine("It's working!!!");
            List<string> engWords = new List<string>();
            List<string> rusWords = new List<string>();
            try
            {
                foreach (string row in File.ReadAllLines(@"engWords.txt"))
                {
                    engWords.Add(row);
                }
                foreach (string row in File.ReadAllLines(@"rusWords.txt"))
                {
                    rusWords.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with the file!: " + ex.Message);
            }
        }*/
    }
}
