/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.Write("Введите пятизначное число, а мы проверим, является ли оно палиндромом: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - проверяем... палиндром.");
    
  }
  else Console.WriteLine($"Ваше число: {number} - проверяем ... НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите всё-таки пятизначное число");
