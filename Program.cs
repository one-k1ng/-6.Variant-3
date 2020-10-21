﻿using Microsoft.TeamFoundation;
using Microsoft.TeamFoundation.Work.WebApi;
using System;

namespace Практика6.Вариант_3
{
    class Program
    {
        static void Main()
        {
            ResearchTeam researchTeam = new ResearchTeam();
            Console.WriteLine(researchTeam.ToShortString());

            Console.WriteLine(researchTeam[ResearchTeam.TimeFrame.Long]);
            Console.WriteLine(researchTeam[ResearchTeam.TimeFrame.TwoYears]);
            Console.WriteLine(researchTeam[ResearchTeam.TimeFrame.Year]);

            Paper[] papers = new Paper[1];
            papers[0] = new Paper();

            researchTeam.ResearcTopic = "Ideal Coffee";
            researchTeam.Organization = "World best Barista";
            researchTeam.Number = 5;
            researchTeam.Time = ResearchTeam.TimeFrame.Long;
            researchTeam.List = papers;

            Console.WriteLine(researchTeam.ToString());

            Paper LastDate;
            LastDate = researchTeam.Lastdate;
            Console.WriteLine(LastDate.ToString());

            //Чистим консоль
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            researchTeam.List = new Paper[0]; //Чистка журнала

            Console.WriteLine("Enter number of articles (rows, coloumns) (You can choose separators between:\n',', '.', '|'): ");
            string[] size = new string[2];

            char[] separators = new char[3];
            separators[0] = ','; separators[1] = '|'; separators[2] = '.'; // Массив содержащий символы-разделители

            string input = Console.ReadLine();
            size = input.Split(separators); // Разделяем вводимую строку и записываем по частям в массив size

            int rows = Convert.ToInt32(size[0]); // 
            int coloumns = Convert.ToInt32(size[1]); // Записываем размеры в переменные типа int

            Paper[] papers1 = new Paper[rows * coloumns];
            Paper[,] papers2 = new Paper[rows, coloumns];
            Paper[][] papers3 = new Paper[rows][];

            // Одномерный массив
            int timerpaper1 = 0;
            for (int i = 0; i < papers1.Length; ++i)
            {
                papers1[i] = new Paper();
            }
            timerpaper1 = Environment.TickCount;
            researchTeam.AddPapers(papers1);
            Console.WriteLine($"{researchTeam.ToString()}\n:One-direct array");
            timerpaper1 = Environment.TickCount - timerpaper1;

            //Чистим консоль
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            researchTeam.List = new Paper[0]; //Чистка журнала

            //Двумерный ступенчатый
            int timerpaper2 = 0;
            int sum = 0;

        }
    }
}
