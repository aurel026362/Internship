using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._11_LinqAdv.OperationTech
{
    class DefaultDel
    {
        delegate void MyFunctions();
        Predicate<int> isPositive;
        public DefaultDel()
        {
            MyFunctions f;
            
            f = ActionExample;
            f += PredicateExample;
            f += FuncExample;
            f?.Invoke();
        }

        private void FuncExample()
        {
            Console.WriteLine("\n Func Example: ");
            Func<int, int> retFunc = Factorial;
            int n1 = GetInt(6, retFunc);
            Console.WriteLine(n1);  // 720

            int n2 = GetInt(6, x => x * x);
            Console.WriteLine(n2); // 36
        }

        int GetInt(int x1, Func<int, int> retF)
        {
            int result = 0;
            if (x1 > 0)
                result = retF(x1);
            return result;
        }
        int Factorial(int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        private void PredicateExample()
        {
            Console.WriteLine("\n Predicate Example: ");
            Predicate<int> isPositive = delegate (int x) { return x > 0; };
            
            Console.WriteLine(isPositive(20));
            Console.WriteLine(isPositive(-20));
        }

        private void ActionExample()
        {
            Console.WriteLine("\nAction Example:");
            Action<int, int> op;
            op = Add;
            Operation(10, 6, op);
            op = Substract;
            Operation(10, 6, op);
        }

        void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
                op(x1, x2);
        }

        void Add(int x1, int x2)
        {
            Console.WriteLine("Suma valorilor: " + (x1 + x2));
        }

        void Substract(int x1, int x2)
        {
            Console.WriteLine("Diferenta valorilor: " + (x1 - x2));
        }
    }
}
