using Tank_Factory.Service;
using Tank_Factory.Models;
using Tank_Factory.Tank_Details;
using System.Diagnostics;

CreatTankServiceArtillery creatTankArtillery = new CreatTankServiceArtillery();
CreatTankServiceMiddle creatTankServiceMiddle = new CreatTankServiceMiddle();
VehicleService vehicleService = new VehicleService();
Random random1 = new Random();
Factory factory = new Factory();

for (int i = 0; i < 10000; i++)
{
    vehicleService.CreatVehicle("Artillery Mount", Chassis.SixtyTone, Engine.SixHundredHP, Frame.Middle, Weapon.HeavyWeapon, "Artillery", random1.Next(0, 10000), factory);
}
Factory factoryNew = new Factory();
factoryNew.Artilleries = factory.Artilleries.Where(x => x.HungarNumber < 500 && x.DateTimeMade > new DateTime (2010, 1, 1)).ToList();
factoryNew.Artilleries = factoryNew.Artilleries.OrderBy(x => x.HungarNumber).ToList(); // Сортировка листа по номеру Ангара
factoryNew.Artilleries = factoryNew.Artilleries.OrderByDescending(x => x.HungarNumber).ToList(); // Сортировка листа по номеру Ангра с конца
List<DateTime?> dateList = factory.Artilleries.Where(x => x.HungarNumber > 500).Select(x=> x.DateTimeMade).ToList(); // Извлечение даты создания в отдельный лист с фильтром по Ангару
Dictionary<int, ArtilleryMount> dicdionaryArtillery = new Dictionary<int, ArtilleryMount>(); //обьявление Дикшинари, 
//dicdionaryArtillery = factory.Artilleries.ToDictionary(x => x.HungarNumber); //без проверок, если ключи уникальны.
for (int i = 0; i < factory.Artilleries.Count; i++) // проверка если ключи имеют одинаковые параметы(Dictionary крашится, если они одинаковые)
{
    if (dicdionaryArtillery.ContainsKey(factory.Artilleries[i].HungarNumber) == true) //условие проверки в цикле, строка "23"
    {
        continue;
    }
    else
    {
        dicdionaryArtillery.Add(factory.Artilleries[i].HungarNumber, factory.Artilleries[i]); //добавление после проверки в новый лист "ключа"
    }
}
List<ArtilleryMount> result = dicdionaryArtillery.Where(x => x.Key > 500).Select(x => x.Value).ToList(); // добавление обьекта из листа в новый лист с задаными параметрами (с проверкой когда номер "Ангара" > 500)
Random random = new Random();
List<int> listValue = new List<int>(); // заполнение листа рандомными числами
for (int i = 0; i < 100000000; i++)
    listValue.Add(random.Next(0, 10000));
List<int> listValue2 = new List<int>();
for (int i = 0; i < listValue.Count; i++) // сортировка елементов листа < 500
{
    if (listValue[i] < 500)
        listValue2.Add(listValue[i]);
}
HashSet<int> set = listValue.ToHashSet(); // Хешсет -> передаем параметр, по которому будем искать + метод вызова хешсета
Stopwatch stopwatch = Stopwatch.StartNew(); // Класс быстродействия программы
for (int i = 0; i < 10; i++)
{
    List<int> listValue3 = set.Where(x => x < 500).ToList(); //добавление с помощью Хешсет в лист элементов
}
stopwatch.Stop(); // метод завершения проверки быстродейсствия программы
Console.WriteLine(stopwatch.ElapsedMilliseconds); //вызов результата быстродействия программы

Console.ReadKey();


