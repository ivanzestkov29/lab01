// string myName = "Иван Жестков";
// string groupName = "ИСП-252";
// int courseNumber =2;
// double averageGrade = 4.71;
// bool isBudget =true;

// Console.WriteLine("Знакомство");
// Console.WriteLine($"Студент:{myName}");
// Console.WriteLine($"Группа: {groupName}");
// Console.WriteLine($"Курс:{courseNumber}");
// Console.WriteLine($"Средний балл:{averageGrade}");
// Console.WriteLine($"Бюджетное место: {isBudget}");
// Program.cs:
// Console.WriteLine();
// Console.WriteLine("Ремонт комната");

// double roomWidth = 3.5;
// double roomLength = 4.2;

// double roomArea = roomWidth * roomLength;
// double roomPerimeter = 2 * (roomWidth + roomLength) * 2;
// Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
// Console.WriteLine($"Площадь: {roomArea} м²");
// Console.WriteLine($"Периметр: {roomPerimeter} м"); 

// Console.WriteLine();
// Console.WriteLine("Покупка ноутбука в рассрочку");

// int laptopPrice = 50000;
// int monthsCount = 12;
// double interestRate = 0.08;

// double totalWithInterest = laptopPrice * (1 + interestRate);
// double monthyPayment = totalWithInterest / monthsCount;

// Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
// Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
// Console.WriteLine($"Платеж в месяц: {monthyPayment} руб.");
// Console.WriteLine();
// Console.WriteLine("Внимания деления int");

// int totalStudents = 25;
// int groupsCount = 4;
// int studentsPerGroupWrong = totalStudents / groupsCount; 
// double studentsPerGroupCorrect = (double)totalStudents / groupsCount; // Верный результат с использованием приведения типов

// Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}"); // Выводит 6
// Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}"); // Выводит 6.25
// Console.WriteLine();
// Console.WriteLine("Способы собрать строку");

// string firstName = "Иван";
// string lastName = "Жестков";

// // Способ 1: Конкатенация через оператор +
// string fullNameConcat = firstName + " " + lastName;
// // Способ 2: Интерполяция строк $""
// string fullNameInterp = $"{firstName} {lastName}";
// // Способ 3: Метод String.Format
// string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

// Console.WriteLine($"FullNameConcat");
// Console.WriteLine($"FullNameInterp");
// Console.WriteLine($"FullNameConcatMethod");
// Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

// Console.WriteLine();
// Console.WriteLine("Константы");

// const double VatRate = 0.20;
// const string CollegeName = "ВФ ВолГУ";

// double productPrice = 1000;
// double priceWithVat = productPrice * (1 + VatRate);

// Console.WriteLine($"Учебное заведение: {CollegeName}");
// Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0})):{priceWithVat}");
// написание программы прошло успешно 
// программа работает исправно 
// мне понравился c# 

int scholarship = 1500;
int monthlyExpenses = 1000;
System.Console.WriteLine($"останется у студента к концу месяца: {scholarship - monthlyExpenses}");
const int MonthsInSemester = 4;
System.Console.WriteLine($"сколько это составит за весь семестр: {(scholarship - monthlyExpenses) * 4}");
