using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Printeri
{
    public static void Print(Zaniatie zaniatie) // 1
    {
        Console.WriteLine($"\nПолученные данные: ");
        Print(zaniatie.Ayditoria);
        Print(zaniatie.Discyplina);
        Print(zaniatie.VidZanyatiya);
    }
    public static void Print(Ayditoria ayditoria) // 2
    {
        Console.WriteLine(ayditoria.Nazvanie); 
        Console.WriteLine(ayditoria.Posadmesta);
        Console.WriteLine(ayditoria.Kolvookon);
    }
    public static void Print(Discyplina discyplina) // 3
    {
        Console.WriteLine(discyplina.Name);
        Console.WriteLine(discyplina.Shortname);
    }
    public static void Print(Gryppa gryppa)
    {
        Console.WriteLine(gryppa.Name);
        Console.WriteLine(gryppa.Shortname);
        Console.WriteLine(gryppa.Chislo);
        Console.WriteLine(gryppa.Year);
        Print(gryppa.Specialnost);
        Print(gryppa.Sotrydnik);

    }

    public static void Print(Sotrydnik sotrydnik) // 9
    {
        throw new NotImplementedException();
    }

    public static void Print(VidZanyatiya vidZanyatiya) // 14
    {
        Console.WriteLine(vidZanyatiya.Name);
    }
    public static void Print(Specialnost specialnost) // 6
    {
        throw new NotImplementedException();
    }
    public static void Print(Student student) // 5
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Familia);
        Console.WriteLine(student.Otchestvo);
        Print(student.Gryppa);
        Console.WriteLine(student.Data);
    }
}

