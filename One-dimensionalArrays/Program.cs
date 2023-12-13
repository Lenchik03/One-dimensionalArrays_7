//задача 1
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int k);

//double s = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 60);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] % k == 0)
//        s += array[i];
//}
//Console.WriteLine(s);

//задача 3
//int.TryParse(Console.ReadLine(), out int n);

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//if (array[0] < 0)
//    Console.WriteLine("Первое -");
//else
//    Console.WriteLine("Первое +");

//задача 4
//int.TryParse(Console.ReadLine(), out int n);

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (i > 0)
//    {
//        int pred = array[i - 1];
//        if (pred > array[i])
//        {
//            Console.WriteLine("Последовательность не возрастает");
//            break;
//        }
//    }



//}

//Console.WriteLine("Возрастает");

//задача 5
//int.TryParse(Console.ReadLine(), out int n);

//int s = 0;
//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] % 2 == 0)
//        s++;
//}
//Console.WriteLine("_____");
//int j = 0;
//int[] array2 = new int[s];
//for (int i = 0;i < array.Length;i++)
//{
//    if (array[i] % 2 == 0) 
//    {
//        array2[j] = array[i];
//    Console.WriteLine($"{j} = {array2[j]}");
//        j++;
//    }
//}

//задача 6
//int.TryParse(Console.ReadLine(), out int n);
//int min = int.MaxValue;
//int max = int.MinValue;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] < min) min = array[i];
//    if (array[i] > max) max = array[i];

//}
//int a = max - min + 1;
//Console.WriteLine(a);

//задача 7
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int Z);
//int s = 0;
//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] > Z)
//    {
//        array[i] = Z;
//        s++;
//    }

//}
//Console.WriteLine(s);

//задача 8
//int.TryParse(Console.ReadLine(), out int n);
//int s = 0;
//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = Console.Read();
//    s++;
//    if (array[i] == 0)
//        break;
//}
//Console.WriteLine(s);

// задача 9
//int.TryParse(Console.ReadLine(), out int n);
//int smin = 0;
//int splys = 0;
//int snyl = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] < 0)
//        smin++;
//    if (array[i] > 0)
//        splys++;
//    if (array[i] == 0)
//        snyl++;

//}
//Console.WriteLine(smin);
//Console.WriteLine(splys);
//Console.WriteLine(snyl);

//задача 10
//int.TryParse(Console.ReadLine(), out int n);
//int min = int.MaxValue;
//int max = int.MinValue;
//int inmin = 0;
//int inmax = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] < min)
//    {
//        min = array[i];
//        inmin = i;
//    }
//    if (array[i] > max)
//    {
//        max = array[i];
//        inmax = i;
//    }

//}
//array[inmin] = max;
//array[inmax] = min;
//Console.WriteLine("________");
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine($"{i} = {array[i]}");

//}

//задача 11
//int.TryParse(Console.ReadLine(), out int n);
//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//Console.WriteLine("________");

//for (int i = 0;i < array.Length; i++)
//    if (array[i] >= i)
//        Console.WriteLine($"{i} = {array[i]}");

//задача 12
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int M);
//int.TryParse(Console.ReadLine(), out int L);
//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//Console.WriteLine("________");

//for (int i = 0; i < array.Length; i++)
//{
//L = array[i] % M
//    if(L >= 0 && L <= M-1)
//    {
//            Console.WriteLine($"{i} = {array[i]}");
//    }
//}

//задача 13
//int.TryParse(Console.ReadLine(), out int n);

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//Console.WriteLine("________");

//for (int i = 0; i < array.Length; i += 2)
//{
//    int a = array[i];
//    array[i] = array[i + 1];
//    array[i + 1] = a;
//    Console.WriteLine($"{i} = {array[i]}");
//}

//задача 14
//int.TryParse(Console.ReadLine(), out int n);
//int count = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(2, 5);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] == 2)
//        count++;
//}
//Console.WriteLine("Не допущено: " + count);

//задача 15
//int.TryParse(Console.ReadLine(), out int n);

//int[] array = new int[n];

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = int.Parse(Console.ReadLine());
//    if (array[i] == 0)
//    {
//        break;
//    }
//    Console.WriteLine($"{i} = {array[i]}");
//}

//задача 16
//int.TryParse(Console.ReadLine(), out int n);
//int count = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//for (int i = 0; i < n / 2; i++)
//{

//    Console.WriteLine(array[i] + " " + array[i + n/2]);
//}
//Console.WriteLine();

//задача 17
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int A);
//int.TryParse(Console.ReadLine(), out int b);
//int count = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] < A - b || array[i] > A + b)
//    {
//        count++;

//    }
//}
//if(count == 0)
//    Console.WriteLine("Бракованных деталей нет!!!");

//Console.WriteLine(count);

//задача 18
//int.TryParse(Console.ReadLine(), out int n);
//int count = 0;
//int max = int.MinValue;


//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//for (int i = 0; i < n; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i];

//    }
//}
//Console.WriteLine(max);

//задача 19
//int.TryParse(Console.ReadLine(), out int n);

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 10);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//Console.WriteLine("_______");
//for (int j = 1; j < n; j*=2)
//{
//    Console.WriteLine($"{j} = {array[j]}");
//}

//задача 20
//int.TryParse(Console.ReadLine(), out int n);
//int.TryParse(Console.ReadLine(), out int k);
//int countm = 0;
//int countb = 0;
//int countr = 0;

//int[] array = new int[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-10, 10);
//    Console.WriteLine($"{i} = {array[i]}");
//    if (array[i] < k)
//        countm++;
//    if (array[i] > k)
//        countb++;
//    if (array[i] == k)
//        countr++;
//}
//Console.WriteLine("Меньше: " + countm);
//Console.WriteLine("Больше: " + countb);
//Console.WriteLine("Равно: " + countr);

//задача 21
//double.TryParse(Console.ReadLine(), out double n);

//double summa = 0;
//double[] array = new double[(int)n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-10, 10);
//    summa += array[i];
//    Console.WriteLine($"{i} = {array[i]}");

//}
//Console.WriteLine("_______");
//for (int i = 0;i < array.Length;i++)
//{
//    double S = Math.Sqrt(Math.Pow(array[i] - summa/n, 2) / (n-1));
//    Console.WriteLine($"{i} = {S}");
//}

//задача 22
//int.TryParse(Console.ReadLine(), out int n);
//int count = 0;
//char[] array = new char[n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = char.Parse(Console.ReadLine());
//    Console.WriteLine($"{i} = {array[i]}");

//}
//Console.WriteLine("_______");
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == '1' && array[i + 1] == '2' && array[i + 2] == '3')
//    {
//        count++;
//        Console.WriteLine("С:" + i);
//    }
//}
//Console.WriteLine(count);

//задача 23
//int.TryParse(Console.ReadLine(), out int n);
//int count = 0;


//int[] array = new int[n];
//Random random = new Random();
//bool flaq = false;
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-20, 20);
//    Console.WriteLine($"{i} = {array[i]}");
//}
//for (int i = 0; i < n; i++)
//{
//    if (array[i] > 0 && flaq == false)
//    {
//        flaq = true;
//        count++;
//        Console.WriteLine("С:" + i);
//    }
//    if (array[i] < 0 && flaq == true)
//    {
//        flaq = false;
//        count++;
//        Console.WriteLine("С:" + i);
//    }
//}
//Console.WriteLine(count);

//задача 24
//double.TryParse(Console.ReadLine(), out double n);

//double summa = 0;
//double[] array = new double[(int)n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 10);
//    Console.WriteLine($"{i} = {array[i]}");
//    bool isProstoe = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//            isProstoe = false;

//    }
//    if (isProstoe)
//        summa += array[i];
//}
//Console.WriteLine("_______");

//Console.WriteLine(summa);

//задача 25
//double.TryParse(Console.ReadLine(), out double n);
//int a=0; 
//int b=1;
//double summa = 0;
//double[] array = new double[(int)n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(0, 10);
//    Console.WriteLine($"{i} = {array[i]}");
//    bool isFibonachi = false;
//    if (array[i] == 0)
//        isFibonachi=true;
//    for (int c = a + b; c <= array[i]; c = a + b)
//    {
//        if (c == array[i])
//        {
//            isFibonachi = true;
//            break;
//        }
//        else
//        {
//            a = b;
//            b = c;
//        }
//    }
//    if (isFibonachi)
//        summa += array[i];
//    a = 0; 
//    b = 1;
//}
//Console.WriteLine("_______");

//Console.WriteLine(summa);


//задача 26
//int.TryParse(Console.ReadLine(), out int n);

//double summa = 1;
//double[] array = new double[(int)n];
//Random random = new Random();
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-10, 10);
//    if (array[i] == 0)
//        array[i] = 1;
//    summa *= array[i];
//    Console.WriteLine($"{i} = {array[i]}");

//}
//Console.WriteLine("_______");
//double S = Math.Pow(summa, 1.0 / n);
//Console.WriteLine(S);