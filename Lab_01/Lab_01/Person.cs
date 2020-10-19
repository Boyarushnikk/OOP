using System;

namespace Lab_01
{
    class Person
    {
        public string Name { private set; get; }
        public int CountOfCompanies { set; get; }

        public Person (string name)
        {
            this.CountOfCompanies = 0;
            this.Name = name;
        }

        public bool EnterCompany(Company company)
        {
            return company.AddWorker(this);
        }
        public bool ExitCompany(Company company)
        {
            return company.DeleteWorker(this);
        }
    }
}
