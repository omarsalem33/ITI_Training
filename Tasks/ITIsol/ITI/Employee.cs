using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
    class Employee
    {
        public Gender gender;
        public date hiring;
        public int id { get; set; }
        public int salary { get; set; }


        public Employee()
        {

        }
        public Employee(int _id, int _salary, int _day, int _month, int _year, Gender _gender)
        {
            id = _id;
            salary = _salary;
            hiring.day = _day;
            hiring.month = _month;
            hiring.year = _year;
            gender = _gender;
        }

        public override string ToString()
        {
            return $"id is {id}      salary is {salary:C}      Gender is {gender}      hire date {hiring.day}/{hiring.month}/{hiring.year}";
        }



    }
    enum Gender
    {
        Male, Female
    }
    struct date
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
    }
}
