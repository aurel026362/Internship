using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesinCSharp
{
    class Employer:Person
    {
        public string companyName;
        Worker[] listWorker;

        public int Stage { get; private set; }

        public Employer(string name, string companyName):base(name)
        {
            this.companyName = companyName;
            Employ(2);
        }

        public void Manage()
        {
            Console.WriteLine("Managing");
        }

        public void ModifyStage(int newStage)
        {
            Stage = newStage;
        }

        private void Employ(int nrWorker)
        {
            listWorker = new Worker[nrWorker];
            string name, function;
            for (int i = 0; i < nrWorker; i++)
            {
                Console.Write("Numele: ");
                name = Convert.ToString(Console.ReadLine());
                Console.Write("Functia: ");
                function = Convert.ToString(Console.ReadLine());
                listWorker[i] = new Worker(name, function);
            }
        }

        public void ShowWorkers()
        {
            int n = listWorker.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + " " + listWorker[i].name + " " + listWorker[i].functionWorker);
            }
        }
    }
}
