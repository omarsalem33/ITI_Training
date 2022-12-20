using System;

namespace ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool check; int y;
            //emp1
            Employee employee1 = new Employee();


            //id 1
            do
            {
                Console.WriteLine("enter  id of employee 1:");
                check = int.TryParse(Console.ReadLine(), out y);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);
            employee1.id = y;


            //salay 1
            do
            {
                Console.WriteLine("enter  salary of employee 1:");
                check = int.TryParse(Console.ReadLine(), out y);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);
            employee1.salary = y;


            //gender 1
            do
            {
                Console.WriteLine("enter  gender of employee 1: note(Female or Male only)");
                check = Enum.TryParse<Gender>(Console.ReadLine(), out employee1.gender);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);
            //   day/month/year
            do
            {
                Console.WriteLine("enter  a day of hire  of employee 1:");
                check = int.TryParse(Console.ReadLine(), out y);
                if (check == false || y > 31 || y < 1)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || y > 31 || y < 1);
            employee1.hiring.day = y;
            do
            {
                Console.WriteLine("enter  a month of hire  of employee 1:");
                check = int.TryParse(Console.ReadLine(), out y);
                if (check == false || y > 12 || y < 1)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || y > 12 || y < 1);
            employee1.hiring.month = y;
            do
            {
                Console.WriteLine("enter  a year of hire  of employee 1:");
                check = int.TryParse(Console.ReadLine(), out y);
                if (check == false || y < 2000)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || y < 2000);
            employee1.hiring.year = y;


            //emp2
            int id;
            do
            {
                Console.WriteLine("enter  id of employee 2:");
                check = int.TryParse(Console.ReadLine(), out id);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);


            int salary;
            do
            {
                Console.WriteLine("enter  salary of employee 2:");
                check = int.TryParse(Console.ReadLine(), out salary);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);


            Gender gender;
            do
            {
                Console.WriteLine("enter  gender of employee 1: note(Female or Male only)");
                check = Enum.TryParse<Gender>(Console.ReadLine(), out gender);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check);


            int day;
            do
            {
                Console.WriteLine("enter  a day of hire  of employee 2:");
                check = int.TryParse(Console.ReadLine(), out day);
                if (check == false || day > 31 || day < 1)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || day > 31 || day < 1);


            int month;
            do
            {
                Console.WriteLine("enter  a month of hire  of employee 2:");
                check = int.TryParse(Console.ReadLine(), out month);
                if (check == false || month > 12 || month < 1)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || month > 12 || month < 1);


            int year;
            do
            {
                Console.WriteLine("enter  a year of hire  of employee 2:");
                check = int.TryParse(Console.ReadLine(), out year);
                if (check == false || year < 2000)
                    Console.WriteLine("you enter invalid format ,please try againe ");

            } while (!check || year < 2000);


            Employee employee2 = new Employee(id, salary, day, month, year, gender);


            Employee[] empArr = { employee1, employee2 };

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine("the data of employee " + (i + 1));
                Console.WriteLine(empArr[i]);
                Console.WriteLine("///////////////////");
            }


        }
