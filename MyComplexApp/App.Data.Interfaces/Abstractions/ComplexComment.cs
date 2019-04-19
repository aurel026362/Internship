using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.Abstractions
{
    public class ComplexComment
    {
        public string EMail { get; set; }
        public string ThemeName { get; set; }
        public string DateComment { get; set; }
        public string Content { get; set; }
    }
}
