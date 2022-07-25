  using System;
class Example
{
    static void Main()
    {
        bool prime = true;
        for (int i = 2; i < 100; i++)
        {
            for (int j = 2; j < 100; j++)
            {
                if (i != j && i % j == 0)
                {
                    prime = false;
                }

            }
            if (prime)
            {
                //Console.WriteLine("primes Number....");
                Console.WriteLine(i);
            }
            prime = true;
        }
    }
}



using System;
class Example
{
    static  void Main()
    {
        int a = 10, b = 50, c = 17;
        console
        if (a > b  && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > c && b > a)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
-------------------------------------------------------------------------------------------------------------------------
1.using System;

class Example1
{
    static void Main()
    {
        Console.WriteLine("Hello : Nilesh ");
    }
}
----------------------------------------------------------------------------------------------------------------------
2.
//Write a C# Sharp program to print the sum of two numbers
using System;
class Example
{
    static  void Main()
    {
        int a = 10, b = 50, c = a+b;
        Console.WriteLine("Sum Of Two Numner= "+c);
        
    }
}
3.
//Write a C# Sharp program to print the division of two numbers
using System;
class Example
{
    static  void Main()
    {
        float a = 10, b = 50, c = b/a;
        Console.WriteLine("Division  Of Two Numner= "+c);
        
    }
}

4.
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

5.
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

6.

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


7.

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

8.

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

9.

	

10.

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

11.

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

12.

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

13.

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

14.

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
15.

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

16.

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
17.
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
18.

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
19.

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
20.

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
21.
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

22.
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
23.
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

24.
	
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

25.
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
26.

// C# program to reverse a string
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
27.


28.

// C# program to convert
// hexadecimal to decimal
using System;

class GFG
{
    // Function to convert
    // hexadecimal to decimal
    static int hexadecimalToDecimal(String hexVal)
    {
        int len = hexVal.Length;

        // Initializing base1 value
        // to 1, i.e 16^0
        int base1 = 1;

        int dec_val = 0;

        // Extracting characters as
        // digits from last character
        for (int i = len - 1; i >= 0; i--)
        {
            // if character lies in '0'-'9',
            // converting it to integral 0-9
            // by subtracting 48 from ASCII value
            if (hexVal[i] >= '0' && hexVal[i] <= '9')
            {
                dec_val += (hexVal[i] - 48) * base1;

                // incrementing base1 by power
                base1 = base1 * 16;
            }

            // if character lies in 'A'-'F' ,
            // converting it to integral
            // 10 - 15 by subtracting 55
            // from ASCII value
            else if (hexVal[i] >= 'A' && hexVal[i] <= 'F')
            {
                dec_val += (hexVal[i] - 55) * base1;

                // incrementing base1 by power
                base1 = base1 * 16;
            }
        }
        return dec_val;
    }

    // Driver Code
    static void Main()
    {
        String hexNum = "1A";
        Console.WriteLine(hexadecimalToDecimal(hexNum));
    }
}

// This code is contributed by mits

29.

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

30.

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
31.

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

32.

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
33.

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

34.

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

35.

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

36.

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
37.
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

38.

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
39.
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

40.

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

41.
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
42.
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
43.
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
44.

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
45.
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








