using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode21
{
    internal class Day3
    {

        public int PowerConsumption()
        {
            string fileName = @"day3input.txt";

            string text = System.IO.File.ReadAllText(fileName);

            string[] binaryStrings = text.Split('\n');
            int[] digitCount = new int[binaryStrings.Length];

            foreach(string line in binaryStrings)
            {
                for(int i = 0; i < line.Length; i++) {
                    //Console.WriteLine(line[i]);
                    
                    if(line[i] == '0')
                    {
                        digitCount[i]--;
                    }

                    if(line[i] == '1')
                    {
                        digitCount[i]++;
                    }

                }

            }

            String gammaRate = "";
            String epsilonRate = "";

            for(int i = 0; i < digitCount.Length; i++)
            {
                if (digitCount[i] > 0)
                {
                    epsilonRate += '0';
                    gammaRate += '1';
                }
                else if(digitCount[i] < 0)
                {
                    epsilonRate += '1';
                    gammaRate += '0'; 
                }
            }

            //Console.WriteLine(gammaRate);

            int gammaDecimal = Convert.ToInt32(gammaRate, 2);

            Console.WriteLine(gammaDecimal);

            int epsilonDecimal = Convert.ToInt32(epsilonRate, 2);

            Console.WriteLine(epsilonDecimal);

            Console.WriteLine(gammaDecimal * epsilonDecimal);




            return 0;
        }

        


    }
}
