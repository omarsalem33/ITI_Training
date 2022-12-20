using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public static class Static
    {

        public static void MakeQuestion(ChooseOneAnswer oneAnswer, MCQ multiAnswer, TFQs trueFalse)
        {

            trueFalse.Head = "is ronaldo the bist player in world in 2009 ?";
            trueFalse.answerId = 1;
            trueFalse.mark = 5;
            trueFalse.Body = "Information about football";

            oneAnswer.Head = "which of these is a programing language ";
            oneAnswer.answerId = 3;
            oneAnswer.mark = 5;
            oneAnswer.Body = "Information about Programing";

            multiAnswer.Head = "which of these is a best programing language ";
            multiAnswer.answerId.Add(1);
          
            multiAnswer.mark = 3;
            multiAnswer.Body = "Information about Programing";

        }

    }
}
