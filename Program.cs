void Zadacha25 ()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    Random rand = new Random();
    int NumA = rand.Next (1, 7);
    int NumB = rand.Next (1, 7);
    Console.WriteLine ("Число А = " + NumA);
    Console.WriteLine ("Число B = " + NumB);
    Console.WriteLine ("А^B = " + Math.Pow (NumA, NumB));
    
}

void Zadacha25v2 ()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    Random rand = new Random();
    int NumA = rand.Next (1, 7);
    int NumB = rand.Next (1, 7);
    int proiz=1;
    Console.WriteLine ("Число А = " + NumA);
    Console.WriteLine ("Число B = " + NumB);
    for (int i=0; i < NumB; i++)
    {
        proiz *= NumA;
    }
    Console.WriteLine ("А^B = " + proiz);
    
}

void Zadacha27 ()
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    int sum = 0;
    Console.Write ("Введите число :");
    int num = Convert.ToInt32 (Console.ReadLine ());
    while (num > 0)
    {
        sum += num%10;
        num /=10;
    }
    Console.WriteLine ("Сумма чисел в цифре равна: " + sum);
}

void Zadacha29 ()
{
    // Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
    Console.Write ("Введите длину массива :");
    int num = Convert.ToInt32 (Console.ReadLine ());
    int [] arrayN = new int [num];
    AddArray (arrayN);
    Console.WriteLine ("Массив до сортировки :");
    PrintArray (arrayN);
    int h = 0;
    for (int i = 0; i<arrayN.Length; i++)
    {
        int min = i;
        for (int j = i; j<arrayN.Length; j++)
        {
            if (Math.Abs (arrayN[min]) > Math.Abs (arrayN[j]))
            {
                h = arrayN[min];
                arrayN [min] = arrayN[j];
                arrayN[j] = h;                
            }
            
        }
    }
    Console.WriteLine ("Массив после сортировки :");
    PrintArray (arrayN);
}

void Zadacha29v2 ()
{
    // Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
    Console.Write ("Введите длину массива :");
    int num = Convert.ToInt32 (Console.ReadLine ());
    int [] arrayN = new int [num];
    int [] arrayS = new int [num];
    AddArray (arrayN);
    CopyArray (arrayS, arrayN);
    int h = 0;
    for (int i = 0; i<arrayS.Length; i++)
    {
        int min = i;
        for (int j = i; j<arrayS.Length; j++)
        {
            if (Math.Abs (arrayS[min]) > Math.Abs (arrayS[j]))
            {
                h = arrayS[min];
                arrayS [min] = arrayS[j];
                arrayS[j] = h;                
            }
            
        }
    
    }
    Console.WriteLine ("Массив до сортировки :");
    PrintArray (arrayN);
    Console.WriteLine ("Массив после сортировки :");
    PrintArray (arrayS);
}

void AddArray (int [] array)
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array [i] = rand.Next (-10, 11);
    }
}

void PrintArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array [i] + " ");
    }
    Console.WriteLine ();
}

void CopyArray (int [] array, int [] array2)
{
    for (int i=0; i<array.Length; i++)
    {
        array [i] = array2 [i];
    }
    Console.WriteLine ();
}
//Zadacha25 ();
// Zadacha27 ();
//Zadacha29 ();
//Zadacha29v2 ();
//Zadacha25v2 ();