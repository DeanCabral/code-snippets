 class StudentData
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {
            int studentNumber;
            string studentName;
            string scoredMarks;

            Console.Write("Input Student Number: ");
            studentNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Student Name: ");
            studentName = Console.ReadLine();
            Console.Write("Input Maths, English and Science marks: ");
            scoredMarks = Console.ReadLine();

            GenerateStudentOutput(studentNumber, studentName, scoredMarks);
            GetUserInput();
        }

        static void GenerateStudentOutput(int number, string name, string marks)
        {
            string[] subjectMarks = marks.Split(' '); 
            int mathMark = Convert.ToInt32(subjectMarks[0]);
            int englishMark = Convert.ToInt32(subjectMarks[1]);
            int scienceMark = Convert.ToInt32(subjectMarks[2]);
            int total = mathMark + englishMark + scienceMark;
            float percentage = total / subjectMarks.Length;
            string division = GetDivision(percentage);

            Console.WriteLine("Student Number: " + number);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Maths: " + mathMark);
            Console.WriteLine("English: " + englishMark);
            Console.WriteLine("Science: " + scienceMark);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage.ToString("N2") + "%");
            Console.WriteLine("Division: " + division);
            Console.WriteLine();
        }

        static string GetDivision(float percentage)
        {
            string output = "";

            if (percentage >= 70) output = "First Class";
            else if (percentage >= 60) output = "Upper-Second Class";
            else if (percentage >= 50) output = "Lower-Second Class";
            else if (percentage >= 40) output = "Third Class";
            else output = "N/A";
 
         
            return output;
        }
    }
