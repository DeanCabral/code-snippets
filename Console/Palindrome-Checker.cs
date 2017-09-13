class Palindrome
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";
            string output = "";

            Console.Write("Enter a word: ");
            input = Console.ReadLine();
            input = input.ToLower();

            output = Palindrome.IsPalindrome(input) ? "This word is a Palindrome. True." : "This word is not a Palindrome. False.";
            Console.WriteLine(output);
            
            Console.WriteLine();
            GetUserInput();
        }

        static bool IsPalindrome(string word)
        {
            List<char> characters = new List<char>();
            int count = 0;

            foreach (char c in word)
            {
                characters.Add(c);
            }

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i] == characters[(characters.Count - 1) - i]) count++;
            }

            return word.Length == count;
        }
    }
