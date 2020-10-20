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

            ResearchTeam[TimeFrame.Current];
            ResearchTeam[TimeFrame.Future];
            ResearchTeam[TimeFrame.Past];


        }
    }
}
