﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pagination.Classes
{
    class Teacher
    {
        private string name;
        private string surname;
        private int salary;

        public Teacher(string name, string surname, int salary)
        {
            this.name = name;
            this.surname = surname;
            this.salary = salary;
        }

        public override string ToString()
        {
            
            string str = "\t=========================\n";
            str += "\tName: " + name + "\n";
            str += "\tSurname: " + surname + "\n";
            str += "\tSalary: " + salary;
            str += "\n\t=========================";
            return str;
        }
    }
}
