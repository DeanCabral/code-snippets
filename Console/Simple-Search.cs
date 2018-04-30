class Simple-Search
    {
        private static int numberOfElements = 0;

        static void Main(string[] args)
        {
            GetUserInput();
        }

        static void GetUserInput()
        {                      
            Console.Write("Input Element Count: ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            
            GenerateElements();            
        }

        static void GenerateElements()
        {
            int[] elements = new int[numberOfElements];
            Random rand = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {                
                elements[i] = rand.Next(1, 51);
            }

            PrintElements(elements);
        }

        static void PrintElements(int[] elements)
        {
            int index = 0;

            foreach (int element in elements)
            {
                Console.WriteLine("Element {0} = {1}", index, elements[index]);
                index++;
            }

            ElementToSearch(elements);
        }

        static void ElementToSearch(int[] elements)
        {
            bool foundFlag = false;
            int targetElement = -1;

            Console.WriteLine();
            Console.Write("Find Element: ");

            targetElement = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elements.Length; i++)
            {
                if (targetElement == elements[i])
                {
                    Console.WriteLine("Found element at index {0}", i);
                    foundFlag = true;
                }                    
            }

            if (!foundFlag) Console.WriteLine("Element {0} not found in array.", targetElement);
            Console.ReadLine();
        }
