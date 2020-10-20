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

            string Name = "Ken";
            string Surname = "Kaneki"


        }
    }
}
