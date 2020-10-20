using System;

namespace Lab_01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ефимов", "Артём", "Иванович");
            Person person2 = new Person("Баранов", "Алексей", "Артемович");
            Person person3 = new Person("Денисов", "Денис", "Денисович");
            Person person4 = new Person("Иванов", "Иван", "Иванович");


            Company company1 = new Company("Шахта1");
            Company company2 = new Company("Шахта2");
            Company company3 = new Company("Шахта3");
            Company company4 = new Company("Шахта4");
            Company company5 = new Company("Шахта5");
            Company company6 = new Company("Шахта6");

            company1.AddWorker(person1);
            company1.AddWorker(person2);
            company1.AddWorker(person3);
            company1.AddWorker(person4);
            company2.AddWorker(person2);
            company3.AddWorker(person2);
            company4.AddWorker(person2);
            company5.AddWorker(person2);
            try
            {
                company6.AddWorker(person2);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                person1.GetAJob(company5);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            
            try
            {
                person2.GetAJob(company6);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            

            try 
            {
                company3.AddWorker(person1);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            company1.EmployeeInCompany(person1);
            company2.EmployeeInCompany(person1);

            try
            {
                person1.Quit(company1);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                company3.SearchEmployee("Ефимов", "Артём", "Иванович");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }


            Person foundworker = company3.SearchEmployee("Иванов", "Иван", "Иванович");


            try
            {
                company3.DeleteWorker(person1);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            try
            {
                person3.Quit(company1);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine(company1);
            Console.WriteLine(company2);
            Console.WriteLine(company3);
            Console.WriteLine(company4);
            Console.WriteLine(company5);
            Console.WriteLine(company6);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);
            Console.WriteLine(person4);


        }
    }
}

