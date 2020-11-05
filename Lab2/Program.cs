using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Markup;

namespace Lab2
{
    class Program
    {
        //-------------//
        #region //Body of the Main();
        static void Main(string[] args)
        {
            ArrayTest();
            ListTest();
            StringFormatting();
            Console.Write("Press <Enter> to quit...");
            Console.ReadLine();
        }
        #endregion
        //-------------//

        //////////////////////////////////
        #region //Method for: ArrayTest();
        static void ArrayTest() 
        {
            string input = default;
            string[] inputs = new string[5]; //Creating arr to store the individual substrings-split from the 'input' string
            double[] values = new double[5]; //Creating an arr that can house 5 elements of-type: 'double'

            Console.WriteLine("ArrayTest()");
            Console.Write("Enter five numbers and separate the numbers with a comma. Then, hit <Enter> after entering the last number.  ");
            input = Console.ReadLine();

            inputs = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

            
             for (int i = 0 ; i  <= 5 ; i++)
             {
                values[i] = double.Parse(inputs[i].Trim());
                //Break once we hit last element (aka the 4th element) to avoid exception
                if (i == 4)
                {
                    Array.Sort(values);
                    Console.Write("Values: ");
                    foreach (double v in values) 
                    {
                        Console.Write($"{v} ");
                    }
                    break; 
                }
             };
            Console.Write("\n");
            //Variables for min, max, sum and average
            double min = values.Min();
            double max = values.Max();
            double sum = values.Sum();
            double average = values.Average();
            Console.WriteLine($"Min: {min} ");
            Console.WriteLine($"Max: {max} ");
            Console.WriteLine($"Sum: {sum} ");
            Console.WriteLine($"Average: {average} ");

        }
        #endregion
       
        
        #region //Method for: ListTest();
        static void ListTest()
        {
            Console.WriteLine("\nListTest()");
            List<string> words = new List<string>();
            string word = default;
            Console.Write("Continue entering one word at a time at the prompt.  ");
            Console.WriteLine("Enter 'q' to quit.");

            while (true)
            {
                Console.WriteLine("Word: ");
                word = Console.ReadLine();

                //Break out of the 'while' loop when the user enters 'q' or 'Q'
                if (word.ToUpper() == "Q")
                { 
                    break; 
                }
                words.Add($"{word}");
            }

            //Create new empty string to concat items in 'words[]'
            StringBuilder join = new StringBuilder();

            //Append the substrings in 'words[]' and adds a space after each appended substring
            words.ForEach(delegate (String word)
            {
                join.Append($"{word} ");
            });
            Console.WriteLine(join);

        } 
        #endregion

        #region //Method for: StringFormatting();
        static void StringFormatting() 
        {
            #region //Print out the header
            Console.WriteLine("\nStringFormatting()");
            string partNumH = "Part #";
            string partNameH = "Part Name";
            string priceH = "Price";
            string phoneH = "Phone";
            string mfgDateH = "MFG Date";
            Console.Write(partNumH.PadRight(11,' '));
            Console.Write(partNameH.PadRight(20, ' '));
            Console.Write(priceH.PadLeft(15, ' '));
            Console.Write(phoneH.PadLeft(6, ' '));
            Console.Write(mfgDateH.PadLeft(18, ' ') + Environment.NewLine);
           
            Console.WriteLine(new string('=', 70));
            #endregion

            #region Switch-case to print formatted itemized-list
            int partNumber;
            string partName;
            decimal price;
            long servicePhone;
            DateTime mfgDate;

            for (int i = 0; i <= 4; i++) 
            {
                switch (i) 
                {
                    case 0:
                        partNumber = 123456789;
                        partName = "Flux Capacitor";
                        price = 543456.12M;
                        servicePhone = 8005551212;
                        mfgDate = new DateTime(1985, 2, 1);
                        StringBuilder rec0 = new StringBuilder(
                            String.Format("{0,-11:00-0000000}{1,-20}{2,15:c}{3,14:(000)000-0000}{4,11:yyyy-MM-dd}", partNumber, partName, price, servicePhone,mfgDate));

                        Console.Write(rec0);
                        break;
                    case 1:
                        partNumber = 987654321;
                        partName = "Class 10 Warp Core";

                        price = 1234567.89M;
                        servicePhone = 8001234567;
                        mfgDate = new DateTime(2197, 6, 20);
                        StringBuilder rec1 = new StringBuilder(
                            String.Format("{0,-11:00-0000000}{1,-20}{2,15:c}{3,14:(000)000-0000}{4,11:yyyy-MM-dd}", partNumber, partName, price, servicePhone, mfgDate));

                        Console.WriteLine($"\n{rec1}");
                        break;
                    case 2:
                        partNumber = 850285125;
                        partName = "Towel";
                        price = 999.99M;
                        servicePhone = 5558889999;
                        mfgDate = new DateTime(2020, 10, 10);
                        StringBuilder rec2 = new StringBuilder(
                            String.Format("{0,-11:00-0000000}{1,-20}{2,15:c}{3,14:(000)000-0000}{4,11:yyyy-MM-dd}", partNumber, partName, price, servicePhone, mfgDate));

                        Console.WriteLine($"{rec2}");
                        break;
                    case 3:
                        partNumber = 123456789;
                        partName = "Babel Fish";
                        price = 2349972.88M;
                        servicePhone = 8001934444;
                        mfgDate = new DateTime(1934, 6, 28);
                        StringBuilder rec3 = new StringBuilder(
                            String.Format("{0,-11:00-0000000}{1,-20}{2,15:c}{3,14:(000)000-0000}{4,11:yyyy-MM-dd}", partNumber, partName, price, servicePhone, mfgDate));

                        Console.WriteLine($"{rec3}");
                        break;
                    case 4:
                        partNumber = 876321122;
                        partName = "Rubber Duck";
                        price = 198.34M;
                        servicePhone = 7135551234;
                        mfgDate = new DateTime(2602, 12, 25);
                        StringBuilder rec4 = new StringBuilder(
                            String.Format("{0,-11:00-0000000}{1,-20}{2,15:c}{3,14:(000)000-0000}{4,11:yyyy-MM-dd}", partNumber, partName, price, servicePhone, mfgDate));

                        Console.Write($"{rec4} \n");
                        break;
                }


            
            }


            #endregion
        }
        #endregion
        ////////////////////////////////////
    }
}
