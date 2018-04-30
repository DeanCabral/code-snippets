class DeveloperBanner
    {
        static string assignmentTitle, developerName, dateSubmitted, generalPurpose;
        static int bannerLength = 50;

        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {          

            Console.Write("Input Assignment Title: ");
            assignmentTitle = Console.ReadLine();
            Console.Write("Input Developer Name: ");
            developerName = Console.ReadLine();
            Console.Write("Input Submission Date: ");
            dateSubmitted = Console.ReadLine();
            Console.Write("Input General Purpose: ");
            generalPurpose = Console.ReadLine();

            Console.WriteLine();
            GenerateOutputBanner();

        }

        static void GenerateOutputBanner()
        {
            Console.WriteLine(DrawLine());
            Console.WriteLine(BannerBody(assignmentTitle));
            Console.WriteLine(BannerBody(developerName));
            Console.WriteLine(BannerBody(dateSubmitted));
            Console.WriteLine(BannerBody(generalPurpose));
            Console.WriteLine(DrawLine());
            Console.ReadLine();
        }

        static string BannerBody(string information)
        {
            string output = "";
            int count = (bannerLength - 10) - information.Length;

            output = "**      " + information + DrawWhiteSpace(count) + "**";

            return output;
        }

        static string DrawLine()
        {
            string output = "";

            for (int i = 0; i < bannerLength; i++)
            {
                output += "*";
            }

            return output;
        }

        static string DrawWhiteSpace(int count)
        {
            string output = "";
            for (int i = 0; i < count; i++)
            {
                output += " ";
            }

            return output;      
        }

    }
