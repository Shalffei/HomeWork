using HomeWork.Models;
using HomeWork.Service;

// 1) Дан список целых чисел (List<int>). Удалить из него все числа, делящиеся на первый элемент без остатка.
//List<int> value = new List<int>();
//Random random = new Random();
//for (int i = 0; i < 100; i++)
//{
//    value.Add(random.Next(1,11));
//}
//for (int i = 0;i < value.Count ;i++)
//    if (value[i] % value[0] == 0)
//        value.RemoveAt(value[i]);
//Console.ReadKey();
////2) Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки. 
////    Например, в строке ([]{ })[] скобки расставлены корректно, а в строке ([]] — нет. 
//string Sings = "}])[{(";

//3) Сделай несколько коллекций каждые елемент который содержит возраст, фамилию и имя студента . Найти студентов, имена которых присутствуют во всех коллекциях, отсортировать результат по возрасту. 
//Указание: в решении этой задачи удобно сформировать массив множеств HashSet с именами студентов, а затем вычислить их пересечение.
StudentService studentService = new StudentService();
University university = new University();
var newStudent = studentService.GetStudent("Max", "Williams", 19, university);
var newStudent2 = studentService.GetStudent("Adam", "Peters", 22, university);
var newStudent3 = studentService.GetStudent("Bob", "Gibson", 18, university);
var newStudent4 = studentService.GetStudent3("Max", "Jordan", 16, university);
var newStudent5 = studentService.GetStudent("Lili", "Anderson", 17, university);
var newStudent6 = studentService.GetStudent2("Max", "Smith", 25, university);
var newStudent7 = studentService.GetStudent2("Adam", "Davis", 24, university);
var newStudent8 = studentService.GetStudent3("Lili", "Smith", 30, university);
var newStudent9 = studentService.GetStudent2("Lili", "Jordan", 23, university);
var newStudent10 = studentService.GetStudent3("Adam", "Smith", 28, university);
var newStudent11 = studentService.GetStudent2("Glory", "Smith", 25, university);

List<Student> lilis = new List<Student>();
for (int i = 0; i < university.Students.Count; i++)
{
    lilis.Add(university.Students[i]);
}
for(int i = 0;i < university.Students2.Count; i++)
{
    lilis.Add(university.Students2[i]);
}
for (int i = 0; i < university.Students3.Count; i++)
{
    lilis.Add(university.Students3[i]);
}
HashSet<Student> set = lilis.ToHashSet();
List<Student> result = set.Where(x => x.Name == "Lili").OrderBy(x => x.Age).ToList();

Console.WriteLine("sdad");
Console.ReadKey();






