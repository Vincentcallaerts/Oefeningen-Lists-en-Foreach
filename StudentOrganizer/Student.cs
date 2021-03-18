using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer
{
    enum Klassen { A3,A4,A5,A6}
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }
        public int PuntenComunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public Student()
        {
            Naam = "Default";
            Leeftijd = -1;
            Klas = Klassen.A3;
            PuntenComunicatie = 404;
            PuntenProgrammingPrinciples = 404;
            PuntenWebTech = 404;
        }

        public double BerekebTotaalCijfer()
        {
            return (PuntenComunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
        }
        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd}");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("---------------");
            Console.WriteLine($"Comunicatie: {PuntenComunicatie}");
            Console.WriteLine($"WebTech: {PuntenWebTech}");
            Console.WriteLine($"ProgrammingPrinciples: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Gemiddelde: {BerekebTotaalCijfer()}");
        }
        public void Clear()
        {
            Naam = "Default";
            Leeftijd = -1;
            Klas = Klassen.A3;
            PuntenComunicatie = 404;
            PuntenProgrammingPrinciples = 404;
            PuntenWebTech = 404;
        }
    }
}
