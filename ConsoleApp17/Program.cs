using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;

while (true)
{
    Console.WriteLine("Какой класс Вы хотите создать?");
    switch (Console.ReadLine())
    {

        case "Zaniatie": 
            var zaniatie = CreateZaniatie(); // 1 вариант - занятие
            Console.WriteLine($"\nПолученные данные:\n{zaniatie.Name2.Name21}"); // 2 вариант - аудитория
            Console.WriteLine(zaniatie.Name2.Name22);// 2 вариант - аудитория
            Console.WriteLine(zaniatie.Name2.Name23);// 2 вариант - аудитория
            Console.WriteLine(zaniatie.Name3.Name1);// 3 вариант - дисциплина
            Console.WriteLine(zaniatie.Name3.Shortname);// 3 вариант - дисциплина
            Console.WriteLine(zaniatie.Name14.Name141);// 14 вариант - вид занятия
            break;
        case "Dyscyplina":
            var dyscyplina = CreateDiscyplina();// 2 вариант - аудитория
            Console.WriteLine(dyscyplina.Name1);
            Console.WriteLine(dyscyplina.Shortname);
            break;
        case "VidZanyatiya":
            var vidzanyatiya = CreateVidZanyatiya();// 3 вариант - дисциплина
            Console.WriteLine(vidzanyatiya.Name141);
            break;
        case "Ayditoria":
            var ayditoria = CreateAyditoria();// 14 вариант - вид занятия
            Console.WriteLine(ayditoria.Name21);
            Console.WriteLine(ayditoria.Name22);
            Console.WriteLine(ayditoria.Name23);
            break;
        case "Specialnost":
            var specialnost = CreateSpecialnost();// 3 вариант - дисциплина
            Console.WriteLine(specialnost.Name61);
            Console.WriteLine(specialnost.Name62);
            break;
        default:
            Console.WriteLine("Такого класса не существует");
            break;

    }
}

static Zaniatie CreateZaniatie()
{
    var name2 = CreateAyditoria(); // 2 вариант - аудитория
    var name3 = CreateDiscyplina(); // 3 вариант - дисциплина
    var name14 = CreateVidZanyatiya(); // 14 вариант - вид занятия
    var a = new Zaniatie(name2, name3, name14);
    return a;

}
static Ayditoria CreateAyditoria()
{
    Console.Write("Введите название аудитории: ");
    var name21 = Console.ReadLine() ?? "Нет названия";
    // ссылка на сотрудника
    Console.Write("Введите кол-во посадочных мест: ");
    var name22 = Console.ReadLine() ?? "Нет названия";
    Console.Write("Введите кол-во окон: ");
    var name23 = Console.ReadLine() ?? "Нет названия";
    var a = new Ayditoria(name21, name22, name23);
    return a;
}

static Discyplina CreateDiscyplina()
{
    Console.Write("Введите полное навазние дисциплины: ");
    var name = (Console.ReadLine() ?? "Нет названия");
    Console.Write("Введите сокращение дисциплины: ");
    var shortname = (Console.ReadLine() ?? "Нет названия");
    var a = new Discyplina(name, shortname);
    return a;
}

static VidZanyatiya CreateVidZanyatiya()
{
    Console.Write("Введите вид занятия: ");
    var name141 = new VidZanyatiya(Console.ReadLine() ?? "Нет названия");
    return name141;

}

static Specialnost CreateSpecialnost()
{
    Console.WriteLine("Введите название специальности: ");
    var name = (Console.ReadLine() ?? "Нет названия");
    Console.WriteLine("Введите сокращение специальности: ");
    var reduction = (Console.ReadLine() ?? "Нет сокращения");
    var a = new Specialnost(name61, name62);
    return a;
}
