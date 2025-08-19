using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_AutomaticProperties
{
    class WeekDayNames
    {
        string[] weekDayFullNames =
        {
            "Sunday",
            "Monday",
            "Tueday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        string[] weekDayShortFullNames =
 {
            "Su",
            "Mo",
            "Tu",
            "We",
            "Th",
            "Fr",
            "Sa"
        };

        private int _currentWeekDayIndex;

        public int CurrentWeekDayIndex
        {
            get { return _currentWeekDayIndex; }
            set { _currentWeekDayIndex = value; }
        }

        public string CurrenctWeekDayName
        {
            get
            {
                return weekDayFullNames[_currentWeekDayIndex];
            }
        }

        public string this[int index]
        {
            get
            {
                return weekDayFullNames[index];
            }
        }

        public string this[string name]
        {
            get
            {
                return weekDayFullNames[Array.IndexOf(weekDayShortFullNames, name)];
            }

    }
        }}
