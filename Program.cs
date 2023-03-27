// HomeworkCS4

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// идея была неплохой, но я так и не разобралась до конца, в чем у меня ошибка в таком решении задачи

// double Exponent(int numberA, int numberB){
//     int result = 1;
//     for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//     }
// }    
// int result = Math.Pow(numberA, numberB);
//       return result;
      
//     }

//   int exponent = Exponent(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponent);

// вариант второй

double result = Math.Pow(numberA, numberB);

if(numberB < 0)
{
    Console.WriteLine("Число 'B' не должно быть меньше нуля!");
}
else
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
}