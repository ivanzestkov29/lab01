using System.Net.Mime;

string MyName = "Жестков Иван Витальевич";
int NumderKurs = 2;
double averageGrade = 3.9;

bool isstependiya = false;
string GroupName = "ИСП-252";
const int ya = 3;
int uchebnyhnedel = 16;
System.Console.WriteLine("Визитная Карточка Студента");
System.Console.WriteLine($"ФИО: {MyName}");
System.Console.WriteLine($"Группа: {GroupName}");
System.Console.WriteLine($"Курс: {NumderKurs}");
System.Console.WriteLine($"Специальность: Программист");
System.Console.WriteLine($"Средний балл за 3 работы {averageGrade}");
System.Console.WriteLine($"Стипендия положена (>= 4.0): {isstependiya}");
System.Console.WriteLine($"Учебных недель осталось в семестре {uchebnyhnedel}");
System.Console.WriteLine($"Количество учебных недель пройдено {uchebnyhnedel - 11}");
// Через интерполяцию передаем все значения 
// Предварительно записав их в соответсвующие переменные 
// Константа не нашла своего применения