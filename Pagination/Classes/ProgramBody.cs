using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pagination.Classes
{
    static class ProgramBody
    {
        public static void MenuFunct(IEnumerable<Teacher> teachers)
        {
            int skipped = 0;
            var coll = teachers.Skip(skipped * 5).Take(5);
            while (true)
            {
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    coll = teachers.Skip(skipped * 5).Take(5);
                    if (coll.Count() <= 0)
                    {
                        skipped--;
                        break;
                    }

                    Console.WriteLine("    ================================");
                    foreach (var item in coll)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(item);
                        Console.ResetColor();
                    }
                    Console.SetCursorPosition(0, 26);
                    Console.WriteLine("    ================================");
                    Console.SetCursorPosition(7, 27);
                    Console.WriteLine("\t (<)  Сторiнка: " + (skipped + 1) + "  (>)");

                    for (int y = 1; y <= 25; y++)
                    {
                        Console.SetCursorPosition(35, y);
                        Console.WriteLine("|");
                        Console.SetCursorPosition(4, y);
                        Console.WriteLine("|");
                    }


                    keyInfo = Console.ReadKey();
                } while (keyInfo.Key != ConsoleKey.LeftArrow && keyInfo.Key != ConsoleKey.RightArrow);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (skipped > 0)
                            {
                                skipped--;
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (skipped < teachers.Count() / 5)
                            {
                                skipped++;
                            }
                            break;
                        }
                }
            }
        }

        public static List<Teacher> FillTeachers(List<Teacher> teachers)
        {
            string[] names = new string[]
           {
         "Denys",
         "Sasha",
         "Andriy",
         "Maksym",
         "Vasyliy",
         "Anatoliy",
         "Stepan",
         "Dmytro",
         "Yura",
         "Olia",
         "Viktoria",
         "Oksana",
         "Diana",
         "Nazar",
         "Vitaliy",
         "Kostja"
           };
            string[] surnames = new string[]
            {
         "Surname12213",
         "Surname65429",
         "Surname23421",
         "Surname45312",
         "Surname53433",
         "Surname12533"
            };

            Random random = new Random();
            for (int i = 0; i < random.Next(30, 42); i++)
            {
                teachers
                      .Add(new Teacher(names[random.Next(0, names.Length - 1)],
                      surnames[random.Next(0, surnames.Length - 1)],
                      random.Next(10000, 300000)));
            }

            return teachers;
        }
    }
}
