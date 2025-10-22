using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ5
{
    class Gun
    {
        public int Nshot;
        public bool shot {  get; privet set; }

        public void shotgun(string shot)
        {
            if (!shot)
            {
                shot = false;
                Console.WriteLine("Выстрел!");
            }
            else 
            {
                Console.WriteLine("Разряжен");
            }
        }

        public void reloud(bool shot; int Nshot) 
        { 
            shot = true;
       
        }
    }

    class Program
    {
        static void main(string[] args)
        {
            Gun gun = new Gun();
        gun.shotgun();
        }
    }
}
