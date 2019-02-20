using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1._12_Events
{
    class Student
    {
        public string name;
        private int money;

        public event EventHandler<MovingEventArgs> Actions;
        
        public Student(string newname, int newmoney)
        {
            this.name = newname;
            this.money = newmoney;
        }

        public void MoneyData()
        {
            Actions(this, new MovingEventArgs("Student " + this.name + " have " + this.money + " !"));
        }

        public void AddMoney(int mon)
        {
            this.money += mon;
            Actions(this, new MovingEventArgs("Student " + this.name + " added " + mon + " money!"));
        }

        public void SpendMoney(int mon)
        {
            if (this.money >= mon)
            {
                this.money -= mon;
                Actions(this, new MovingEventArgs("Student " + this.name + " spended " + mon + " money!"));
            }
            else
                Actions(this, new MovingEventArgs("Student " + this.name + " don't have sufficient money!"));
        }

        public void Move(int distance)
        {
            Actions(this, new MovingEventArgs("Student go " + distance + " km!"));  
        }

        public void Read(string book)
        {
            Actions(this, new MovingEventArgs("Student read the book '" + book + "' ."));
        }

    }
}
