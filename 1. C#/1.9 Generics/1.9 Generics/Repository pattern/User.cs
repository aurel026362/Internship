using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    public class User:IEntity
    {
        public string name;
        public int age;
        public string gender;

        public int Id { get; set; }
    }
}
