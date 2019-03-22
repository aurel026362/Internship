using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy
{
    public partial class Exchange
    {
        public long Id { get; set; }
        public string Valute { get; set; }
        public float InMDL { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
