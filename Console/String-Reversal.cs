class StringReversal
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";

            Console.Write("Enter a word: ");
            input = Console.ReadLine();

            Console.WriteLine("The reverse word of the string '{0}' is: {1}", input, ReverseString(input));

            GetUserInput();
        }

        static string ReverseString(string input)
        {
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            
            return reversed;
        }
    }
