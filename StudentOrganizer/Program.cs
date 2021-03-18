using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            List<Student> studenten = new List<Student>();

            studenten.Add(new Student());
            studenten.Add(new Student());
            studenten.Add(new Student());
            studenten.Add(new Student());

            while (running)
            {
                Start: 
                switch (SelectMenu("Student gegevens invoeren","Student Gegevens Tonen","Student verwijderen"))
                {
                    case 1:
                        int keuze = SelectMenu(studenten);

                        if (studenten[keuze].Leeftijd != -1)
                        {

                            switch (SelectMenu("Gegevens bijhouden","Gegevens aanpassen"))
                            {
                                case 1: goto Start;

                                default:
                                    Console.WriteLine("De gegevens worden aangepast");
                                    break;
                            }

                        }

                        Console.Write("Geef de student zijn naam in: ");
                        studenten[keuze].Naam = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Geef de student zijn leeftijd in: ");
                        studenten[keuze].Leeftijd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Geef de student zijn PuntenComunicatie in: ");
                        studenten[keuze].PuntenComunicatie = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Geef de student zijn PuntenProgrammingPrinciples in: ");
                        studenten[keuze].PuntenProgrammingPrinciples = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Geef de student zijn PuntenWebTech in: ");
                        studenten[keuze].PuntenWebTech = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        studenten[keuze].Klas = SelectMenu();
                        Console.WriteLine();
                        break;
                    case 2:
                        foreach (var item in studenten)
                        {
                            if (item.Leeftijd != -1)
                            {
                                item.GeefOverzicht();
                                Console.WriteLine();
                            }                          
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        if (NietLegenStudenten(studenten).Count != 0)
                        {
                            studenten[SelectMenuIngevulde(NietLegenStudenten(studenten))].Clear();
                            Console.WriteLine("De student is verwijderd");
                        }
                        else
                        {
                            Console.WriteLine("Er zijn momenteel geen studenten ingevult");
                        }
                        
                        Console.ReadKey();
                        break;
                }
            }

        }
        static int SelectMenu(List<Student> studenten)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                for (int i = 0; i < studenten.Count; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - 1) / 2, Console.CursorTop);
                    Console.WriteLine("Student: "+(i + 1));
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), studenten.Count);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection-1;
        }
        static int SelectMenu(params string[] menu)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - menu[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine((i + 1 + ": " + menu[i]));
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection;
        }
        static Klassen SelectMenu()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                Console.SetCursorPosition((Console.WindowWidth -28 ) / 2, Console.CursorTop);
                Console.WriteLine("In welke Klas zit de student");
                for (int i = 0; i < 4; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - 2) / 2, Console.CursorTop);
                   
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine((i + 1 + ": " + Klassen.A3));
                            break;
                        case 1:
                            Console.WriteLine((i + 1 + ": " + Klassen.A4));
                            break;
                        case 2:
                            Console.WriteLine((i + 1 + ": " + Klassen.A5));
                            break;
                        case 3:
                            Console.WriteLine((i + 1 + ": " + Klassen.A6));
                            break;
                        default:
                            break;
                    }
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), 4);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            switch (selection)
            {
                case 1:
                    return Klassen.A3;
                case 2:
                    return Klassen.A4;
                case 3:
                    return Klassen.A5;
                case 4:
                    return Klassen.A6;
            }
            return Klassen.A5;
        }
        static List<Student> NietLegenStudenten(List<Student> studenten)
        {
            List<Student> temp = new List<Student>();
            for (int i = 0; i < studenten.Count; i++)
            {
                if (studenten[i].Leeftijd != -1)
                {
                    temp.Add(studenten[i]);
                }
            }
            return temp;
        }
        static int SelectMenuIngevulde(List<Student> studenten)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                if (studenten.Count == 0)
                {
                    return -1;
                }

                Console.SetCursorPosition((Console.WindowWidth - 21) / 2, Console.CursorTop);
                Console.WriteLine("Verwijder een student");

                for (int i = 0; i < studenten.Count; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    if (studenten[i].Leeftijd != -1)
                    {
                        string msg = "Student: " + studenten[i].Naam;
                        Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2, Console.CursorTop);
                        Console.WriteLine(msg);
                        Console.ResetColor();
                    }      
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), studenten.Count);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection - 1;
        }
    }
}
