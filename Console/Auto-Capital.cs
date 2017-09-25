class AutoCapital
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";

            Console.Write("Enter sentence: ");
            input = Console.ReadLine();

            Console.WriteLine("{0}", CapitaliseSentence(input));
            Console.ReadLine();
        }

        static string CapitaliseSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            string newSentence = "";

            foreach (string word in words)
            {
                string newWord = word[0].ToString().ToUpper();

                for (int i = 1; i < word.Length; i++)
                {
                    newWord += word[i];
                }

                newSentence += newWord + " ";
            }

            return newSentence;
        }
    }
