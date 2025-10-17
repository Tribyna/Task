using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            SetAge(age); // Используем метод для валидации
        }

        public string GetName() => name;

        public int GetAge() => age;

        private void SetAge(int value)
        {
            if (value < 0 || value > 150)
                throw new ArgumentException("Invalid age");
            age = value;
        }

        public void HaveBirthday()
        {
            SetAge(age + 1); // Контролируемое изменение возраста
        }
    }
}
