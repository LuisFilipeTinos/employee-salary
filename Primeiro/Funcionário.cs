using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Primeiro
{
    class Funcionário
    {
        //---------------------------------------------AUTOPROPERTIES E ATRIBUTOS-------------------------------
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        //-----------------------------------------------------CONSTRUTORES E SOBRECARGAS------------------------
        public Funcionário(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }   
        //-----------------------------------------------------MÉTODOS E SOBRECARGAS-----------------------------
    
        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * percentage / 100.0);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
