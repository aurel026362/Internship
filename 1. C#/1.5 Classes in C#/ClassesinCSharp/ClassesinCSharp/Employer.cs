using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Employer:Person
    {
        public string companyName;
        private List<Worker> workers = new List<Worker>();

        public int Stage { get; private set; }
        

        public Employer(string name, string companyName):base(name)
        {
            this.companyName = companyName;
        }

        public void ModifyStage(int newStage)
        {
            Stage = newStage;
        }

        public void Employ(Worker worker)
        {
            workers.Add(worker);
        }

        public void SayWorkTo(IWork work)
        {
            work.Work();
        }

        public void ShowWorkers()
        {
            foreach (Worker w in workers)
            {
                Console.WriteLine(w.name + " " + w.salary);
            }
        }
    }
}
