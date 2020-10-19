using System;

namespace Lab_01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Артём");
            Person person2 = new Person("Лёха");

            Company company1 = new Company("Шахта1");
            Company company2 = new Company("Шахта2");
            Company company3 = new Company("Шахта3");
            Company company4 = new Company("Шахта4");
            Company company5 = new Company("Шахта5");
            Company company6 = new Company("Шахта6");
 
            company1.AddWorker(person2);
            company2.AddWorker(person2);
            company3.AddWorker(person2);
            company4.AddWorker(person2);
            company5.AddWorker(person2);
            company6.AddWorker(person2);

            person1.EnterCompany(company1);
            person1.EnterCompany(company2);
            company6.AddWorker(person1);
            person1.ExitCompany(company2);

            Console.WriteLine($"{person2.CountOfCompanies} - количество компаний, в которых работает {person2.Name}");
            Console.WriteLine($"{person1.CountOfCompanies} - количество компаний, в которых работает {person1.Name}\n");


            if (company3.AddWorker(person1))
            {
                Console.WriteLine("Сотрудник нанят\n");
            }
            else
            {
                Console.WriteLine("Ошибка\n");
            }

            if (company1.SearchWorkerByName("Георгий") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании\n");
            }
            else
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник не работает в компании\n");
            }

            if (company1.SearchWorkerByName("Артём") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании\n");
            }

            if (company1.ItsWorkerInCompany(person1))
            {
                Console.WriteLine($"Сотрудник {person1.Name} устроен в компанию {company1.CompanyName}\n");
            }
            else
            {
                Console.WriteLine($"Сотрудник {person1.Name} не устроен в компанию {company1.CompanyName}\n");
            }

            if (company1.DeleteWorker(person1))
            {
                Console.WriteLine($"Сотрудник {person1.Name} уволен из компании {company1.CompanyName}\n");
            }

            Console.WriteLine($"{person1.CountOfCompanies} - количество компаний, в которых работает {person1.Name}\n");

            Console.WriteLine(person1);
            Console.WriteLine($"{company1}\n");

            if (company6.SearchWorkerByName("Лёха") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании\n");
            }

            if (company6.ItsWorkerInCompany(person2))
            {
                Console.WriteLine($"Сотрудник {person2.Name} устроен в компанию {company2.CompanyName}");
            }
            else
            {
                Console.WriteLine($"Сотрудник {person2.Name} не устроен в компанию {company2.CompanyName}");
            }

        }
    }
}

