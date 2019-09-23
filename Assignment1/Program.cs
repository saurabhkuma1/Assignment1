using System;

//using System;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1, b = 22;
            //printSelfDividingNumbers(a, b);

            //int n2 = 5;
            //printseries(n2);

            //int n3 = 5;
            //printtriangle(n3);

            int[] j = new int[] { 1, 3 };
            int[] s = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(j, s);
            Console.WriteLine(r4);

            //int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] r5 = getLargestCommonSubArray(arr1, arr2);
            //Console.WriteLine(r5);

            //solvePuzzle();
        }

        //public static void printSelfDividingNumbers(int x, int y)
        //{
        //    try
        //    {
        //        int[] intArray = new int[y-x];
        //        defining an array to store numbers from 1 to 22

        //        int temp1 = x;

        //       for (int i=0; i<y-x;i++)
        //        {
        //            intArray[i] = temp1;
        //            temp1 = temp1 + 1;
        //        }
        //       for loop runs to take numbers from 1 to 22 from the array and 
        //       stores it in a temporary variable temp1 by incrementing it 

        //        for (int k=0; k<intArray.Length;k++)
        //        {
        //            if (checknumbers(intArray[k]))
        //                Console.WriteLine(intArray[k]);
        //        }

        //        bool checknumbers(int k)
        //        { 
        //                int temp2 = k;

        //                while (temp2 > 0)
        //                {
        //                    int d = temp2 % 10;
        //        function bool checknumbers checks remainder of the number by using mod function

        //                if (!check_divisibility(k, d))
        //                        return false;

        //                    temp2 = temp2 / 10;
        //                }

        //            return true;

        //        }

        //       bool check_divisibility(int n, int d) // bool check_divisibility checks if the digits of the number
        //    are divisible or not
        //       
        //            {
        //            return (d != 0 && n % d == 0);
        //        }
        //    }

        //    catch
        //    {
        //        Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
        //    }
        //}

        //public static void printseries(int n)
        //{
        //    try
        //    {
        //        int counter = 0; //counter is used to stop the loop after printing n=5 

        //       for(int i=1;i<=n;i++)
        //        {
        //            for (int j = 0; j<i && counter<n; j++,counter ++)
        //                Console.WriteLine(i); 
        //        }



        //    }
        //    catch
        //    {
        //        Console.WriteLine("exception occured while computing printseries()");
        //    }
        //}

        //public static void printtriangle(int n)
        //{
        //    try
        //    {
        //        int i, j, k;
        //        for (i = 5; i >= 1; i--) 
        //        {
        //            for (j = 5; j > i - n; j--)
        //            {
        //                console.write(" "); // this inner loop gives spaces based on the value of 
        //            }
        //            for (k = 1; k < (i * 2); k++)
        //            {
        //                console.write("*");
        //            }

        //            console.writeline("");
        //        }

        //    }


        //    catch
        //    {
        //        console.writeline("exception occured while computing printtriangle()");
        //    }
        //}

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                int[] jewels = new int[S.Length];
                int c = 0;
                for (int i = 0; i < J.Length; i++)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (J[i] == S[j])
                        {
                            jewels[c] = S[j];
                            c++;

                        }
                    }
                }
                if (c != 0)
                {
                    Console.Write(c + " (Since ");
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write(jewels[i] + " ");
                    }
                    Console.WriteLine(" are jewels.)");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        


            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }


        //public static int[] getLargestCommonSubArray(int[] a, int[] b)
        //{
        //    try
        //    {
        //        // Write your code here
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
        //    }

        //    return null; // return the actual array
        //}

        //public static void solvePuzzle()
        //{
        //    try
        //    {
        //        // Write your code here
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exception occured while computing solvePuzzle()");
        //    }
        //}
    }
}


