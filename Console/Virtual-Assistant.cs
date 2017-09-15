class VirtualAssistant
    {
        private static string name;
        private static string time;
        private static string[] keywords = { "hello", "how are you", "what is"};

        static void Main(string[] args)
        {
            Initialisation();
        }

        static void Initialisation()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            time = GetTimeResponse();
            GetUserInput(0);
        }

        static string GetTimeResponse()
        {
            DateTime dt = new DateTime();
            string time = "";
            string[] component = new string[2];
            float hour = 0;

            dt = DateTime.Now;
            time = dt.ToShortTimeString();

            component = time.Split(':');
            hour = Convert.ToInt32(component[0]);

            if (hour > 0 && hour < 12) return "Good Morning";
            else if (hour > 12 && hour < 18) return "Good Evening";
            else if (hour > 18 && hour < 24) return "Good Night";
            else return "Hello";
        }

        static void GetUserInput(int firstFlag)
        {
            string input = "";

            if (firstFlag == 0) Console.WriteLine("\n{0}, {1}! How may i help?", time, name);
            else Console.WriteLine("\nWhat else can i help you with?");

            input = Console.ReadLine();
            input = input.ToLower();

            GenerateResponse(input);
        }

        static void GenerateResponse(string input)
        {
            for (int i = 0; i < keywords.Length; i++)
            {
                if (input.Contains(keywords[i]))
                {
                    Console.WriteLine(Respond(i));                    
                    break;
                }
            }
                       
            GetUserInput(1);
        }

        static string Respond(int index)
        {
            string output = "\n";

            switch (index)
            {
                case 0:
                    output += "Hello " + name + ", What's up?";
                    break;
                case 1:
                    output += "I'm very well. Thanks for asking!";
                    break;
                case 2:
                    output += "I'm not exactly sure. Maybe someday my creator will create a function to handle that.";
                    break;
                default:
                    output += "Sorry. I don't know how to respond to that.";
                    break;
            }

            return output;
        }
    }
