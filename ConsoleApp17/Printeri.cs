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
        Print(zaniatie.Discyplina);
        Print(zaniatie.Sotrydnik);
        Print(zaniatie.Ayditoria);
        Print(zaniatie.Gryppa);
        Print(zaniatie.Para);
        Print(zaniatie.VidZanyatiya);
    }
    public static void Print(Ayditoria ayditoria) // 2
    {
        Console.WriteLine(ayditoria.Nazvanie);
        Print(ayditoria.Sotrydnik);
        Print(ayditoria.Oborudovanie);
        Console.WriteLine(ayditoria.Posadmesta);
        Console.WriteLine(ayditoria.Kolvookon);
    }
    public static void Print(Discyplina discyplina) // 3
    {
        Console.WriteLine(discyplina.Name);
        Console.WriteLine(discyplina.Shortname);
    }
    public static void Print(Gryppa gryppa) // 4
    {
        Console.WriteLine(gryppa.Name);
        Console.WriteLine(gryppa.Shortname);
        Console.WriteLine(gryppa.Chislo);
        Console.WriteLine(gryppa.Year);
        Print(gryppa.Specialnost);
        Print(gryppa.Sotrydnik);
    }
    public static void Print(Student student) // 5
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Familia);
        Console.WriteLine(student.Otchestvo);
        Print(student.Gryppa);
        Console.WriteLine(student.Data);
    }
    public static void Print(Specialnost specialnost) // 6
    {
        
    }
    public static void Print(Para para) // 7
    {
        
    }
    public static void Print(Smena smena) // 8
    {
        
    }
    public static void Print(Sotrydnik sotrydnik) // 9
    {
        Console.WriteLine(sotrydnik.Surname);
        Console.WriteLine(sotrydnik.Name);
        Console.WriteLine(sotrydnik.Otchestvo);
    }
    public static void Print(Doljnost doljnost) // 10
    {
    }
    public static void Print(Podrazdelenie podrazdelenie) // 11
    {
        Console.WriteLine(podrazdelenie.Nazvanie);
        Print(podrazdelenie.Sotrydnik);
        Print(podrazdelenie.Organizacia);
        
    }
    public static void Print(Organizacia organizacia) // 12
    {
    }
    public static void Print(Korpus korpus) // 13
    {
    }
    public static void Print(VidZanyatiya vidZanyatiya) // 14
    {
        Console.WriteLine(vidZanyatiya.Name);
    }
    public static void Print(Oborudovanie oborudovanie) // 15
    {
    }
    public static void Print(KTP kTP) // 16
    {
    }
    public static void Print(Tema tema) // 17
    {
    }
    public static void Print(Paragraf paragraf) // 18
    {
    }
    public static void Print(Tema_VidZanyatiya tema_VidZanyatiya) // 19
    {
    }
    public static void Print(Material material) // 20
    {
    }
    public static void Print(Kompetenciya kompetenciya) // 21
    {
    }
    public static void Print(ShapkaKTP shapkaKTP) // 22
    {
    }
    public static void Print(Vneurochka vneurochka) // 23
    {
    }


}

