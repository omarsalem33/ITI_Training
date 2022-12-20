using ExaminationSystem.Models;
using System;
using System.Collections.Generic;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ChooseOneAnswer oneAnswer = new ChooseOneAnswer();
            MCQ multiAnswer = new MCQ();
            TFQs trueFalse = new TFQs();


            Console.WriteLine("press enter to containue ");
            Console.ReadLine();

          Static.MakeQuestion(oneAnswer, multiAnswer, trueFalse);
            int answer, score = 0;
            List<int> multiAnswers = new List<int>();

            Console.WriteLine($"{trueFalse.Body}----Choose Answer Number");
            Console.WriteLine(trueFalse.Head);
            answer = int.Parse(Console.ReadLine());
            if (answer == trueFalse.answerId)
            {

                score += trueFalse.mark;
            }
            Console.WriteLine("");


            Console.WriteLine($"{oneAnswer.Body}----Choose Answer Number");
            Console.WriteLine(oneAnswer.Head);
            answer = int.Parse(Console.ReadLine());
            if (answer == oneAnswer.answerId)
            {
                score += oneAnswer.mark;
            }
            Console.WriteLine("");



            //one answer Question
            Console.WriteLine($"{oneAnswer.Body}----Choose Answer Number");
            Console.WriteLine(oneAnswer.Head);

            while (multiAnswers.Count < multiAnswer.answerId.Count)
            {
                multiAnswers.Add(Convert.ToInt32(Console.ReadLine()));
            }


            for (int i = 0; i < multiAnswer.answerId.Count; i++)
            {
                if (multiAnswers[i] == multiAnswer.answerId[i])
                {
                    score += 1;
                }
            }


            Console.WriteLine($"the total score :{score}");
        }

    }
    }

