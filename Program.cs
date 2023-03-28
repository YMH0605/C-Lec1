using Lec_1;
using LibraryforLec1;
/*
class Program2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Class1 clas1 = new Class1();

    }
}
*/



public class Program
{
    public static void Main()
    {
        // int, char, string, double, float, decimal, bool
        // Strongly typed laguage, case-sensitive
        // Case Sensitive: Pascal casing
        // Camel Casing
        int i = 0;
        string str = "Hello people";
        char chr = 'a'; //ASCII
        double dub = 3.1415926;

        decimal deci = 3.142342m;
        float flo = 3.142342f;

     
        int inte = (int)deci;
        string intToString = Convert.ToString(inte);
        string stringconcat = "" + inte;

        string interpol = $"the value for deci = {deci + 31.23m}";

        var assumption = 3.14f;

        int qwert;
        qwert = 100;

        // arr can only hold 3 integers in its array
        int[] arr = new int[] { 1, 2, 3 };
        // arr2 can only hold 4 integers
        var arr2 = new int[] { 1, 2, 3, 4 };
        arr2[3] = 1;
        foreach (var item in arr2)
        {
            Console.Write(item);
        }

        //arr3
        var arr3 = new int[3] { 1, 2, 3 };

        //Data type is necessary instead of var for arr4 but the right show only contents
        int[] arr4 = { 1, 2, 3 };

        //matrices
        int[,] arr5 = new int[2, 3];
        // 2 rows, 3 columns
        int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //Value vs reference type
        Array.Sort(arr4);

        Console.WriteLine("");
        var lp = new LearningParameters();
        int a = 10;
        int b = 20;
        int result = lp.PassByValue(10, 20);
        
        

        int result1 = lp.PassByReference(ref a, ref b);
        

        string msg = ""; //important here
        bool result3 = lp.Author("bob", "billy", out msg);
        Console.WriteLine(result3 + " " + msg);

        lp.ParamsLearning(1, "AnyString", 1, 2, 3, 4, 5, 6, 6, 3, 2, 1, 3, 4); //Actual parameters
    }


    // Classes, OOP including constructors getters and setters. amd all of that;
    // Leetcode (two sum) + Conceptual Question
    
}

