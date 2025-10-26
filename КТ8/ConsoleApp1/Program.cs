using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ОБОБЩЁННЫЙ КЛАСС BOX");
            Box<int> numberBox = new Box<int>();
            numberBox.Put(1488);
            numberBox.Look();
            int number = numberBox.Get();
            Box<string> stringBox = new Box<string>();
            stringBox.Put("Hello");
            stringBox.Look();
            string text = stringBox.Get();
            Console.ReadKey();
        }
    }
    public class Box<T>
    {
        private T _item;

        public void Put(T item)
        {
            _item = item;
            Console.WriteLine($"положили в коробку: {item}");
        }
        public T Get()
        {
            Console.WriteLine($"достали из коробки: {_item}");
            return _item;
        }
        public void Look()
        {
            Console.WriteLine($"в коробке лежит: {_item}");
        }
    }
}
