using Pagination.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pagination
{ 
    class Program
    {
        
        static void Main()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers = ProgramBody.FillTeachers(teachers);
            ProgramBody.MenuFunct(teachers);
        }

        
    }
}
