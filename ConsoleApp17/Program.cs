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
                    Printeri.Print(CreateZaniatie());
                    break;
                case "Ayditoria":
                    Printeri.Print(CreateAyditoria());
                    break;
                case "Discyplina":
                    Printeri.Print(CreateDiscyplina());
                    break;
                case "Gryppa":
                    Printeri.Print(CreateGryppa());
                    break;
                case "Student":
                    Printeri.Print(CreateStudent());
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
                    Printeri.Print(CreateSotrydnik());
                    break;
                case "Doljnost":
                    // 10 вариант
                    break;
                case "Podrazdelenie":
                    Printeri.Print(CreatePodrazdelenie());
                    break;
                case "Organizacia":
                    // 12 вариант
                    break;
                case "Korpus":
                    Printeri.Print(CreateKorpus());
                    break;
                case "VidZanyatiya":
                    Printeri.Print(CreateVidZanyatiya());
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

    /// <summary>
    /// 1 вариант - занятие
    /// </summary>
    static Zaniatie CreateZaniatie()
    {
        return new Zaniatie(
            CreateDiscyplina(),
            CreateSotrydnik(),
            CreateAyditoria(),
            CreateGryppa(),
            CreatePara(),
            CreateVidZanyatiya());
    }


    /// <summary>
    /// 2 вариант - аудитория
    /// </summary>
    static Ayditoria CreateAyditoria()
    {
        Console.Write("Введите номер аудитории: ");
        var nazvanie = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите кол-во посадочных мест: ");
        var posadmesta = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите кол-во окон: ");
        var kolvookon = Console.ReadLine() ?? "Нет названия";
        var a = new Ayditoria(nazvanie, CreateSotrydnik(), posadmesta, kolvookon, CreateOborudovanie());
        return a;
    }


    /// <summary>
    /// 3 вариант - дисциплина
    /// </summary>
    /// <returns></returns>
    static Discyplina CreateDiscyplina()
    {
        Console.Write("Введите полное навазние дисциплины: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите сокращение дисциплины: ");
        var shortname = (Console.ReadLine() ?? "Нет названия");
        var a = new Discyplina(name, shortname);
        return a;
    }


    /// <summary>
    /// 4 вариант - группа 
    /// </summary>
    /// <returns></returns>
    static Gryppa CreateGryppa() 
    {
        Console.Write("Введите название группы: ");
        var name = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите сокращение: ");
        var shortname = Console.ReadLine() ?? "Нет названия";
        Console.Write("Введите численность: ");
        var chislo = Convert.ToInt32(Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите год поступления:");
        var year = Convert.ToInt32(Console.ReadLine() ?? "Нет названия");
        var a = new Gryppa(name, shortname, chislo, year, CreateSpecialnost(), CreateSotrydnik());
        return a;
    }


    /// <summary>
    /// 5 вариант - студент
    /// </summary>
    /// <returns></returns>
    static Student CreateStudent() 
    {
        Console.Write("Введите имя студента: ");
        var name = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите фамилию студента: ");
        var familia = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите отчество студента: ");
        var otchestvo = (Console.ReadLine() ?? "Нет названия");
        Console.Write("Введите дату рождения студента: ");
        var data = Convert.ToDateTime(Console.ReadLine() ?? DateTime.Today.ToString());
        var a = new Student(name, familia, otchestvo, CreateGryppa(), data);
        return a;
    }


    /// <summary>
    /// 6 вариант - специальность
    /// </summary>
    /// <returns></returns>
    static Specialnost CreateSpecialnost()
    {
        return new Specialnost();
    }

    /// <summary>
    ///  7 вариант - пара
    /// </summary>
    /// <returns></returns>
    static Para CreatePara() 
    {
        return new Para();
    }


    /// <summary>
    /// 8 вариант - смена
    /// </summary>
    /// <returns></returns>
    static Smena CreateSmena()
    {
        return new Smena();
    }


    /// <summary>
    /// 9 вариант - сотрудник
    /// </summary>
    /// <returns></returns>
    static Sotrydnik CreateSotrydnik()
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


    /// <summary>
    /// 10 вариант - должность
    /// </summary>
    /// <returns></returns>
    static Doljnost CreateDoljnost() 
    {
        return new Doljnost();
    }


    /// <summary>
    ///  11 вариант - подразделение
    /// </summary>
    /// <returns></returns>
    static Podrazdelenie CreatePodrazdelenie() 
    {
        Console.Write("Введите название: ");
        var nazvanie = Console.ReadLine() ?? "Нет названия";
        var a = new Podrazdelenie(nazvanie, CreateSotrydnik(), CreateOrganizacia());
        return a;
    }


    /// <summary>
    /// 12 вариант - организация
    /// </summary>
    /// <returns></returns>
    static Organizacia CreateOrganizacia() 
    {
        return new Organizacia();
    }


    /// <summary>
    /// 13 вариант - корпус
    /// </summary>
    /// <returns></returns>
    static Korpus CreateKorpus() // 13
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "Не заполнено";
        Console.WriteLine("Введите адресс: ");
        string adress = Console.ReadLine() ?? "Не заполнено";
        Console.WriteLine("Введите дату: ")
        var a = new Korpus(name, adress, CreateSotrydnik(), CreateOrganizacia());
        return a;
    }


    /// <summary>
    /// 14 вариант - вид занятия
    /// </summary>
    /// <returns></returns>
    static VidZanyatiya CreateVidZanyatiya() 
    {
        Console.Write("Введите вид занятия: ");
        var name = new VidZanyatiya(Console.ReadLine() ?? "Нет названия");
        return name;

    }


    /// <summary>
    /// 15 вариант - оборудование
    /// </summary>
    /// <returns></returns>
    static Oborudovanie CreateOborudovanie()
    {
        return new Oborudovanie();
    }


    /// <summary>
    /// 16 вариант - КТП
    /// </summary>
    /// <returns></returns>
    static KTP CreateKTP()
    {
        return new KTP();
    }


    /// <summary>
    /// 17 вариант - тема
    /// </summary>
    /// <returns></returns>
    static Tema CreateTema() 
    {
        return new Tema();
    }


    /// <summary>
    /// 18 вариант - параграф
    /// </summary>
    /// <returns></returns>
    static Paragraf CreateParagraf() 
    {
        return new Paragraf();
    }


    /// <summary>
    /// 19 вариант - Тема-ВидЗанятия
    /// </summary>
    /// <returns></returns>
    static Tema_VidZanyatiya CreateTema_VidZanyatiya()
    {
        return new Tema_VidZanyatiya();
    }


    /// <summary>
    /// 20 вариант - материал
    /// </summary>
    /// <returns></returns>
    static Material CreateMaterial() 
    {
        return new Material();
    }


    /// <summary>
    /// 21 вариант - компетенция
    /// </summary>
    /// <returns></returns>
    static Kompetenciya CreateKompetenciya() 
    {
        return new Kompetenciya();
    }


    /// <summary>
    /// 22 вариант - шапка КТП
    /// </summary>
    /// <returns></returns>
    static ShapkaKTP CreateShapkaKTP()
    {
        return new ShapkaKTP();
    }


    /// <summary>
    /// 23 вариант - внеурочка
    /// </summary>
    /// <returns></returns>
    static Vneurochka CreateVneurochka() 
    {
        return new Vneurochka();
    }
}
