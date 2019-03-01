using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._16_CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------
            //---------Singleton------------------------

            var president = President.Instance;
            president.name = "Obama";

            var president2 = President.Instance;
            president2.name = "Trump";

            Console.WriteLine(president.name + " " + president2.name + " " + President.Instance.name);

            Console.WriteLine(president.GetHashCode() + " " + president2.GetHashCode() + "\n");

            //------------------------------------------
            //---------Factory--------------------------

            var firstParcel = FactoryParcel.FragilParcel(20, 4, "Cuza Voda 3/1");
            var secondParcel = FactoryParcel.FragilParcel(10, 3, "Testamiteanu 12/3");
            
            List<Parcel> fragilParcels = new List<Parcel>()
            {
                 firstParcel,
                 secondParcel
            };

            var simpleParcel = FactoryParcel.SimpleParcel(17, 3, "Stefan cel Mare 23");

            Console.WriteLine("Fragil Parcels....\n");

            foreach (var fragilParcel in fragilParcels)
            {
                Console.WriteLine($"Weight (in kg): {fragilParcel.weight}");
                Console.WriteLine($"Size (in m^3): {fragilParcel.size}");
                Console.WriteLine($"Is Fragil: {fragilParcel.fragil}");
                Console.WriteLine($"Adress : {fragilParcel.adress}\n");
            }

            Console.WriteLine("\nSimple Parcel....\n");
            Console.WriteLine($"Weight (in kg): {simpleParcel.weight}");
            Console.WriteLine($"Size (in m^3): {simpleParcel.size}");
            Console.WriteLine($"Is Fragil: {simpleParcel.fragil}");
            Console.WriteLine($"Adress : {simpleParcel.adress}\n");

            Console.ReadKey();
        }
    }
}
