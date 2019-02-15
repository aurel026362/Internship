using System;
using System.Text;

namespace ClassesinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer("Mihail", "Unicef");
            employer.ModifyStage(3);


            Worker programmer = new Programmer("Augustin", 6700);
            Worker tester = new Tester("Mike", 4240);

            employer.Employ(programmer);
            employer.Employ(tester);

            employer.SayWorkTo(programmer);
            employer.SayWorkTo(tester);

            employer.ShowWorkers();

            Console.ReadKey();
        }
    }
}
