using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class Program
    {
        static void Main(string[] args)
        {
            GridGame();
            Console.ReadLine();
        }

        static public void GridGame()
        {
            int maxValue = 0;  //Recording max value 
            int counter = 0;  //Recording number of calculations
            int runningValue = 0;
            string position = "";
            int[,] intArray = new int[10, 10];
            Random randNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n Row {0} ", i);
                for (int j = 0; j < 10; j++)
                {
                    intArray[i, j] = randNum.Next(0, 100);
                    Console.Write("{0}  ", intArray[i, j]);
                }
            }

            //Horizontal 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - 3; j++)
                {
                    counter++;
                    runningValue = intArray[i, j] * intArray[i, j + 1] * intArray[i, j + 2];
                    if (runningValue > maxValue)
                    {
                        maxValue = runningValue;
                        position = string.Format("({0},{1}),({2},{3}),({4},{5}) and values: {6} * {7} * {8}={9}", i, j, i, (j + 1), i, (j + 2), intArray[i, j], intArray[i, j + 1], intArray[i, j + 2], maxValue);
                    }
                }
            }
            //Console.Write("\n\n Horizontal max Value:{0}, Position: {1}", maxValue, position);
            //Console.ReadLine();

            //Vertical
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10 - 3; i++)
                {
                    counter++;
                    runningValue = intArray[i, j] * intArray[i + 1, j] * intArray[i + 2, j];
                    if (runningValue > maxValue)
                    {
                        maxValue = runningValue;
                        position = string.Format("({0},{1}),({2},{3}),({4},{5}) and values: {6} * {7} * {8}={9}", i, j, i + 1, j, i + 2, j, intArray[i, j], intArray[i + 1, j], intArray[i + 2, j], maxValue);
                    }
                }
            }
            //Console.Write("\n\n Vertical max Value:{0}, Position: {1}", maxValue, position);
            //Console.ReadLine();

            //Diagnal
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    counter++;
                    runningValue = intArray[i, j] * intArray[i + 1, j + 1] * intArray[i + 2, j + 2];
                    if (runningValue > maxValue)
                    {
                        maxValue = runningValue;
                        position = string.Format("({0},{1}),({2},{3}),({4},{5}) and values: {6} * {7} * {8}={9}", i, j, (i + 1), (j + 1), (i + 2), (j + 2), intArray[i, j], intArray[i + 1, j + 1], intArray[i + 2, j + 2], maxValue);
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 9; j > 1; j--)
                {
                    counter++;
                    runningValue = intArray[i, j] * intArray[i + 1, j - 1] * intArray[i + 2, j - 2];
                    if (runningValue > maxValue)
                    {
                        maxValue = runningValue;
                        position = string.Format("({0},{1}),({2},{3}),({4},{5}) and values: {6} * {7} * {8}={9}", i, j, (i + 1), (j - 1), (i + 2), (j - 2), intArray[i, j], intArray[i + 1, j - 1], intArray[i + 2, j - 2], maxValue);
                    }
                }
            }

            Console.Write("\n\n Max Value:{0}, Position: {1}", maxValue, position);
            Console.Write("\n\n Total calculated {0} time.", counter);
        }
    }
}
