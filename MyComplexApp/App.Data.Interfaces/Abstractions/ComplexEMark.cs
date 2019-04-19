using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.Abstractions
{
    public class ComplexEMark
    {
        public string UserEmail { get; set; }
        public string ModuleName { get; set; }
        public int Mark { get; set; }
        public string Comment { get; set; }
    }
}
