// задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length - 1; i >= 0; i--) {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// задание 1.2
// double[] temps = { -4.5, -2.0, 0.5, 3.2, -1.8, 2.0, -5.1 };
// foreach (double t in temps) {
//     Console.Write(t + " ");
// }
// Console.WriteLine();
// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int expensiveCount = 0;
// foreach (int price in prices) {
//     sum += price;
//     if (price > 100) {
//         expensiveCount++;
//     }
// }
// double average = (double)sum / prices.Length;
// Console.WriteLine($"сумма цен: {sum}");
// Console.WriteLine($"средняя цена: {average}");
// Console.WriteLine($"товаров дороже 100: {expensiveCount}");
// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int minPrice = prices[0];
// int maxIndex = 0;
// for (int i = 1; i < prices.Length; i++) {
//     if (prices[i] < minPrice) {
//         minPrice = prices[i];
//     }
//     if (prices[i] > prices[maxIndex]) {
//         maxIndex = i;
//     }
// }
// Console.WriteLine($"минимальная цена: {minPrice}");
// Console.WriteLine($"индекс самого дорогого товара: {maxIndex}");
// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++) {
//     if (balance[i] < 0) {
//         balance[i] = 0;
//     }
// }
// foreach (int b in balance) {
//     Console.Write(b + " ");
// }
// Console.WriteLine();
// самостоятельные задания
// Задание 5
// i
// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

// Console.Write("введите имя для поиска: ");
// string target = Console.ReadLine();
// bool found = false;

// for (int i = 0; i < names.Length; i++) {
//     if (names[i] == target) {
//         Console.WriteLine($"имя найдено на позиции: {i}");
//         found = true;
//         break;
//     }
// }

// if (!found) {
//     Console.WriteLine("не найдено");
// }
// итоговая задача
int[] grades = { 5, 4, 5, 3, 5, 4, 5, 4 };

Console.Write("оценки: ");
foreach (int g in grades) {
    Console.Write(g + " ");
}
Console.WriteLine();

int sum = 0;
int maxGrade = grades[0];
int minGrade = grades[0];
int count2 = 0;
int count5 = 0;

foreach (int g in grades) {
    sum += g;
    if (g > maxGrade) maxGrade = g;
    if (g < minGrade) minGrade = g;
    if (g == 2) count2++;
    if (g == 5) count5++;
}

double avg = (double)sum / grades.Length;
Console.WriteLine($"средняя оценка: {avg:F2}");
Console.WriteLine($"наибольшая: {maxGrade}, наименьшая: {minGrade}");
Console.WriteLine($"двоек: {count2}, пятёрок: {count5}");

if (avg >= 4.5) {
    Console.WriteLine("отличник");
} else if (avg >= 3.5) {
    Console.WriteLine("хорошист");
} else {
    Console.WriteLine("есть над чем поработать");
}
// Дополнительное задание
// int[] arr = { 1, 2, 3, 4, 5, 6 };

// for (int i = 0; i < arr.Length / 2; i++) {
//     int temp = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = temp;
// }
// foreach (int item in arr) {
//     Console.Write(item + " ");
// }
// Console.WriteLine();

