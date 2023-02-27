using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Какой класс Вы хотите создать?");
            switch (Console.ReadLine())
            {

                case "Zaniatie":
                    Print(CreateZaniatie()); // 1 вариант - занятие
                    break;
                case "Ayditoria":
                    var ayditoria = CreateAyditoria();// 2 вариант - аудитория
                    Console.WriteLine(ayditoria.Nazvanie);
                    Console.WriteLine(ayditoria.Posadmesta);
                    Console.WriteLine(ayditoria.Kolvookon);
                    break;
                case "Discyplina":
                    var discyplina = CreateDiscyplina();// 3 вариант - дисциплина
                    Console.WriteLine(discyplina.Name1);
                    Console.WriteLine(discyplina.Shortname);
                    break;
                case "Gryppa":
                    var gryppa = CreateGryppa(); // 4 вариант - группа
                    Console.WriteLine(gryppa.Name);
                    Console.WriteLine(gryppa.Shortname);
                    Console.WriteLine(gryppa.Chislo);
                    Console.WriteLine(gryppa.Year);
                    //Console.WriteLine(gryppa.Specialnost);
                    //Console.WriteLine(gryppa.Sotrydnik);
                    break;
                case "Student":
                    var student = CreateStudent(); // 5 вариант - студент
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Familia);
                    Console.WriteLine(student.Otchestvo);
                    Console.WriteLine(student.Gryppa.Name);
                    Console.WriteLine(student.Gryppa.Shortname);
                    Console.WriteLine(student.Gryppa.Chislo);
                    Console.WriteLine(student.Gryppa.Year);
                    Console.WriteLine(student.Data);
                    break;
                case "Specialnost":
                    // 6 вариант
                    break;
                case "Para":
                    // 7 вариант
                    break;
                case "Smena":
                    // 8 вариант
                    break;
                case "Sotrydnik":
                    var sotrydnik = CreateSotrydnik(); // 9 вариант сотрудник
                    Console.WriteLine("ФИО: {0}, {1}, {2}", sotrydnik.Surname, sotrydnik.Name, sotrydnik.Otchestvo);
                    break;
                case "Doljnost":
                    // 10 вариант
                    break;
                case "Podrazdelenie":
                    // 11 вариант
                    break;
                case "Organizacia":
                    // 12 вариант
                    break;
                case "Korpus":
                    // 13 вариант
                    break;
                case "VidZanyatiya":
                    var vidzanyatiya = CreateVidZanyatiya();// 14 вариант - дисциплина
                    Console.WriteLine(vidzanyatiya.Name141);
                    break;
                case "Oborudovanie":
                    // 15 вариант
                    break;
                case "KTP":
                    // 16 вариант
                    break;
                case "Tema":
                    // 17 вариант
                    break;
                case "Paragraf":
                    // 18 вариант
                    break;
                case "Tema-VidZanyatiya":
                    // 19 вариант
                    break;
                case "Material":
                    // 20 вариант
                    break;
                case "Kompetenciya":
                    // 21 вариант
                    break;
                case "ShapkaKTP":
                    // 22 вариант
                    break;
                case "Vneurochka":
                    // 23 вариант
                    break;
                default:
                    Console.WriteLine("Такого класса не существует");
                    break;

            }
        }

    }

    static void Print(Zaniatie zaniatie)
    {
        Console.WriteLine($"\nПолученные данные:\n{zaniatie.Ayditoria.Nazvanie}"); // 2 вариант - аудитория
        Print(zaniatie.Ayditoria);
        Print(zaniatie.Discyplina);
        Print(zaniatie.VidZanyatiya);
    }

    static void Print(VidZanyatiya vidZanyatiya)
    {
        throw new NotImplementedException();
    }

    static void Print(Discyplina discyplina)
    {
        throw new NotImplementedException();
    }

    static void Print(Ayditoria ayditoria)
    {
        Console.WriteLine(ayditoria.Posadmesta);// 2 вариант - аудитория
        Console.WriteLine(ayditoria.Kolvookon);// 2 вариант - аудитория
    }

    static Zaniatie CreateZaniatie()
    {
        return new Zaniatie(
            CreateAyditoria(),
            CreateDiscyplina(),
            CreateVidZanyatiya());
    }

    /// <summary>
    /// 2 вариант - аудитория
    /// </summary>
    static Ayditoria CreateAyditoria()
    {
        Console.Write("Введите название аудитории: ");
        var nazvanie = Console.ReadLine() ?? "Нет названия";
        // ссылка на сотрудника
        Console.Write("Введите кол-во посадочных мест: ");
        var posadmesta = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите кол-во окон: ");
        var kolvookon = Console.ReadLine() ?? "Нет названия";
        var a = new Ayditoria(nazvanie, posadmesta, kolvookon);
        return a;
    }


    /// <summary>
    /// 3 вариант - дисциплина
    /// </summary>
    /// <returns></returns>
    static Discyplina CreateDiscyplina() // 3 вариант - дисциплина
    {
        Console.Write("Введите полное навазние дисциплины: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите сокращение дисциплины: ");
        var shortname = (Console.ReadLine() ?? "Нет названия");
        var a = new Discyplina(name, shortname);
        return a;
    }
    static Gryppa CreateGryppa() // 4
    {
        Console.Write("Введите название группы: ");
        var name = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите сокращение: ");
        var shortname = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите численность: ");
        var chislo = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите год поступления:");
        var year = Console.ReadLine() ?? "Нет названия";
        // ссылка на специальность//
        //ссылка на сотрудника//
        var a = new Gryppa(name, shortname, chislo, year);
        return a;
    }

    static Student CreateStudent() // 5
    {
        Console.Write("Введите имя студента: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите фамилию студента: ");
        var familia = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите отчество студента: ");
        var otchestvo = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите дату рождения студента: ");
        var data = Convert.ToDateTime(Console.ReadLine() ?? "Нет названия");
        var a = new Student(name, familia, otchestvo, CreateGryppa(), data);
        return a;
    }

    static Specialnost CreateSpecialnost() // 6
    {
        throw new NotImplementedException();
    }

    static Para CreatePara() // 7
    {
        throw new NotImplementedException();
    }

    static Smena CreateSmena() // 8
    {
        throw new NotImplementedException();
    }

    static Sotrydnik CreateSotrydnik() // 9
    {
        Console.Write("Введите фамилию: ");
        var surname = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите имя: ");
        var name = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите отчество: ");
        var otchestvo = Console.ReadLine() ?? "Нет названия";
        var a = new Sotrydnik(surname, name, otchestvo);
        return a;
    }

    static Doljnost CreateDoljnost() // 10
    {
        throw new NotImplementedException();
    }

    static Podrazdelenie CreatePodrazdelenie() // 11
    {
        throw new NotImplementedException();
    }

    static Organizacia CreateOrganizacia() // 12
    {
        throw new NotImplementedException();
    }

    static Korpus CreateKorpus() // 13
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 14 вариант - вид занятия
    /// </summary>
    /// <returns></returns>
    static VidZanyatiya CreateVidZanyatiya() // 14 вариант - вид занятия
    {
        Console.Write("Введите вид занятия: ");
        var name141 = new VidZanyatiya(Console.ReadLine() ?? "Нет названия");
        return name141;

    }

    static Gryppa CreateVidZanyatiyaGryppa() // 15
    {
        throw new NotImplementedException();
    }

    static KTP CreateKTP() // 16
    {
        throw new NotImplementedException();
    }

    static Tema CreateTema() // 17
    {
        throw new NotImplementedException();
    }

    static Paragraf CreateParagraf() // 18
    {
        throw new NotImplementedException();
    }

    static Tema_VidZanyatiya CreateTema_VidZanyatiya() // 19
    {
        throw new NotImplementedException();
    }

    static Material CreateMaterial() // 20
    {
        throw new NotImplementedException();
    }

    static Kompetenciya CreateKompetenciya() // 21
    {
        throw new NotImplementedException();
    }

    static ShapkaKTP CreateShapkaKTP() // 22
    {
        throw new NotImplementedException();
    }

    static Vneurochka CreateVneurochka() // 23
    {
        throw new NotImplementedException();
    }
}
