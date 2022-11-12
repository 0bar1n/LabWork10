using System;

namespace labwork10
{
    class Program
    {
            static int fact(int n)
            {
                return n > 1 ? n * fact(--n) : 1; //вычисление факториала
            }
            static void Main(string[] args)
            {
                Console.Write("X: "); 
                double X = double.Parse(Console.ReadLine()); //вводим значение переменной ряда
                Console.Write("N: ");
                int N = int.Parse(Console.ReadLine());//вводим верхнее число ряда
                Console.Write("K: ");
                int K = int.Parse(Console.ReadLine()); //вводим нижнее число ряда
                double sum = 0; //задаем целочисленную переменную
                for (; K - 1 < N; K++) //складываем члены ряда до n
                {
                    sum += Math.Pow(X,K)/fact(K); //вычисляем член ряда
                }
                Console.WriteLine($"Сумма {N} членов ряда равна : " + sum) ; //вывод результата
        }
    }
}
