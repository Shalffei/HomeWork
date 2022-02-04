using Maternity_Hospital.Service;
using Maternity_Hospital.Models;
using Maternity_Hospital.EnumBirth;


MotherService motherService = new MotherService();
KidService kidService = new KidService();

Mother[] array = new Mother[1]; 
var mother = motherService.GetMother("Rita", Nationality.American);
var child = kidService.GetChild(81, 3800, Eye.hazel, Sex.male, mother);
Console.WriteLine($"{mother.ChildList[0].Growth}" + $"\n{mother.ChildList[0].Weight}" + $"\n{mother.ChildList[0].Eye}" + $"\n{mother.ChildList[0].Nationality}" + $"\n{mother.ChildList[0].Sex}");
array[0] = mother;
child = kidService.GetChild(89, 4100, Eye.blue, Sex.femail, mother);
//Random rnd = new Random();
//int a = rnd.Next(0, 3);
//child.Eye = (Eye)a;
//var b = (int)child.Eye;
//Console.WriteLine(b);


