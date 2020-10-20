using System.Collections.Generic;
using System;

namespace Lab_01
{
    class Company
    {
        public string CompanyName {private set; get; }
        public int WorkersCount { set; get; }
        private List<Person> Rabotyagi = new List<Person>();

        public Company (string CompanyName)
        {
            this.CompanyName = CompanyName;
        }

        public void AddWorker(Person person)
        {
            if (Rabotyagi.Contains(person) || person.СountOfCompanies >= 5)
            {
                throw new Exception("Работник уже состоит в 5 компаниях");
            }
            person.СountOfCompanies++;
            WorkersCount++;
            Rabotyagi.Add(person);
        }

        public void EmployeeInCompany(Person person)
        {
            if (Rabotyagi.Contains(person))
            {
                Console.WriteLine("Работник в компаании");
            }
            else
            {
                Console.WriteLine("Этого человека нет в компании");
            }    

        }
        public Person SearchEmployee(string sname, string fname, string tname)
        {
            try
            {
                for (int i = 0; i < Rabotyagi.Count; i++)
                {
                    if (String.Compare(Rabotyagi[i].sname, sname) == 0 &&
                        String.Compare(Rabotyagi[i].fname, fname) == 0 &&
                        String.Compare(Rabotyagi[i].tname, tname) == 0)
                    {
                        Console.WriteLine($"Работник {sname} {fname} {tname} найден");
                        return Rabotyagi[i];
                    }
                }
                throw new Exception("Работник не найден");
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
                return null;
            }
            
        }
        public void DeleteWorker(Person person)
        {
            if (person.СountOfCompanies == 0 || !Rabotyagi.Contains(person))
            {
                throw new Exception("Такого работника нет в компании");
            }
            person.СountOfCompanies--;
            WorkersCount--;
            Rabotyagi.Remove(person);
        }

        public override string ToString()
        {
            return $"Компания {CompanyName} содержит {WorkersCount} работников";
        }
    }
}
