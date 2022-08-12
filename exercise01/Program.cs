// Дано число обозначающее день недели.Выяснить является номер дня недели выходным.
Console.WriteLine("введите число");
int dayNumber = new Random().Next(1,8);
string[] Days ={"понедельник,вторник,среда,четверг,пятница,суббота,воскресенье"};
string result = Console.ReadLine();
if (dayNumber < 5) 
 {
 Console.Write("Ура,это выходной день!!!");
}
else{
Console.Write("будни");
}