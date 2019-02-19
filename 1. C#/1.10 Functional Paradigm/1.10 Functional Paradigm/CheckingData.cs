using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10_Functional_Paradigm
{
    static class CheckingData
    {
        
        public static bool CheckFName(this List<Person> lp, string fName)
        {
            //var result = from p in lp where p.fname.Equals(fName) select p.fname;
            //return result != null;

            var result = lp.Any(x => x.fname.Equals(fName));
            return result;
        }
    }
}
