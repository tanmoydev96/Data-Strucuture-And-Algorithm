class Program
{
    public static void Main(string[] args)
    {
        //Pattern1();
        //Pattern2();
        //Pattern3();
        //Pattern4();
        //Pattern5();
        //Pattern6();
        //Pattern7();
        //Pattern8();
        //Pattern9();
    }

    //****
    //****
    //****
    //****
    //****
    public static void Pattern1()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    //*
    //**
    //***
    //****
    //*****
    public static void Pattern2()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //1
    //12
    //123
    //1234
    //12345
    public static void Pattern3()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + 1);
            }
            Console.WriteLine();
        }
    }

    //1
    //22
    //333
    //4444
    //55555
    public static void Pattern4()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(i + 1);
            }
            Console.WriteLine();
        }
    }

    //*****
    //****
    //***
    //**
    //*
    public static void Pattern5()
    {
        int n = 5;
        for (int i = 5; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //12345
    //1234
    //123
    //12
    //1
    public static void Pattern6()
    {
        int n = 5;
        for (int i = 5; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(j + 1);
            }
            Console.WriteLine();
        }
    }

    //    *
    //   ***
    //  *****
    // *******
    //*********
    public static void Pattern7()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            int NoOfSpace = n - i - 1;
            int NoOfStars = n - NoOfSpace + i;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < NoOfStars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
    //*********
    // *******
    //  *****
    //   ***
    //    *
    public static void Pattern8()
    {
        int n = 5;
        for (int i = 5; i >= 0; i--)
        {
            int NoOfSpace = n - i;
            int NoOfStars = n + i - 1 - NoOfSpace;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < NoOfStars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }

    //    *
    //   ***
    //  *****
    // *******
    //*********
    //*********
    // *******
    //  *****
    //   ***
    //    *
    public static void Pattern9()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            int NoOfSpace = n - i - 1;
            int NoOfStars = n - NoOfSpace + i;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < NoOfStars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 5; i >= 0; i--)
        {
            int NoOfSpace = n - i;
            int NoOfStars = n + i - 1 - NoOfSpace;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < NoOfStars; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    //*
    //**
    //***
    //****
    //*****
    //****
    //***
    //**
    //*
    public static void Pattern10()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //1
    //0 1
    //1 0 1
    //0 1 0 1
    //1 0 1 0 1
    public static void Pattern11()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(((i + j) % 2 == 0 ? 1 : 0) + " ");
            }
            Console.WriteLine();
        }
    }

    //1
    //2 3
    //4 5 6
    //7 8 9 10
    //11 12 13 14 15
    public static void Pattern12()
    {
        int n = 5; int output = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(output + " ");
                output++;
            }
            Console.WriteLine();
        }
    }

    //A
    //A B
    //A B C
    //A B C D
    //A B C D E
    public static void Pattern13()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            int start = 65;
            for (int j = 0; j <= i; j++)
            {
                char ch = (char)(start + j);
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }

    //A B C D E
    //A B C D
    //A B C
    //A B
    //A
    public static void Pattern14()
    {
        int n = 5;
        for (int i = n; i > 0; i--)
        {
            int start = 65;
            for (int j = 0; j < i; j++)
            {
                char ch = (char)(start + j);
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }

    //A
    //B B
    //C C C
    //D D D D
    //E E E E E
    public static void Pattern15()
    {
        int n = 10;
        for (int i = 0; i < n; i++)
        {
            int start = 65;
            for (int j = 0; j <= i; j++)
            {
                char ch = (char)(start + i);
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }
    }
    //    A
    //   ABA
    //  ABCBA
    // ABCDCBA
    public static void Pattern16()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            int NoOfSpace = n - i - 1;

            int num = 65;
            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < (2 * i + 1) / 2; j++)
            {
                char ch = (char)(num + j);
                Console.Write(ch);
            }

            for (int k = ((2 * i + 1) / 2); k >= 0; k--)
            {
                char ch = (char)(num + k);
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }

    //E
    //D E
    //C D E
    //B C D E
    //A B C D E
    public static void Pattern17()
    {
        int n = 5;
        for (int i = 5; i > 0; i--)
        {
            int num = 65;
            for (int j = i; j <= n; j++)
            {
                Console.Write((char)(num + j - 1) + " ");
            }
            Console.WriteLine();
        }
    }

    //1                 1
    //1 2             2 1
    //1 2 3         3 2 1
    //1 2 3 4     4 3 2 1
    //1 2 3 4 5 5 4 3 2 1
    public static void Pattern19()
    {
        int n = 5;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + 1 + " ");
            }
            int temp = (n - i) * 2 - 2;
            for (int j = 0; j < temp; j++)
            {
                Console.Write("  ");
            }

            for (int j = i; j >= 0; j--)
            {
                Console.Write(j + 1 + " ");
            }
            Console.WriteLine();
        }
    }

    //**********
    //****  ****
    //***    ***
    //**      **
    //*        *
    //*        *
    //**      **
    //***    ***
    //****  ****
    //**********
    public static void Pattern20()
    {
        int n = 20;
        for (int i = 0; i < n; i++)
        {
            for (int j = n - i; j > 0; j--)
            {
                Console.Write("*");
            }

            int NoOfSpace = 2 * i;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = n - i; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            int NoOfSpace = 2 * (n - i - 1);

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //*        *
    //**      **
    //***    ***
    //****  ****
    //**********
    //****  ****
    //***    ***
    //**      **
    //*        *
    public static void Pattern21()
    {
        int n = 20;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            int NoOfSpace = 2 * (n - i - 1);

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = n - i; j > 0; j--)
            {
                Console.Write("*");
            }

            int NoOfSpace = 2 * i;

            for (int j = 0; j < NoOfSpace; j++)
            {
                Console.Write(" ");
            }

            for (int j = n - i; j > 0; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}