using System;

namespace Lab_01
{
    class Person
    {
        public string fname { private set; get; }
        public string sname { private set; get; }
        public string tname { private set; get; }


        public int СountOfCompanies { set; get; }

        public Person (string sname, string fname, string tname)
        {
            this.СountOfCompanies = 0;
            this.fname = fname;
            this.sname = sname;
            this.tname = tname;
        }

        public void GetAJob(Company company)
        {
            company.AddWorker(this);
        }
        public void Quit(Company company)
        {
            company.DeleteWorker(this);
        }

        public override string ToString()
        {
            return $"{sname} {fname} {tname} работает в {СountOfCompanies} компаниях";
        }
    }
}
