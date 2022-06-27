using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockLambdaEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lstPersons = new List<Person>()
            {
                new Person() {FirstName = "amir",LastName = "alahyari",EntrancePermission = false},
                new Person() {FirstName = "kiyanosh",LastName = "kiyaee",EntrancePermission = false},
                new Person() {FirstName = "keyvan",LastName = "kashefi",EntrancePermission = true},
                new Person() {FirstName = "pejman",LastName = "pejmani",EntrancePermission = false},
                new Person() {FirstName = "behzad",LastName = "eskandari",EntrancePermission = true},
                new Person() {FirstName = "saeed",LastName = "sabzi",EntrancePermission = true},

            };

            Console.WriteLine("enter full name");

            string searchName = Console.ReadLine().ToLower();

            var existingPerson = lstPersons.FirstOrDefault(item => item.FullName == searchName);
            if (existingPerson == null)
            {
                Console.WriteLine($"etelaate shoma sabt nashodeh ast");
            }
            else
            {
                 existingPerson.PermissionEvent += existingPerson.PermissionHandler;
                existingPerson.CheckPermission();
            }
            //bool mojod = false;
            //foreach (var item in lstPersons)
            //{

            //    if (item.FullName == name)
            //    {
            //        mojod = true;
            //        break;
            //    }
            //}
            //if (mojod == true)
            //{
            //    Console.WriteLine($"welcom is {name}");
            //}
            //else
            //{
            //    Console.WriteLine($"shoma ejaze dastresi nadarid");
            //}
        }
    }
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public bool EntrancePermission { get; set; }

        public event EventHandler PermissionEvent;

        public void PermissionHandler(object sender,EventArgs e)
        {
            Console.WriteLine($"shoma mojaveze vorood namdari");
        }
        public void CheckPermission()
        {
            if (EntrancePermission == true)
            {
                Console.WriteLine($"welcome is {FullName}");
            }
            else
            {
                PermissionEvent?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
