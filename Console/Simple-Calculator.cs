class Calculator
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";

            Console.Write("Enter calculation: ");
            input = Console.ReadLine();

            Console.WriteLine("{0} = {1}", input, CalculateResult(input));

            Console.WriteLine();
            GetUserInput();
        }

        static int CalculateResult(string input)
        {
            string[] components = input.Split(' ');
            int num1 = Convert.ToInt32(components[0]);
            int num2 = Convert.ToInt32(components[2]);
            string operation = components[1];
            int result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            
            return result;
        }
    }
