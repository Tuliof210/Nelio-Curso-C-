using System;
using Empresa.Entities.Enums;
using System.Collections.Generic;

namespace Empresa.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public double BaseSalary { get; private set; }
        public WorkerLevel Level { get; private set; }

        //composição
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker(){}
        public Worker(string name, WorkerLevel lvl, double salary, Department department)
        {
            this.Name = name;
            this.Level = lvl;
            this.BaseSalary = salary;
            this.Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income (int month, int year)
        {
            double sum = this.BaseSalary;

            foreach(HourContract c in Contracts)
            {
                if (c.Date.Year == year && c.Date.Month == month) sum += c.TotalValue();
            }

            return sum;
        }
    }
}
