//Запрос данных от пользователя 
int ReadData(string line) 
{    
     Console.Write(line);     
     int num = int.Parse(Console.ReadLine() ?? "1");     
     return num; 
}  

//Вывод результата 
void PrintData(string prefix, string num) 
{     
    Console.WriteLine(prefix + num); 
} 

/*
//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

//Рекурентный вывод интервала от M до N
string NumMN(int m, int n){
    if (m>=n) return n.ToString();
    return m + NumMN(m+1, n);
}

int m = ReadData("Введите число M:"); 
int n = ReadData("Введите число N:");

//Вызываем функцию через тернарный оператор
string res = (m<n)?(NumMN(m,n)):(NumMN(n,m));
    
PrintData("Натуральные числа в промежутке от " +m+ " до " +n+ ": ",res);


//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

//Рекурентный вывод суммы чисел от M до N
int NumMN(int m, int n){
    if (m>=n) return n;
    return m + NumMN(m+1, n);
}

int m = ReadData("Введите число M:"); 
int n = ReadData("Введите число N:");

//Вызываем функцию через тернарный оператор
int res = (m<n)?(NumMN(m,n)):(NumMN(n,m));
    
PrintData("Натуральные числа в промежутке от " +m+ " до " +n+ ": ",res.ToString());


*/

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//Пользовательский ввод данных
int m = ReadData("Введите число M:"); 
int n = ReadData("Введите число N:");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int funAkkerman = Ack(m, n);

PrintData("Функция Аккермана:",funAkkerman.ToString());


