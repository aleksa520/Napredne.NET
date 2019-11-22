using Domain;
using System;
using System.Collections.Generic;

namespace LambdaIzrazi
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            #region
            employees.Add(new Employee
            {
                Id = 1,
                Name = "Pera",
                LastName = "Peric",
                Department = new Department()
                {
                    Id = 1,
                    Name = "Department 1"
                }
            });
            employees.Add(new Employee
            {
                Id = 2,
                Name = "Mika",
                LastName = "Mikic",
                Department = new Department()
                {
                    Id = 2,
                    Name = "Department 2"
                }
            });
            employees.Add(new Employee
            {
                Id = 3,
                Name = "Pera",
                LastName = "Zikic",
                Department = new Department()
                {
                    Id = 1,
                    Name = "Department 1"
                }
            });
            employees.Add(new Employee
            {
                Id = 4,
                Name = "Nemanja",
                LastName = "Milic",
                Department = new Department()
                {
                    Id = 1,
                    Name = "Department 1"
                }
            });
            #endregion
            Pretraga((e) => {
                var n = e.Name.ToUpper();
                return e.Name == "PERA"; } );
        }
        //private static void PronadjiPere()
        //{
        //    foreach (Employee e in employees)
        //    {
        //        if (e.Name == "Pera") Console.WriteLine($"{e.Id} {e.Name} {e.LastName} {e.Department.Name}");
        //    }
        //}
        //public static bool UslovPera(Employee e)
        //{
        //    return e.Name == "Pera";
        //}

        //public static bool UslovOdeljenje1(Employee e)
        //{
        //    return e.Department.Id == 1;
        //}

        //delegate bool Uslov(Employee e, object o);
        private static void Pretraga(Func<Employee, bool> uslov)
        {
            foreach (Employee e in employees)
            {
                if (uslov(e))
                    Console.WriteLine($"{e.Id} {e.Name} {e.LastName} {e.Department.Name}");
            }
        }

        private static void Funk1(Action funk)
        {

        }

        //private static void PronadjiuOdeljenju1()
        //{
        //    foreach (Employee e in employees)
        //    {
        //        if (e.Department.Id == 1) Console.WriteLine($"{e.Id} {e.Name} {e.LastName} {e.Department.Name}");
        //    }
        //}

    }
}
