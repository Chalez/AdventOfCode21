using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode21
{
    internal class Day2
    {

        int depth = 0;
        int distance = 0;


        void Print(string s)
        {
            Console.WriteLine();
            Console.WriteLine(s);
        }

        public float HorizontalDepthProduct()
        {
            int depth = 0;
            int distance = 0;

            string fileName = @"day2input.txt";

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    String line;
                    int value;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null )
                    {
                        String[] lineSplit = line.Split(' ');

                        String direction = lineSplit[0];
                        value = int.Parse(lineSplit[1]);

                        Console.WriteLine(direction);
                        Console.WriteLine(value);

                        switch (direction)
                        {

                            case "forward":

                                distance += value;
                                break;

                            case "down":
                                depth += value;
                                break;

                            case "up":
                                depth -= value;
                                break;

                            default:
                                Console.WriteLine("This shouldn't be here...");
                                Console.WriteLine(direction);
                                Console.WriteLine(value);
                               
                                break;
                        }

                        i++;
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine("Error Reading File");
            }
            

                float product = depth * distance;

                Console.WriteLine("Depth * Distance: " + product);

                return product;
            }

        }

    }
