/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*void ShowRow (int num)
{
    Console.Write(num + " ");
    if (num > 1 ) ShowRow(num-1);
    
}
Console.Write("Enter a number -> ");
int n = Convert.ToInt32(Console.ReadLine());
ShowRow(n);  
*/
/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*int SumElements (int n, int m)
{
    if (n<=m) return SumElements(n+1, m)+n; 
    else return 0; 
}
Console.Write("Enter the initial value -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the final value -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(SumElements(n,m)); 
*/
/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/
int Ackerman ( int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m - 1, Ackerman(m, n - 1));
}
Console.Write("Enter the first value -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second value -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Ackerman (m,n)); 
