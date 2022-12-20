using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class MCQ
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public List<int> answerId { get; set; } = new List<int>();

        public int mark { get; set; }
    }
}
