using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _1._12_Events
{
    class Events
    {
        public Events()
        {
            Student student = new Student("Aurel", 320);

            EventForMe me = new EventForMe();
            EventForBank bank = new EventForBank();
            
            student.Notificator += me.Notify;
            student.Notificator += bank.Notify; 

            student.Move(10);

            student.Read("Goat with 3 kids");

            student.MoneyData();

            student.AddMoney(25);

            student.MoneyData();

            student.SpendMoney(145);

            student.MoneyData();

            student.SpendMoney(250);

            student.MoneyData();
            student.Notificator -= bank.Notify;
            student.Notificator -= me.Notify;

            WeakEventManager<Student, StudentEventArgs>.AddHandler(student, "Notificator", me.Notify);
            WeakEventManager<Student, StudentEventArgs>.AddHandler(student, "Notificator", bank.Notify);
            student.Move(12);
            Console.WriteLine("4444444444444444444444");

            WeakEventManager<Student, StudentEventArgs>.RemoveHandler(student, "Notificator", bank.Notify);
            student.Move(12);
        }

        //private void ShowAction(object sender, MovingEventArgs e)
        //{
        //    Console.WriteLine(e.Message);
        //}
    }
}
