// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EF3.Models
{
    public partial class WorksFor
    {
        public int Essn { get; set; }
        public int Pno { get; set; }
        public int? Hours { get; set; }

        public virtual Employee EssnNavigation { get; set; }
        public virtual Project PnoNavigation { get; set; }
    }
}