using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.TeamFoundation.Work.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Практика6.Вариант_3
{
    class ResearchTeam
    {
        public enum TimeFrame {Year, TwoYears, Long};
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
            researchtopic = "Deal ideal coffee";
            organization = "World organization of coffeeman";
            number = 1;
            TimeFrame time = TimeFrame.Year;
            list = new Paper[3];
            for (int i = 0; i < 3; ++i)
            {
                list[i] = new Paper();
            }
        }

        public string ResearcTopic
        {
            get
            {
                return researchtopic;
            }
            set
            {
                researchtopic = value;
            }
        }

        public string Organization
        {
            get
            {
                return organization;
            }
            set
            {
                organization = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public TimeFrame Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public Paper[] List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }

        public Paper Lastdate
        {
            get
            {
                if (list[0] == null)
                {
                    return null;
                }
                else
                {
                    Paper temp = new Paper();
                    temp = list[0];
                    for (int i = 1; i < list.Length; ++i)
                    {
                        if (temp.date < list[i].date)
                            temp.date = list[i].date;
                    }
                    return temp;
                }
            }
        }
        public bool this [TimeFrame index]
        {
            get
            {
                if (index == time)
                    return true;
                else
                    return false;
            }
        }
        public void AddPapers (params Paper[] _newPapers)
        {
            if (list.Length == 0)
            {
                list = new Paper[_newPapers.Length];
                for (int j = 0; j<_newPapers.Length; ++j)
                {
                    list[j] = _newPapers[j];
                }
            }
            else
            {
                int size = list.Length;
                Paper[] temp = new Paper[list.Length];
                for (int j = 0; j < size; ++j)
                {
                    temp[j] = list[j];
                }
                list = new Paper[size + _newPapers.Length];
                for (int j = 0; j < size; ++j)
                {
                    list[j] = temp[j];
                }
                for (int j = 0; j < size; ++j)
                {
                    list[j] = _newPapers[j - size];
                }
            }
        }
        public override string ToString()
        {
            string output;
            output = $"{researchtopic}, {organization} {Convert.ToString(number)}, {time.ToString()}";
            for (int i = 0; i < list.Length; ++i)
            {
                if (list[i] == null)
                {
                    break;
                }
                output += $"\nPaper #{i + 1}: {list[i].ToString()}";
            }
            return output;
        }
        public virtual string ToShortString()
        {
            string output;
            output = $"{researchtopic}, {organization}, {Convert.ToString(number)}, {Convert.ToString(time)}";
            return output;
        }
    }
}
