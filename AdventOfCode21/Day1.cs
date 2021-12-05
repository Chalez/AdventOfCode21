using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode21
{
    internal class Day1
    {


        public void countIncreases()
        {
            string fileName = @"day1input.txt";

            string text = System.IO.File.ReadAllText(fileName);

            Console.WriteLine(text);

            string[] lines = text.Split('\n');
            int[] nums = new int[lines.Length];

            int increaseCount = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                try { nums[i] = int.Parse(lines[i]); }
                catch (FormatException e){ break; }
            }



            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] < nums[i + 1])
                {
                    increaseCount++;
                }
            }

            Console.WriteLine("Increases: ");
            Console.Write(increaseCount);

        }
        

    }
}
