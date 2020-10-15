using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Практика6.Вариант_3
{
    class Person
    {
        string name; // атрибут имени
        string surname; //атрибут фамилии
        System.DateTime datetime; //атрибут даты рождения

        public Person(string _name, string _surname, DateTime _datetime)
        {
            name = _name;
            surname = _surname;
            datetime = _datetime;
        }
            
        public Person() // Некоторые значения по умолчанию
        {
            name = "Ken";
            surname = "Kaneki";
            datetime = new DateTime(2002, 12, 20);
        }
        
        public string Name // Доступ к полю с именем
        {
            set
            {
                name = value; 
            }
            get
            {
                return name;
            }
        }

        public string Surname // Доступ к полю с фамилией
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }
        
        public int changedata //Изменение (или вывод) с помощью типа инт 
        {
            set
            {
                datetime = new DateTime (value / 10000, value % 10000 / 100 , value % 100);
            }
            get
            {
                return (Convert.ToInt32(datetime.Day) + Convert.ToInt32(datetime.Month) * 100 + Convert.ToInt32(datetime.Year) * 10000);
            }
        }

        public override string ToString()
        {
            return $"{name},{surname},{datetime.ToShortDateString()}";
        }
        public virtual string ToShortString()
        {
            return $"{name},{surname}";
        }
    }
}
