using System;
using Lab4.Models;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Phone();
            phone.OperatingSystem = OS.Android;
            var human = new Human();
            human.Phone = phone;
        }
    }
}