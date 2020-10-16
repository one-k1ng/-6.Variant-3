using Microsoft.TeamFoundation.Work.WebApi;
using Microsoft.VisualBasic;
using System;

namespace Практика6.Вариант_3
{
    class ResearchTeam
    {
        public enum TimeFrame 
        {
            Year = 1, TwoYears = 2, Long = 3 
        };
        private string researchtopic;
        private string organization;
        private int number;
        private TimeFrame time;
        private Paper[] list;
        

        public ResearchTeam(string _reasearchtopic, string _organization, int _number, TimeFrame _time, Paper[] _list)
        {
            researchtopic = _reasearchtopic;
            organization = _organization;
            number = _number;
            time = _time;
            list = _list;
        }

        public ResearchTeam()
        {
            researchtopic = "Newton third law";
            organization = "World organization of physicists";
            number = 1;
            TimeFrame time = TimeFrame.Year;
            list = new Paper[5];
            for (int i = 0; i < 5; ++i)
            {
                list[i] = new Paper();
            }
        }
    }
}
