using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder optionList = new StringBuilder();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            string dish1 = string.Empty;
            string dish2 = string.Empty;
            string dish3 = string.Empty;
            string dish4 = string.Empty;

            Console.WriteLine("Input: [Time][Dish Type Options]:");
            string[] option = Console.ReadLine().ToString().Split(',');

            if (option[0].ToUpper() == "MORNING" || option[0].ToUpper() == "NIGHT")
            {
                int optCount = option.ToList().Count();
                for (int i = 1; i < optCount; i++)
                {
                    switch (option[i].ToString())
                    {
                        case "1":
                            count1++;
                            dish1 = (getItemFromOpt(Convert.ToInt32(option[i]), option[0].ToString().ToUpper()));
                            break;
                        case "2":
                            count2++;
                            dish2 = "," + (getItemFromOpt(Convert.ToInt32(option[i]), option[0].ToString().ToUpper()));
                            break;
                        case "3":
                            count3++;
                            dish3 = "," + (getItemFromOpt(Convert.ToInt32(option[i]), option[0].ToString().ToUpper()));
                            break;
                        case "4":
                            count4++;
                            dish4 = "," + (getItemFromOpt(Convert.ToInt32(option[i]), option[0].ToString().ToUpper()));
                            break;
                    }
                }

                if (count1 > 1)
                    dish1 += "(x" + count1 + ")";

                if (count2 > 1)
                    dish2 += "(x" + count2 + ")";

                if (count3 > 1)
                    dish3 += "(x" + count3 + ")";

                if (count4 > 1)
                    dish4 += "(x" + count4 + ")";

                Console.WriteLine("{0}{1}{2}{3}", dish1, dish2, dish3, dish4);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid time! Please input morning or night.");
                Console.ReadKey();
            }
        }

        private static string getItemFromOpt(int optId, string time)
        {
            string returnItem = "[Unavailable item]";

            switch (time)
            {
                case "MORNING":
                    if (optId == 1)
                        returnItem = "eggs";
                    else if (optId == 2)
                        returnItem = "Toast";
                    else if (optId == 3)
                        returnItem = "coffee";
                    break;
                case "NIGHT":
                    if (optId == 1)
                        returnItem = "steak";
                    else if (optId == 2)
                        returnItem = "potato";
                    else if (optId == 3)
                        returnItem = "wine";
                    else if (optId == 4)
                        returnItem = "cake";
                    break;
            }
            return returnItem;
        }
    }
}
