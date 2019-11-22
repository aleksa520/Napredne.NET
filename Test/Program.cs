using DatabaseEFCore;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //V1Context context = new V1Context();
            
            //context.Dispose();

            using(V1Context context = new V1Context())
            {
                #region insert data
                //Employee newEmployee = new Employee
                //{
                //    Name = "Pera",
                //    LastName = "Peric",
                //    Address = "Nepoznata",
                //    Department = new Department { Name = "Finance" }
                //};
                //context.Add(newEmployee);

                //Employee newEmployee1 = new Employee
                //{
                //    Name = "Lazar",
                //    LastName = "Miric",
                //    Address = "Kosovska 1",
                //    Department = new Department { Name = "Programmer" }
                //};

                //Employee newEmployee2 = new Employee
                //{
                //    Name = "Katarina",
                //    LastName = "Milic",
                //    Address = "Strahinjica Bana 12",
                //    Department = new Department { Name = "Weitress" }
                //};
                
                //Employee newEmployee3 = new Employee
                //{
                //    Name = "Aleksa",
                //    LastName = "Pavlovic",
                //    Address = "Vojvode Stepe 320",
                //    Department = new Department { Name = "Engeneer" }
                //};
                //context.AddRange(newEmployee3);

                //context.SaveChanges();
                #endregion

                //List<Employee> employees = context.Employees.Include(e => e.Department).ToList();
                //List<Employee> employeesd1 = context.Employees.Where(e => e.Department.Id == 1).ToList();

                //foreach(Employee e in employeesd1)
                //{
                //    Console.WriteLine($"Employee: {e.Id} {e.Name} {e.LastName} {e.Department.Name}");
                //}

                //Employee pera = context.Employees.Find(1);
                //Console.WriteLine($"{pera.Id} {pera.Name} {pera.LastName}");
                //pera.LastName = "Mikic";

                //Department d = context.Departments.Find(1);
                //Employee e1 = new Employee { Name = "Zika", LastName = "Mikic", Department = new Department() { Name = "d1" } };






                Department department = context.Departments.First();
                Employee newEmployee = new Employee {
                  
                    Name = "Zika",
                    LastName = "Mikic",
                    Department = new Department()
                    {
                        Id = 1
                    }
                };
                //context.Attach(e1);
                //context.Entry(e1).State = EntityState.Modified;
               
                context.Add(newEmployee);
                context.SaveChanges();

            }

        }
    }
}
