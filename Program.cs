using Microsoft.TeamFoundation;
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
            



        }
    }
}
