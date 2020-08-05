using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Xml;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine("Date: " + date);
            Console.WriteLine();
            Console.Write("How many employees will be registered? ");
            int quantity = int.Parse(Console.ReadLine());
            List<Funcionário> list = new List<Funcionário>();
            Console.WriteLine();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionário funcionario = new Funcionário(id, name, salary);
                list.Add(funcionario);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have the salary increased: ");
            int searchId = int.Parse(Console.ReadLine());
            Funcionário fun = list.Find(x => x.Id == searchId);

            if (fun.Id == searchId)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fun.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            foreach (Funcionário obj in list)
            {
                if (obj != null)
                {
                    Console.WriteLine(obj);
                }
            }


        }

    }
}

