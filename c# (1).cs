  //1.Write a C# Sharp program to print Hello and your name in a separate line.

using System;

class Example1
{
    static void Main()
    {
        Console.WriteLine("Hello : Nilesh ");
    }
}

//2.Write a C# Sharp program to print the sum of two numbers
using System;
class Example
{
    static  void Main()
    {
        int a = 10, b = 50, c = a+b;
        Console.WriteLine("Sum Of Two Numner= "+c);
        
    }
}
//3.Write a C# Sharp program to print the division of two numbers
using System;
class Example
{
    static  void Main()
    {
        float a = 10, b = 50, c = b/a;
        Console.WriteLine("Division  Of Two Numner= "+c);
        
    }
}
//4.
using System;
class Example
{
    static void Main()
    {
        Console.WriteLine("-1 + 4 * 6 =" + (-1 + 4 * 6));
        Console.WriteLine("( 35+ 5 ) % 7 =" + ((35 + 5) % 7));
        Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
        Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 =" + (2 + 15 / 6 * 1 - 7 % 2));
    }
}

//5.Write a C# Sharp program to swap two numbers.
using System;
class Example5
{
    public static void Main()
    {
        int c;
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("First Input Number: " + a);
        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second Input Number: " + b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After Swap First Number: " + a);
        Console.WriteLine("After Swap second Number: " + b);
    }
}

/*6.Write a C# Sharp program to print the output of multiplication of three numbers which will be 
entered by the user.*/

using System;
class Example6
{
    public static void Main()
    {
       
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("First Input Number: " + a);

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second Input Number: " + b);

        Console.Write("Enter Third Number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Third Input Number: " + c);
       
        Console.WriteLine("Multiplication Of Three Numbers: " + a*b*c);
    }
}

/*7.. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and 
dividing of two numbers which will be entered by the user.*/

using System;
class Example7
{
    public static void Main()
    {
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("First Input Number: " + a);
        Console.WriteLine();

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second Input Number: " + b);
        Console.WriteLine();


        Console.WriteLine("Sum Of Two Numbers: " + (a + b));
        Console.WriteLine("Substraction  Of Two Numbers: " + (a - b));
        Console.WriteLine("Multiplication Of Two Numbers: " + (a*b));
        Console.WriteLine("Division Of Two Numbers: " + (a / b));
    }
}

//8.Write a C# Sharp program that takes a number as input and print its multiplication table.

using System;
class Example8
{
    public static void Main()
    {
       
        Console.Write("Enter Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(a+"*"+i+"="+a*i);
        }
    }
}

//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. 

using System;
using System.IO;
public class Exercise9
{
    public static void Main()
    {
        double number1, number2, number3, number4;

        Console.Write("Enter the First number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

        double result = (number1 + number2 + number3 + number4) / 4;
        Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}

/*10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of 
(x+y).z and x.y + y.z.*/

using System;
class Example5
{
    public static void Main()
    {
        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("First Input Number: " + a);

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second Input Number: " + b);

        Console.Write("Enter Third Number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Third Input Number: " + c);

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("(a+b).c = : " + (a + b)*c);
        Console.WriteLine("a*b + b*c  = : " + (a*b)+(b*c));    
    }
}

/*11.Write a C# Sharp program that takes an age (for example 20) as input and prints something 
as "You look older than 20".*/

using System;
class Example11
{
    public static void Main()
    {
        Console.Write("Enter You Age : ");
        string  a =(Console.ReadLine());
        Console.WriteLine("You look older than  " + a);  
    }
}

/*12.Write a C# program to that takes a number as input and display it four times in a row 
(separated by blank spaces), and then four times in the next row, with no separation. You should 
do it two times: Use Console. Write and then use {0}. */

using System;
class Example12
{
    public static void Main()
    {
        Console.Write("Enter Any Number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a+" "+a+" "+a+" "+a+" ");
        Console.WriteLine(a + "" +a + "" + a + "" + a);
        Console.WriteLine(a + " " + a + " " + a + " " + a + " ");
        Console.WriteLine(a + "" + a + "" + a + "" + a);
    }
}

/*13.Write a C# program that takes a number as input and then displays a rectangle of 3 columns 
wide and 5 rows tall using that digit. */

using System;
class Example12
{
    public static void Main()
    {
        int num;
        Console.Write("Enter A value : ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 0 || i == 4 || j==0 || j==4)
                {
                    Console.Write(num);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

//14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

using System;
public class Exercise14
{
    public static void Main()
    {
        Console.Write("Enter the amount of Celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = " +(celsius + 273));
        Console.WriteLine("Fahrenheit = "+ (celsius * 9/5 + 32));
    }
}

/*15.Write a C# program remove specified a character from a non-empty string using index of a 
character.*/


using System;
public class Exercise15
{
    public static void Main()
    {
        string s= "Atmiya University";
        Console.WriteLine(s.Remove(3,1));
        Console.WriteLine(s.Remove(7, 1));
    }
}

/*16.Write a C# program to create a new string from a given string (length 1 or more) with the 
first character added at the front and back*/

using System;
public class Exercise15
{
    public static void Main()
    {
        string s= "Atmiya University";

        s = s.Insert(0, "N");
        s = s.Insert(s.Length, "N");

        Console.WriteLine(s);
    }
}

/*17.Write a C# program to check two given integers and return true if one is negative and one is 
positive*/

using System;
class Example17
{
    static void Main()
    {
        Console.Write("Enter First Input =");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Input =");      
        int b = Convert.ToInt32(Console.ReadLine());

        if ((a < 0 && b > 0) || (a > 0 && b < 0))
        {
            Console.WriteLine("True");

        }
        else
        {
            Console.WriteLine("False");
        }

    }
}

/*18.Write a C# program to compute the sum of two given integers, if two values are equal then 
return the triple of their sum.*/

using System;

class Example1
{
    static void Main()
    {
        Console.Write("Enter First Input =");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Input =");      
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Sum Of 2 Digits="+sum);
        if (a==b)
        {
            Console.WriteLine("triple of their sum ="+(sum*3));

        }
   }
}

/*19.Write a C# program to get the absolute value of the difference between two given numbers. 
Return double the absolute value of the difference if the first number is greater than second 
number.*/

using System;

class Example1
{
    static void Main()
    {
        Console.WriteLine(result(13, 11));
        Console.WriteLine(result(50, 49));
        Console.WriteLine(result(0, 23));
   }
     static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }

}

/*20.Write a C# program to check the sum of the two given integers and return true if one of the 
integer is 20 or if their sum is 20.*/

using System;

class Example20
{
    static void Main()
    {
        Console.Write("Enter First Input =");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Input =");      
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Sum Of 2 Digits="+sum);
    }

    public static bool result(int x, int y,int z)
    {

        if (x == 20 || y == 20 || z == 20)
        {
            return true;

        }
        return false;
    }
}

/*21.Write a C# program to check if an given integer is within 20 of 100 or 200*/

using System;

class Example21
{
    static void Main()
    {
        Console.Write("Enter  Input =");
        int a = Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine(result(a));
    }
    public static bool result(int n)
    {
        if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
            return true;
            return false;
    }

}

//22.Write a C# program to convert a given string into lowercase.

using System;

class Example22
{
    static void Main()
    {
        Console.Write("Enter  String=");
        string str = (Console.ReadLine());

        Console.WriteLine("Lowercase="+str.ToLower());


    }
    
}

//23.Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

using System;

class Exaple23
{ 
    public static void Main()
    {
        for (int i = 1; i <= 99; i++)
        { 
            if(i%2==1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//24.Write a C# program to compute the sum of the first 500 prime numbers.
	
using System;
public class Exercise24
{
    public static void Main()
    {
        Console.Write("\nSum of the first N number prime numbers: ");
        int t =Convert.ToInt16(Console.ReadLine()); 
        long sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < t)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }
        Console.WriteLine(sum.ToString());
    }
    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}

//25.Write a C# program and compute the sum of the digits of an integer

using System;
public class Exercise25
{
    public static void Main()
    {
        int sum = 0;
        Console.Write("Enter A Any number : ");
        int no =Convert.ToInt32(Console.ReadLine());

        while (no > 0)
        {
            int temp = no % 10;
            sum = sum + temp;
            no = no / 10;
        }
        Console.WriteLine("---------------");
        Console.WriteLine(" sum of the digits = "+sum);
    }
}

//26.Write a C# program to reverse the words of a sentence.

using System;
public class ReverseWords
{
    public static void Main()
    {
        string[] s ="i  am Nilesh".Split(' ');
        string ans = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            ans += s[i] + " ";
        }
        Console.Write( "Reversed String:");
        Console.WriteLine(ans.Substring(0,ans.Length));
    }
}

//27.Write a C# program to find the size of a specified file in bytes.


//28.Write a C# program to convert a hexadecimal number to decimal number.

using System;

class GFG
{
    static int hexadecimalToDecimal(String hexVal)
    {
        int len = hexVal.Length;
        int base1 = 1;

        int dec_val = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            if (hexVal[i] >= '0' && hexVal[i] <= '9')
            {
                dec_val += (hexVal[i] - 48) * base1;
                base1 = base1 * 16;
            }
            else if (hexVal[i] >= 'A' && hexVal[i] <= 'F')
            {
                dec_val += (hexVal[i] - 55) * base1;
                base1 = base1 * 16;
            }
        }
        return dec_val;
    }
    static void Main()
    {
        String hexNum = "1A";
        Console.WriteLine(hexadecimalToDecimal(hexNum));
    }
}

//29. Write a C# program to multiply corresponding elements of two arrays of integers

using System;
using System.Collections.Generic;

public class Exercise29
{
    public static void Main()
    {
        try
        {
            int[] first_array = { 1, 3, -5, 4, 3, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            Console.Write("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < first_array.Length; i++)
            {

                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.WriteLine("\n");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine();
            Console.WriteLine(e);
        }
    }
}

/*30.Write a C# program to create a new string of four copies, taking last four characters from a 
given string. If the length of the given string is less than 4 return the original one.*/

using System;

public class Exercise30
{
    static void Main(string[] args)
    {
        string str;
       
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        if (str.Length > 4)
        {
            Console.WriteLine(str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
        }
        else {
            Console.WriteLine("string : "+str);
        }
    }
}

//31.Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. 

using System;
public class Exercise31
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0)
        {
            Console.WriteLine(a % 3 == 0 || a % 7 == 0);
        }
    }
}

//32.Write a C# program to check if a string starts with a specified word.

using System;

public class Exercise34
{
    static void Main(string[] args)
    {
        Console.Write("Input a string : ");
        string str = Console.ReadLine();
        if (str.Length > 5 && str.Substring(0, 5).ToUpper().Equals("HELLO"))
        {
            Console.WriteLine("True");
        }
        else 
        {
            Console.WriteLine("False");
        }
    }
}

/*33.Write a C# program to check two given numbers where one is less than 100 and other is 
greater than 200*/

using System;

public class Exercise33
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number(<100): ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number(>200): ");
        int y = Convert.ToInt32(Console.ReadLine());
        if(x < 100 && y > 200)
        {
            Console.WriteLine((x < 100 && y > 200));
        }
        else
        {
            Console.WriteLine("Flase");
        }
    }
}

/*34.Write a C# program to check if an integer (from the two given integers) is in the range -10 to 
10.
*/

using System;

public class Exercise33
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if ((x > -10 && y < 10) || (y > -10 && x < 10))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("Flase");
        }
    }
}

/*35.Write a C# program to check if "HP" appears at second position in a string and returns the 
string without "HP"*/

using System;
public class Exercise34
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter String : ");
        string str = Console.ReadLine();
        if (str.Substring(1, 2) == ("HP"))
        {
            string s1;
            s1 = str.Remove(1, 2);
            Console.WriteLine(s1);
        }
        else
        {

        }
    }
}

//36.Write a C# program to find the largest and lowest values from three integer values.

using System;
public class Exercise33
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a Third number: ");
        int z = Convert.ToInt32(Console.ReadLine());
        if ((x < y && x < z)) 
        {
            Console.WriteLine("Smallest Number : "+x);
        }
        else if ((y < z))
        {
            Console.WriteLine("smallest : " + y);
        }
        else
        {
            Console.WriteLine("Smallest Number:"+z);
        }
        if ((x > y && x > z))
        {
            Console.WriteLine("Biggest Number : " + x);
        }
        else if ((y > z))
        {
            Console.WriteLine("smallest : " + y);
        }
        else
        {
            Console.WriteLine("Biggest Number:" + z);
        }
    }
}
/*37.Write a C# program to check the nearest value of 20 of two given integers and return 0 if two 
numbers are same*/

using System;
public class Exercise33
{
    static void Main(string[] args)
    {
        Console.Write("Input a first number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int a = 20 - x;
        int b = 20 - y;
        if (x==y) 
        {
            Console.WriteLine("0");
        }   
        else if (a<b) 
        {
            Console.WriteLine("nearest 20: " + x);
        }
        else
        {
            Console.WriteLine("nearest 20:" + y);
        } 
    }
}

/*38.Write a C# program to count a specified number in a given array of integers.*/

using System;
public class Exercise33
{
    static void Main(string[] args)
    {
        int count = 0;
        //int item = 0;
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        for (int i = 0; i < 15; i++)
        {
            if (x == nums[i])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

/*39.Write a C# program to check if a number appears as either the first or last element of an array 
of integers and the length is 1 or more*/

using System;
public class Exercise33
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        if ((nums[0] == x) || (nums[nums.Length - 1] == x))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        } 
    }
}

//40.Write a C# program to compute the sum of all the elements of an array of integers

using System;
public class Exercise40
{
    static void Main(string[] args)
    {
        int count = 0;

        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        for (int i = 0; i < nums.Length - 1; i++)
        {
            count += nums[i];
        }
        Console.WriteLine("Sum = " + count);
    }
}

/*41.Write a C# program to check if the first element or the last element of the two arrays ( length 
1 or more) are equal*/

using System;
public class Exercise41
{
    public static void Main()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        if ((nums.Length >= 1) && (nums[0].Equals(nums[nums.Length - 1])) && (nums2.Length >= 1) && (nums2[0].Equals(nums2[nums2.Length - 1])))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

//42.Write a C# program to rotate an array (length 3) of integers in left direction

using System;
public class Exercise50
{
    public static void Main()
    {
        int[] nums = { 1, 2, 8 ,5,6};
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = temp;
        Console.WriteLine("After rotating array : [{0}]", string.Join(", ", nums));

    }
}

/*43.. Write a C# program to get the larger value between first and last element of an array (length 
3) of integers.*/

using System;
public class Code
{
    static int largeValue(int[] arr1)
    {
        if (arr1[0] > arr1[arr1.Length - 1])
        {
            return arr1[0];// first element of array
        }
        else
        {
            return arr1[arr1.Length - 1]; //last element of array
        }
    }
    static void Main(string[] args)
    {
        int[] arr = new int[] { 10, 2, 10, 4 };
        Console.WriteLine("Larger Value between first and last element of array : {0}", largeValue(arr));
    }
}

/*44.Write a C# program to create a new array of length containing the middle elements of three 
arrays (each length 3) of integers*/

using System;
class example44
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 8, 5, 6 };
        int[] arr2 = { 1, 2, 8, 5, 6 };
        int[] arr3 = { 1, 2, 8, 5, 6 };
        int[] arr4 = { arr1[1], arr2[1], arr3[1] };
        Console.WriteLine("ARRAY 1: ");
        foreach (var item in arr1)
        {
            Console.Write(" "+item);   
        }
        Console.WriteLine("\nARRAY 2: ");
        foreach (var item in arr2)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine("\nARRAY 3: ");
        foreach (var item in arr3)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine(" ");
        Console.WriteLine("\nNEW ARRAY : ");
        foreach (var item in arr4)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine(" ");
    }
}

//45.Write a C# program to check if an array contains an odd number.

using System;
class example45
{
    static void Main()
    {
        int[] arr = { 1, 1, 3, 3, 5 };
        int Flag = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine("Array Contain Odd Number ");
                Flag = 1;
                break;
            }
        }
        if (Flag == 0)
        {
            Console.WriteLine("Array Not Contain Odd Number ");
        }
    }
}








