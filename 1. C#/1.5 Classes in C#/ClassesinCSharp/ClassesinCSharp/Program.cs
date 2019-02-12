using System;

namespace ClassesinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer boss = new Employer("Alexandru","Chiorescu");

            boss.ModifyStage(3);

            Console.WriteLine("DATA BOSS");
            Console.WriteLine(boss.name + " " + boss.companyName + " " + boss.Stage + " years.");
            boss.ShowWorkers();
            Console.ReadKey();
        }
    }
}
