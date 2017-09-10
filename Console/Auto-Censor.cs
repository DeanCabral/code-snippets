class AutoCensor
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";
            string censor = "";

            Console.Write("Word to censor: ");
            censor = Console.ReadLine();
            Console.Write("Enter sentence: ");
            input = Console.ReadLine();

            Console.WriteLine(WordCensor(input, censor));

            Console.WriteLine();
            GetUserInput();
        }

        static string WordCensor(string input, string censor)
        {
            string[] words = input.Split(' ');
            string output = "";

            foreach (string word in words)
            {
                if (word == censor)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        output += "*";
                    }
                    output += " ";
                }
                else output += word + " ";
            }

            return output;
        }
    }
