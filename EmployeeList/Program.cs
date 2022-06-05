// using System;
// using System.Collections.Generic;

// namespace EmployeeList
// {
//     class program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("tedad karmandan ra vared konid : ");
//             int tedad = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("*********************************************");

//             List<Employee> employees = new List<Employee>();
//             for (int i = 1; i <= tedad; i++)
//             {
//                 Employee objEmployee = new Employee();

//                 Console.Write($"name karmande {i} : ");
//                 objEmployee.Name = Console.ReadLine();

//                 Console.Write($"Haghzahme karmande {i} : ");
//                 objEmployee.Haghzahmeh = Convert.ToInt32(Console.ReadLine());

//                 Console.Write($"saat kar karmande {i} : ");
//                 objEmployee.SaatKarDarroz = Convert.ToInt32(Console.ReadLine());

//                 Console.WriteLine("");

//                 employees.Add(objEmployee);

//             }

//             Console.WriteLine("*********************************************");

//             foreach (var item in employees)
//             {
//                 Console.WriteLine($"name karmand : {item.Name}");
//                 Console.WriteLine($"mizan daramad dar saat : {item.Haghzahmeh}");
//                 Console.WriteLine($"saat kari dar roz : {item.SaatKarDarroz}");
//                 Console.WriteLine($"daramad mahiyane : {item.daramadmahiuane}");
//                 Console.WriteLine("");
//             }
//             Console.ReadKey();

//         }
//     }

//     public class Employee
//     {
//         public string Name { get; set; }

//         public int Haghzahmeh { get; set; }

//         public int SaatKarDarroz { get; set; }

//         private int Daramadmahiuane;

//         public int daramadmahiuane
//         {
//             get
//             {
//                 int dastmozd = (Haghzahmeh * SaatKarDarroz) * 24;
//                 return dastmozd;
//             }
//             set { Daramadmahiuane = value; }
//         }




//     }
// }
using System;
using System.Collections.Generic;

namespace EmployeeList
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("tedad karmandan ra vared konid : ");
            int tedad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*********************************************");

            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= tedad; i++)
            {
                Employee objEmployee = new Employee();

                Console.Write($"name karmande {i} : ");
                objEmployee.Name = Console.ReadLine();

                Console.Write($"Haghzahme karmande {i} : ");
                objEmployee.Haghzahmeh = Convert.ToInt32(Console.ReadLine());

                Console.Write($"saat kar karmande {i} : ");
                objEmployee.SaatKarDarroz = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                employees.Add(objEmployee);

            }

            Console.WriteLine("*********************************************");

            foreach (var item in employees)
            {
                Console.WriteLine($"name karmand : {item.Name}");
                Console.WriteLine($"mizan daramad dar saat : {item.Haghzahmeh}");
                Console.WriteLine($"saat kari dar roz : {item.SaatKarDarroz}");
                Console.WriteLine($"daramad mahiyane : {item.daramadmahiuane}");
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public int Haghzahmeh { get; set; }

        public int SaatKarDarroz { get; set; }

        private int Daramadmahiuane;

        public int daramadmahiuane
        {
            get
            {
                int dastmozd = (Haghzahmeh * SaatKarDarroz) * 24;
                return dastmozd;
            }
            set { Daramadmahiuane = value; }
        }




    }
}
