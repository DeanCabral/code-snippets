class Converter
    {
        static void Main(string[] args)
        {
            InitialiseSelection();
        }

        static void InitialiseSelection()
        {
            int option = 0;

            Console.WriteLine("Select Conversion Type:\n");
            Console.WriteLine("[1] Temperature\n[2] Distance\n[3] Weight");
            Console.Write("\nChoice: ");

            option = Convert.ToInt32(Console.ReadLine());
            GetUserInput(option);

        }

        static void GetUserInput(int type)
        {
            switch (type)
            {
                case 1:
                    TemperatureConversion();
                    break;
                case 2:
                    DistanceConversion();
                    break;
                case 3:
                    WeightConversion();
                    break;
                default:
                    break;
            }
        }

        static void TemperatureConversion()
        {
            int input = 0;
            float celcius = 0;
            float fahrenheit = 0;

            Console.WriteLine("\nTEMPERATURE CONVERSION: ");
            Console.Write("Enter value: ");
            input = Convert.ToInt32(Console.ReadLine());

            celcius = (input - 32) / 1.8f;
            fahrenheit = (input * 1.8f) + 32;

            Console.WriteLine("\n{0} Celcius to Fahrenheit: {1} F", input, fahrenheit);
            Console.WriteLine("{0} Fahrenheit to Celcius: {1} C", input, celcius);

            Console.WriteLine();
            InitialiseSelection();
        }

        static void DistanceConversion()
        {
            int input = 0;
            float metersKilo, metersMile;
            float kilosMeter, kilosMile;
            float milesMeter, milesKilo;

            Console.WriteLine("\nDISTANCE CONVERSION: ");
            Console.Write("Enter value: ");
            input = Convert.ToInt32(Console.ReadLine());

            metersKilo = input * 0.0010000f;
            metersMile = input * 0.00062137119223733f;
            kilosMeter = input / 0.0010000f;
            kilosMile = input * 0.6214f;
            milesMeter = input / 0.00062137119223733f;
            milesKilo = input / 0.6214f;

            Console.WriteLine("\nMETERS:");
            Console.WriteLine("{0} Meters to Kilometers: {1}km", input, metersKilo);
            Console.WriteLine("{0} Meters to Miles: {1}mi", input, metersMile);
            Console.WriteLine("\nKILOMETERS:");
            Console.WriteLine("{0} Kilometers to Meters: {1}m", input, kilosMeter);
            Console.WriteLine("{0} Kilometers to Miles: {1}mi", input, kilosMile);
            Console.WriteLine("\nMILES:");
            Console.WriteLine("{0} Miles to Meters: {1}m", input, milesMeter);
            Console.WriteLine("{0} Miles to Kilometers: {1}km", input, milesKilo);

            Console.WriteLine();
            InitialiseSelection();
        }

        static void WeightConversion()
        {
            int input = 0;
            float ouncesGram, ouncesKilo;
            float gramsOunce, gramsKilo;
            float kilosOunce, kilosGram;

            Console.WriteLine("\nWEIGHT CONVERSION: ");
            Console.Write("Enter value: ");
            input = Convert.ToInt32(Console.ReadLine());

            ouncesGram = input / 0.035274f;
            ouncesKilo = input / 35.274f;
            gramsOunce = input * 0.035274f;
            gramsKilo = input * 0.001f;
            kilosOunce = input * 35.274f;
            kilosGram = input / 1000.0f;

            Console.WriteLine("\nOUNCES:");
            Console.WriteLine("{0} Ounces to Grams: {1}g", input, ouncesGram);
            Console.WriteLine("{0} Ounces to Kilograms: {1}kg", input, ouncesKilo);
            Console.WriteLine("\nGRAMS:");
            Console.WriteLine("{0} Grams to Ounces: {1}oz", input, gramsOunce);
            Console.WriteLine("{0} Grams to Kilograms: {1}kg", input, gramsKilo);
            Console.WriteLine("\nKILOGRAMS:");
            Console.WriteLine("{0} Kilograms to Ounces: {1}oz", input, kilosOunce);
            Console.WriteLine("{0} Kilograms to Grams: {1}g", input, kilosGram);

            Console.WriteLine();
            InitialiseSelection();
        }
    }
