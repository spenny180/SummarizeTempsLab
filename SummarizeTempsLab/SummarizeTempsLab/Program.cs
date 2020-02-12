
using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFile = "data.txt";
            Console.WriteLine("Enter Data File Name");
            myFile = Console.ReadLine();
            string ayyy = "";
            if (File.Exists(myFile))
            {
                do
                {
                    Console.WriteLine("Cool Beans");
                    int BaseTemp;
                    string input;
                    Console.WriteLine("Enter the threshold Temp");
                    input = Console.ReadLine();
                    BaseTemp = int.Parse(input);

                    int Temperature;
                    int Above = 0;
                    int Below = 0;
                    int sum = 0;
                    int aboveSum = 0;
                    int belowSum = 0;
                    int avgAbove;
                    int avgBelow;
                    int mean;


                    using (StreamReader sr = File.OpenText(myFile))
                    {
                        string line = sr.ReadLine();


                        while (line != null)
                        {
                            Temperature = int.Parse(line);

                            if (Temperature >= BaseTemp)
                            {
                                Above++;
                                sum = sum + Temperature;
                                aboveSum = aboveSum + Temperature;

                            }
                            else
                            {
                                Below++;
                                sum = sum + Temperature;
                                belowSum = belowSum + Temperature;

                            }
                            line = sr.ReadLine();
                        }

                    }

                    avgAbove = aboveSum / Above;
                    avgBelow = belowSum / Below;
                    mean = sum / (Above + Below);

                    Console.WriteLine("The Number of Temps Above the Threshold is " + Above);
                    Console.WriteLine("The Average Temp Above the Threshold is " + avgAbove);
                    Console.WriteLine("The Number of Temps Below the Threshold is " + Below);
                    Console.WriteLine("The Average Temp Below the Threshold is " + avgBelow);
                    Console.WriteLine("The Overall Average Temp is " + mean);
                    Console.WriteLine("Would you like to continue? Type yes or no");
                    ayyy = Console.ReadLine();
                } while (ayyy == "yes");
                Console.WriteLine("Program has ended, Thank You {:");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }

        }
    }
}