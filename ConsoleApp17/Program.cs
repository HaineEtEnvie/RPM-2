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
        case "Ayditoria":
            var ayditoria = CreateAyditoria();// 2 вариант - аудитория
            Console.WriteLine(ayditoria.Name21);
            Console.WriteLine(ayditoria.Name22);
            Console.WriteLine(ayditoria.Name23);
            break;
        case "Dyscyplina":
            var dyscyplina = CreateDiscyplina();// 3 вариант - дисциплина
            Console.WriteLine(dyscyplina.Name1);
            Console.WriteLine(dyscyplina.Shortname);
            break;
        case "Gryppa":
            // 4 вариант
            break;
        case "Student":
            // 5 вариант
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
            // 9 вариант
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

static Zaniatie CreateZaniatie()
{
    var name2 = CreateAyditoria(); // 2 вариант - аудитория
    var name3 = CreateDiscyplina(); // 3 вариант - дисциплина
    var name14 = CreateVidZanyatiya(); // 14 вариант - вид занятия
    var a = new Zaniatie(name2, name3, name14);
    return a;
}
static Ayditoria CreateAyditoria() // 2 вариант - аудитория
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
    throw new NotImplementedException();
}

static Student CreateStudent() // 5
{
    throw new NotImplementedException();
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
    throw new NotImplementedException();
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
