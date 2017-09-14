class TimeCalculator
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            string input = "";

            Console.Write("Enter date (dd/mm/yyyy): ");
            input = Console.ReadLine();

            CalculateDate(input);

            Console.WriteLine();
            GetUserInput();
        }

        static void CalculateDate(string input)
        {
            DateTime currentDateTime = new DateTime();
            DateTime dateTime = new DateTime();

            currentDateTime.ToUniversalTime();            
            currentDateTime = DateTime.Now;
            dateTime.ToUniversalTime();
            dateTime = DateTime.Parse(input);            

            int[] currentDate = { currentDateTime.Day, currentDateTime.Month, currentDateTime.Year };
            int[] date = { dateTime.Day, dateTime.Month, dateTime.Year };

            if (dateTime.CompareTo(currentDateTime) > 0)
            {
                TimeSpan timeSpan = dateTime.Subtract(currentDateTime);
                GenerateOutputDate(timeSpan, dateTime);
            }
            else
            {
                Console.WriteLine("Invalid Date. Please try again.");
            }      

        }

        static void GenerateOutputDate(TimeSpan time, DateTime inputDate)
        {
            Console.WriteLine("\nTime remaining until '{0}':\n", inputDate.ToShortDateString());

            Console.WriteLine("Total number of Days: {0}", time.Days);
            Console.WriteLine("Total number of Hours: {0}", time.Hours);
            Console.WriteLine("Total number of Minutes: {0}", time.Minutes);
            Console.WriteLine("Total number of Seconds: {0}", time.Seconds);
            Console.WriteLine("Total number of Miliseconds: {0}", time.Milliseconds);
            
        }

    }
