using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment_session_5___function_
{
    internal class Program
    {
        #region problem1
        // question is :
        //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

        #region pass by value

        #region ex sum
        //static int sum(int x , int y )
        //{
        //    return x + y;
        //}


        #endregion

        #endregion

        #region pass by refrence

        #region ex swap
        //static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #endregion

        #endregion

        #region problem2
        // question is :
        // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        #region refernce type parametar
        // question is :
        // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        #region pass by value

        #region ex sumArray
        //public static int sumArray(int[] arr)
        //{
        //    //arr[0] = 100;
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #endregion

        #region pass by refrence

        #region ex sumarray
        //public static int sumarray(ref int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion



        #endregion

        #endregion

        #endregion

        #region problem3
        // question is :
        //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //static (int, int) Calculate(int x, int y, int z, int f)
        //{
        //    int sum = x + y;
        //    int sub = z - f;
        //    return (sum, sub);
        //}
        #endregion

        #region problem4
        // question is :
        /*Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like
        Enter a number: 25                                                                                            
        The sum of the digits of the number 25 is: 7*/

        //static int SumOfDigits(int x)
        //{
        //    int sum = 0;
        //    while (x != 0)
        //    {
        //        sum += x % 10;
        //        x /= 10;
        //    }
        //    return sum;

        //}

        #endregion

        #region problem5
        // question is :
        //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

        //static bool IsPrime(int x)
        //{
        //    if (x <= 1)
        //        return false; 

        //    for (int i = 2; i <= Math.Sqrt(x); i++)

        //    // هجيب الجذر التربيعي للرقم اللي هيدخل وهشوف الاعداد اللي اقل من النتايج اللي طلع 
        //    //إذا كان الرقم يقبل القسمة على أي من هذه الأرقام بدون باقي، فإن الرقم ليس عددًا أوليًا.
        //    // جذر 49 = 7 هنشوف 2,3,4,5,6,7
        //    // لو ال49بتقبل القمسه علي رقم من دول منغير متطلع باقي قسمه تبقي مش عدد اولي
        //    //49 is not prime>> 49/7 = 7 عدد صحيح 
        //    {

        //        if (x % i == 0)  //false لو بيقبل القسمه علي اي عدد غير نفسه اطبع 
        //        {
        //            return false;
        //        }
        //    }

        //   return true;  
        //

        #endregion

        #region problem6
        // question is :
        //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //static void MinMaxArray(ref int[] array, ref int smallest, ref int greatest)
        //{
        //    foreach (int i in array)
        //    {
        //        if (i < smallest)
        //            smallest = i;

        //        if (i > greatest)
        //            greatest = i;
        //    }
        //}
        #endregion

        #region problem7
        // question is :
        //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //static int factorial (int f)
        //{
        //    int result = 1; 
        //    for (int i = 1; i <= f; i++)
        //    {
        //        result *= i; 
        //    }
        //    return result;

        //    // or 
        //    //if (f == 0 || f == 1)
        //    //return 1;
        //    //else
        //    //return f * factorial(f - 1); 

        //}



        #endregion

        #region problem8
        // question is :
        //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    char[] charArray = input.ToCharArray();

        //    charArray[position] = newChar;

        //    return new string(charArray);
        //}

        #endregion
        static void Main(string[] args)
        {

            #region problem1
            // question is :
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region pass by value

            #region ex sum

            //int num1, num2;
            //bool flag;
            //Console.WriteLine("please enter 2 int num ");
            //do
            //{
            //    Console.WriteLine("enter num 1 ");
            //    flag = int.TryParse(Console.ReadLine(), out num1);
            //} while (!flag);

            //do
            //{
            //    Console.WriteLine("enter num 2 ");
            //    flag = int.TryParse(Console.ReadLine(), out num2);
            //} while (!flag);

            //int result = sum(num1, num2);
            //Console.WriteLine($"The sum of {num1} + {num2} is: {result}");

            #endregion

            #endregion

            #region pass by refrence

            #region ex sawp
            //int a = 3;
            //int b = 7;
            //Console.WriteLine($"A before swap = {a}");//3
            //Console.WriteLine($"b before swap = {b}");//7
            //swap(ref a, ref b);
            //Console.WriteLine($"a after swap = {a}");//7
            //Console.WriteLine($"b after swap = {b}");//3

            #endregion

            #endregion

            #endregion

            #region problem2
            // question is :
            // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            #region refernce type parametar

            #region pass by value

            #region sumArray
            //Console.WriteLine("please enter size of array");
            //int items = int.Parse(Console.ReadLine());
            //int[] num2 = new int[items];

            //for (int i = 0; i < items; i++)
            //{
            //    Console.WriteLine($"Enter element {i + 1}:");
            //    num2[i] = int.Parse(Console.ReadLine());

            //}
            //int result2 = sumArray(num2);
            //Console.WriteLine($"Sum of array is :{result2}");


            #endregion

            #endregion

            #region pass by refrence ref

            #region sumarray
            //int[] num = { 1, 2, 3 };
            //int result = sumarray(ref num);
            //Console.WriteLine(result);


            #endregion



            #endregion

            #endregion

            #endregion

            #region problem3
            // question is :
            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int x, y, z, f;
            //bool flag;
            //Console.WriteLine("Enter 4 num to get sum of first 2 num and sun is second 2 num");
            //do
            //{
            // Console.WriteLine("Enter number 1 ");
            // flag = int.TryParse(Console.ReadLine(), out x);
            //}while (!flag);

            //do
            //{
            //  Console.WriteLine("Enter number 2 ");
            //  flag = int.TryParse(Console.ReadLine(), out y);
            //} while (!flag);

            //do
            //{
            // Console.WriteLine("Enter number 3 ");
            // flag = int.TryParse(Console.ReadLine(), out z);
            //}while (!flag);

            //do
            //{
            // Console.WriteLine("Enter number 4 ");
            // flag = int.TryParse(Console.ReadLine(), out f);
            //}while (!flag);

            //(int sum, int sub) = Calculate(x, y, z, f);

            //Console.WriteLine($"sum of {x} + {y} is : {sum}");
            //Console.WriteLine($"sub of {z} - {f} is : {sub}");

            #endregion

            #region problem4
            // question is :
            /*Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Output should be like
            Enter a number: 25                                                                                            
            The sum of the digits of the number 25 is: 7*/
            //int x;
            //bool flag;
            //Console.WriteLine("Enter Number to get sum of diget of this num");
            //do
            //{
            //  Console.WriteLine("please Enter number ");
            //  flag = int.TryParse(Console.ReadLine(), out x);
            //}while (!flag);

            //int sum = SumOfDigits(x);

            //Console.WriteLine($"sum of diget of {x} is {sum}");

            #endregion

            #region problem5
            // question is :
            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //int x;
            //bool flag;
            //Console.WriteLine("Enter Number to check is prime number or not");
            //do
            //{
            //    Console.WriteLine("please Enter number ");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);
            //if (IsPrime(x))
            //{
            //    Console.WriteLine($"{x} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} is not a prime number.");
            //}
            #endregion

            #region problem6
            // question is :
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int ArraySize;
            //bool flag;
            //do
            //{
            //   Console.WriteLine("Enter Size of array ");
            //   flag = int.TryParse(Console.ReadLine(), out ArraySize);
            //} while (!flag);

            //    int[] number = new int[ArraySize];
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    Console.Write($"Please enter the item {i + 1} for this array:");
            //    while (!int.TryParse(Console.ReadLine(), out number[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //    }
            //}

            //int smallest = int.MaxValue;
            //int greatest = int.MinValue;

            //MinMaxArray(ref number, ref smallest, ref greatest);

            //Console.WriteLine($"smallest number is : {smallest}");
            //Console.WriteLine($"greatest number is : {greatest}");

            #endregion

            #region problem7
            // question is :
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //int x;
            //bool flag;
            //Console.WriteLine("Enter Number to calculate factorial");
            //do
            //{
            //    Console.WriteLine("please Enter number ");
            //    flag = int.TryParse(Console.ReadLine(), out x);
            //} while (!flag);
            //int result = factorial(x);
            //Console.WriteLine($"Factorial {x} is {result}");

            #endregion

            #region problem8
            // question is :
            //Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
           
            //Console.WriteLine("please Enter word ");
            //string word = Console.ReadLine();

            //int position;
            //bool flag ;
            //do
            //{
            //    Console.WriteLine("please Enter posation you want to replace in begain of 0 ");
            //    flag = int.TryParse(Console.ReadLine(), out position);
            //} while (!flag && position >= 0 && position < word.Length);


            //Console.WriteLine("Please enter the new character: ");
            //char newChar = Console.ReadLine()[0]; 

            //string modifiedWord = ChangeChar(word, position, newChar);

            //Console.WriteLine("Modified word: " + modifiedWord);
        




            #endregion

        }
    }
}
