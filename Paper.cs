using System;

namespace Практика6.Вариант_3
{
    class Paper
    {
        public string title; // Название публикации
        public Person data; // Автор публикации
        public System.DateTime date; // Дата публикации

        public Paper(Person _data, string _title, DateTime _date)
        {
            data = _data;
            title = _title;
            date = _date;
        }

        public Paper ()
        {
            data = new Person();
            title = "How to make a great coffee";
            date = new DateTime(2020, 11, 01);
        }

        public override string ToString()
        {
            return $"{data.ToString()},{title},{date}";
        }
    }
}
