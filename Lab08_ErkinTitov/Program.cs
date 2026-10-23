// int totalLessons = 5;
// int lessonNumber = totalLessons;

// while (lessonNumber >= 1)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");


// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int count = 0;
// int grade = int.Parse(Console.ReadLine()!);

// while (grade != -1)
// {
//     count++;
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Всего введено оценок: {count}");


// int sum = 0;
// int count = 0;
// int maxGrade = int.MinValue;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine()!);

// while (grade != -1)
// {
//     sum += grade;
//     count++;

//     if (grade > maxGrade)
//     {
//         maxGrade = grade;
//     }

//     grade = int.Parse(Console.ReadLine()!);
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {maxGrade}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }


// string correctPassword = "qwerty123";
// int failedAttempts = 0;

// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string? password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }

//     failedAttempts++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }

// Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");


// int n = 7; // Заданное число
// int i = 1;

// Console.WriteLine($"Таблица умножения на {n}:");
// while (i <= 10)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
//     i++;
// }


// int count = 0;
// Console.WriteLine("Вводите имена учеников (для завершения введите 'конец'):");
// string? name = Console.ReadLine();

// while (name != "конец")
// {
//     count++;
//     name = Console.ReadLine();
// }

// Console.WriteLine($"Количество введённых имён: {count}");


// int totalPages = 0;
// Console.WriteLine("Вводите количество прочитанных страниц за день (для завершения введите -1):");
// int pages = int.Parse(Console.ReadLine()!);

// while (pages != -1)
// {
//     totalPages += pages;
//     pages = int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine($"Всего прочитано страниц: {totalPages}");

// while (true)
// {
//     Console.Write("Введите целое число: ");
//     int num = int.Parse(Console.ReadLine()!);

//     if (num % 7 == 0)
//     {
//         Console.WriteLine("Найдено!");
//         break;
//     }
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// // 3
// int n = 10;
// int i = 1;

// while (i <= n)
// {
//     Console.WriteLine($"{i} -> {i * i}");
//     i++;
// }

// // 6

// Console.Write("Введите целое положительное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int count = 0;

// if (number == 0)
// {
//     count = 1;
// }
// else
// {
//     while (number != 0)
//     {
//         number /= 10;
//         count++;
//     }
// }

// Console.WriteLine($"Количество цифр: {count}");

// 1
int n = 10; 
while (n >= 1)
{
    Console.WriteLine(n);
    n--;
}
Console.WriteLine("Старт!");

// 8 
string correctPassword = "admin";
int attempts = 0;
string? password = "";

while (attempts < 3 && password != correctPassword)
{
    Console.Write($"Попытка {attempts + 1} из 3. Введите пароль: ");
    password = Console.ReadLine();
    attempts++;
}

if (password == correctPassword)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ заблокирован");
}