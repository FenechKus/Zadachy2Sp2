using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Matrix6();
    }


    //1
    static void Begin6()
    {
        int a = 4;
        int b = 7;
        int c = 12;
        Console.WriteLine($"V= {a * b * c}");
        Console.WriteLine($"S= {2 * (a * b + b * c + a * c)}");
    }

    //2
    static void Begin23()
    {
        int a = 4;
        int b = 7;
        int c = 12;

        int tmp = c;
        c = a;
        a = b;
        b = tmp;
        Console.WriteLine($"{a} {b} {c}");
    }

    //3
    static void Int6()
    {
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(a / 10);
        Console.WriteLine(a % 10);
    }

    //4
    static void Boolean6()
    {
        int a = 23;
        int b = 45;
        int c = 68;

        if (a < b && b < c)
            Console.WriteLine("Справедливо");
    }

    //5
    static void Boolean23()
    {
        int a = int.Parse(Console.ReadLine());
        int b = a;
        var col = new List<int>();
        while (b > 0)
        {
            col.Add(b % 10);
            b = b / 10;
        }
        b = 0;
        col.Reverse();
        for (int mcol = 0; mcol < col.Count; mcol++)
            b = b + col[mcol] * (int)Math.Pow(10, mcol);
        if (a == b)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
        Console.ReadLine();
    }

    //6
    static void If6()
    {
        int a = 2;
        int b = 6;
        Console.WriteLine(a < b ? a : b);
    }

    //7
    static void If23()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        if (x2 == x3)
            Console.WriteLine($"x4: {x1}");

        else if (x3 == x1)
            Console.WriteLine($"x4: {x2}");
        else
            Console.WriteLine($"x4: {x3}");

        if (y2 == y3)
            Console.WriteLine($"y4: {y1}");
        else if (y3 == y1)
            Console.WriteLine($"y4: {y2}");
        else
            Console.WriteLine($"y4: {y3}");
    }

    //8
    static void Case6()
    {
        int n = int.Parse(Console.ReadLine());
        float l = float.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine(l / 10);
                break;

            case 2:
                Console.WriteLine(l * 1000);
                break;

            case 3:
                Console.WriteLine(l);
                break;

            case 4:
                Console.WriteLine(l / 1000);
                break;

            case 5:
                Console.WriteLine(l / 100);
                break;
        }
    }

    //9
    static void For6()
    {
        int price = 5;

        for (double i = 0.1; i < 1.0; i += 0.2)
            Console.WriteLine($"Цена за {i}: " + price * i);
    }

    //10
    static void For23()
    {
        int N = int.Parse(Console.ReadLine());

        float X = float.Parse(Console.ReadLine());

        double p = X, s = X;
        int k = 0;

        for (int i = 1; i <= N; i++)
        {
            k += 2;
            p *= (-1) * X * X / (k * (k + 1));
            s += p;
            Console.Write($"{i}:{k}:{p} {s}");
        }
    }


    //11
    static void For40()
    {
        int a = 1, b = 10;

        int k = 1;
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= k; j++)
                Console.Write($"{i} ");
            Console.WriteLine();
            k += 1;
        }
    }


    //12
    static void While6()
    {
        int n = int.Parse(Console.ReadLine());

        int l;
        if (n % 2 == 0)
            l = 2;
        else
            l = 1;

        long factorial = 1;

        while (n >= l)
        {
            factorial *= n;
            n -= 2;
        }

        Console.WriteLine(factorial);
    }

    //13
    static void While26()
    {
        int n = -1;
        while (n < 0)
        {
            n = int.Parse(Console.ReadLine());
        }

        int f1 = 1, f2 = 1, f = 0;

        while (f < n + 1)
        {
            f = f2 + f1;
            f2 = f1;
            f1 = f;
        }

        Console.WriteLine(f1 - f2);
        Console.WriteLine(f);
    }

    //14
    static void Series6()
    {
        Double r;
        int i, n, sum = 0;
        Console.Write("N=");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            r = Convert.ToDouble(Console.ReadLine());
            r = Math.Truncate(r);
            Console.WriteLine(r);
            sum += (int)r;
        }
        Console.WriteLine("Сумма = " + sum);
    }

    //15
    static void Series16()
    {
        int r = 1, num = 0;

        int k = int.Parse(Console.ReadLine());

        while (r != 0)
        {
            Console.Write("Число ");
            r = int.Parse(Console.ReadLine());
            if (r > k)
                num = r;
        }

        Console.WriteLine(num);
    }

    //16
    static void Series26()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        float a, pow = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(">");
            a = float.Parse(Console.ReadLine());
            for (int i2 = 0; i2 <= k; i2++)
            {
                pow *= a;
                Console.WriteLine(pow);
            }
        }
    }

    //17
    static void Series36()
    {
        int k = int.Parse(Console.ReadLine());

        int count = 0, a = 1, a1;

        for (int ki = 1; ki < k; ki++)
        {
            Console.WriteLine(">");
            a = int.Parse(Console.ReadLine());
            int check = 1;
            while (a != 0)
            {
                a1 = a;
                Console.WriteLine(">");
                a = int.Parse(Console.ReadLine());
                if ((a1 > a) && (a != 0))
                    check = 0;
            }

            if (check != 0)
                count++;
        }
        Console.WriteLine(count);
    }

    //18
    static void Proc6()
    {
        for (int i = 0; i < 5; i++)
        {
            int k;
            Console.Write("k: ");
            k = int.Parse(Console.ReadLine());
            DigitCountSum(k, out int c, out int s);
            Console.WriteLine("c: " + c);
            Console.WriteLine("s: " + s);
        }
    }

    public static void DigitCountSum(int k, out int c, out int s)
    {
        c = 0;
        s = 0;
        while (k != 0)
        {
            s += k % 10;
            ++c;
            k /= 10;
        }
    }

    //19
    static void Proc16()
    {
        float a = int.Parse(Console.ReadLine());
        float b = int.Parse(Console.ReadLine());
        Console.WriteLine(Sign(a) + Sign(b));
    }

    static int Sign(float x)
    {
        if (x < 0) { return -1; }
        if (x == 0) { return 0; }
        if (x > 0) { return 1; }
        else return 0;
    }

    //20
    static void Proc26()
    {
        var array = new int[] { 5, 2, -55, -15, 25, 1425, 6325, 546, 160, 141 };
        var count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (IsPower5(array[i])) count++;
        }
        Console.WriteLine(count);
    }

    static bool IsPower5(int k)
    {
        if (k < 5) return false;
        while (k % 5 == 0)
        {
            k /= 5;
        }
        return k == 1;
    }

    //21
    static void Proc36()
    {
        int n;

        for (int i = 1; i <= 5; i++)
        {
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }
    }

    static int Fib(int n)
    {
        int fk = 0, fk1 = 1, fk2 = 1;
        for (int i = 1; i <= n; i++)
        {
            fk = fk2 + fk1;
            fk2 = fk1;
            fk1 = fk;
        }
        return fk;
    }

    //22
    static void Proc46()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(NOD(a, b));
    }

    static int NOD(int a, int b) => b == 0 ? a : NOD(b, a % b);

    //23
    static void MinMax6()
    {
        int max = int.MinValue, min = int.MaxValue;

        Random random = new Random();
        int n = int.Parse(Console.ReadLine());

        int[] arr = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        foreach (int item in arr)
        {
            if (item > max)
                max = item;
            if (item < min)
                min = item;
        }
        Console.WriteLine(arr[Array.IndexOf(arr, max)]);
        Console.WriteLine(arr[Array.LastIndexOf(arr, min)]);
    }

    //24
    static void MinMax16()
    {
        int min = int.MaxValue;
        int count = 0;

        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] arr = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }

        foreach (int item in arr)
        {
            if (item != min)
                count++;
            else
                break;
        }
        Console.WriteLine(count);

    }

    //25
    static void MinMax26()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();
        int num = 0, maxNum = 0;

        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] % 2 == 0)
                ++num;
            else
            {
                if (num > maxNum) maxNum = num;
                num = 0;
            }
        }
        if (num > maxNum) maxNum = num;
        Console.WriteLine("Число четных последовательных чисел:" + maxNum);
    }


    //26
    static void Array6()
    {
        int[] a = new int[10];

        int n = int.Parse(Console.ReadLine());
        a[0] = int.Parse(Console.ReadLine());
        a[1] = int.Parse(Console.ReadLine());

        for (int i = 0; i < a.Length; i++)
            for (int i2 = 0; i2 < i; i2++)
                a[i] += a[i2];

        foreach (var item in a)
            Console.WriteLine($"{item}");
    }

    //27
    static void Array16()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(array[i]);
            Console.WriteLine(array[n - i - 1]);
        }
        if (n % 2 != 0)
            Console.WriteLine(array[n / 2]);
    }

    //28
    static void Array26()
    {
        int[] array = new int[] { 1, 2, 3, 3 };

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] % 2 != 0 && array[i - 1] % 2 == 0 || array[i] % 2 == 0 && array[i - 1] % 2 != 0)
            {
                Console.WriteLine(0);
                continue;
            }
            else
            {
                Console.WriteLine("Закономерность провалена " + i);
                break;
            }
        }

    }

    //29
    static void Array36()
    {
        int c = 1, max = 0;

        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        for (int i = 1; i < n - 1; ++i)
        {
            if (!((array[i - 1] < array[i]) && (array[i] > array[i + 1])) && !((array[i - 1] > array[i]) && (array[i] < array[i + 1])))
            {
                if ((array[i] > max) || c != null)
                {
                    max = array[i];
                    c = 0;
                }
            }
        }

        if ((array[0] == array[1]) && ((array[0] > max) || c != null))
        {
            max = array[0];
            c = 0;
        }
        if ((array[n - 1] == array[n - 2]) && ((array[n - 1] > max) || c != null))
        {
            max = array[n - 1];
            c = 0;
        }
        Console.WriteLine($"Max: {max}");
    }


    //30
    static void Array46()
    {
        int v = int.MaxValue;
        int F = 0;
        int D = 0;
        int R = 20;
        int i = 0;
        int j = 0;
        int H = 0;
        int[] A = { 2, 4, 7, 8, 10, 12, 17, 19, 21, 25 };
        for (; i < A.Length; i++)
        {
            for (j = i + 1; j < A.Length; j++)
            {
                H = ((A[i] + A[j]) - R);

                if (H <= v && H > 0)
                {
                    v = ((A[i] + A[j]) - R);
                    D = i;
                    F = j;
                }
            }
        }
        Console.WriteLine("Элементы массива,\n "
        + "сумма которых наиболее близка\n "
        + "к числу R имеют значения: {0}, {1}\n", A[D], A[F]);
    }

    //31 
    static void Array56()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        Console.WriteLine($"Массив A: {String.Join(", ", array)}");

        int[] B = new int[((array.Length / 2) + (array.Length % 2))];
        int t = 0;

        for (int i = 0; i < array.Length; i = i + 2)
        {
            B[t] = array[i];
            t++;
        }

        Console.WriteLine($"Массив B: {String.Join(", ", B)}");

        Console.WriteLine($"Length new array: {B.Length}");
    }

    //32
    static void Array66()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        Console.WriteLine($"Massiv: {String.Join(", ", array)}");
        bool isChetnoyeFind = false;
        int chetnoye = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (isChetnoyeFind == false && array[i] % 2 == 0)
            {
                chetnoye = array[i];
                isChetnoyeFind = true;
            }
            else if (array[i] % 2 == 0)
                array[i] += chetnoye;
        }

        Console.WriteLine($"Massiv': {String.Join(", ", array)}");
    }

    //33
    static void Array76()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();
        int i;

        Console.WriteLine($"Massiv: {String.Join(", ", array)}");

        if (array[0] > array[1])
        {
            i = 2;
            array[0] = 0;
        }
        else i = 1;

        for (; i < array.Length - 1; i++)
        {
            if ((array[i - 1] < array[i]) && (array[i] > array[i + 1]))
            {
                array[i] = 0;
                i++;
            }
        }
        if ((i == n - 1) && (array[n - 2] < array[n - 1]))
            array[n - 1] = 0;

        Console.WriteLine($"Massiv': {String.Join(", ", array)}");
    }

    //34
    static void Array86()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        Console.WriteLine($"Array: {String.Join(", ", array)}");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            array[i] = i >= k ? array[i - k] : 0;
        }
        Console.WriteLine($"Array': {String.Join(", ", array)}");
    }

    //35
    static void Array96()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();

        Console.WriteLine($"Array: {String.Join(", ", array)}");
        Console.WriteLine($"Array': {String.Join(", ", array.Distinct().ToArray())}");
    }

    //36
    static void Array106()
    {
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable.Repeat(random, n).Select(x => x.Next(0, 1000)).ToArray();
        int[] arrayB = new int[n];
        Console.WriteLine($"Array: {String.Join(", ", array)}");

        for (int i = 0; i < array.Length / 2; i++)
        {
            arrayB[i] = array[i * 2];
        }
        Console.WriteLine($"Array: {String.Join(", ", arrayB)}");
    }

    //37
    static void Matrix6()
    {
        int m, n, q = 0;

        Console.WriteLine("Введите количество строк массива");

        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов массива");

        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите Q");

        q = int.Parse(Console.ReadLine());
        int[,] mass = new int[n, m];
        Random r = new Random();
        for (int j1 = 0; j1 < m; j1++)
            mass[0, j1] = r.Next(100);


        for (int i = 1; i < n; i++)
            for (int j = 0; j < m; j++)
                mass[i, j] = mass[i - 1, j] * q;

        for (int i1 = 1; i1 < n; i1++)
        {
            for (int j2 = 0; j2 < m; j2++)
                Console.Write(mass[i1, j2] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    //38
    static void String6()
    {
        char c = char.Parse(Console.ReadLine());

        if ((int)c >= 48 && (int)c <= 57)
        {
            Console.WriteLine("digit");
        }
        else if ((int)c >= 65 && (int)c <= 128)
        {
            Console.WriteLine("lat");
        }
        else if ((int)c >= 1040 && (int)c <= 1103)
        {
            Console.WriteLine("rus");
        }
    }
}