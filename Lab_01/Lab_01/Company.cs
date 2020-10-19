using System.Collections.Generic;
using System;

namespace Lab_01
{
    class Company
    {
        public string CompanyName {private set; get; }
        private List<Person> Rabotyagi;

        public Company (string CompanyName)
        {
            this.CompanyName = CompanyName;
            this.Rabotyagi = new List<Person>();
        }

        public bool AddWorker(Person person)
        {
            if (Rabotyagi.Contains(person) || person.CountOfCompanies >= 5)
            {
                return false;
            }
            person.CountOfCompanies++;
            Rabotyagi.Add(person);
            return true;
        }

        public bool ItsWorkerInCompany(Person person)
        {
            return Rabotyagi.Contains(person);
        }
        public Person SearchWorkerByName(string name)
        {
            foreach (var n in Rabotyagi)
            {
                if (n.Name.Contains(name))
                {
                    return n;
                }
            }
            return null;
        }
        public bool DeleteWorker(Person person)
        {
            if (person.CountOfCompanies == 0 || !Rabotyagi.Contains(person))
            {
                return false;
            }
            person.CountOfCompanies--;
            Rabotyagi.Remove(person);
            return true;
        }
    }
}
