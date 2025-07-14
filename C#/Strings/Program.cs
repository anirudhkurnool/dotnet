class Program
{

    public static void StringInterpolationDemo()
    {
        string str1 = "Hello";
        string str2 = "World";
        //string str2 = 'World';
        Console.WriteLine($"String Interpolation : {str1} , {str2}");
    }


    public static void StringConcatenationDemo()
    {
        string str1 = "Hello";
        string str2 = "World";
        Console.WriteLine("String Concatenation : " + str1 + " , " + str2);
    }

    public static void StringReplaceMethodDemo()
    {
        string str1 = "Hello, World";
        string str2 = str1 + " " + str1;

        Console.WriteLine($"Before str1 = {str1}");
        //Replace is not a inplace method
        //new string gets created as strings are immutable in C#
        str1 = str1.Replace("World", "Galaxy");
        Console.WriteLine($"After str1 = {str1}");

        Console.WriteLine($"Before str2 = {str2}");
        //Replace() replaces all instances of the old value
        str2 = str2.Replace("World", "Galaxy");
        Console.WriteLine($"After str2 = {str2}");
    }


    public static void StringTrimDemo()
    {
        string str1 = "   Hello";
        string str2 = "World   ";
        string str3 = "  Hello, World   ";
        Console.WriteLine($"Before : {str1} ; Before Length : {str1.Length} ; After : {str1.TrimStart()} ; AfterLength : {str1.TrimStart().Length}");
        Console.WriteLine($"Before : {str2} ; Before Length : {str2.Length} ; After : {str2.TrimStart()} ; AfterLength : {str2.TrimStart().Length}");
        Console.WriteLine($"Before : {str3} ; Before Length : {str3.Length} ; After : {str3.TrimStart()} ; AfterLength : {str3.TrimStart().Length}");
    }

    public static void StringContainsDemo()
    {
        string str1 = "Hello, World";
        Console.WriteLine($"Does str1 contain \"World\"? : {str1.Contains("World")} ");
    }

    public static void StringCaseDemo()
    {
        string str1 = "Hello, World";
        Console.WriteLine($"str1 in upper case : {str1.ToUpper()}");
        Console.WriteLine($"str1 in lower case : {str1.ToLower()}");
    }

    public static void StringStartsWithDemo()
    {
        //space and case in strings matter
        string str1 = "Hello, World";
        Console.WriteLine($"Does str1 start with Hel : {str1.StartsWith("Hel")}");
    }

    public static void StringEnssWithDemo()
    {
        //space and case in strings matter
        string str1 = "Hello, World";
        Console.WriteLine($"Does str1 start with rld : {str1.EndsWith("rld")}");
    }

    static void Main()
    {
        StringInterpolationDemo();
        StringConcatenationDemo();
        StringTrimDemo();
        StringReplaceMethodDemo();
        StringContainsDemo();
        StringCaseDemo();
        StringStartsWithDemo();
        StringEnssWithDemo();
    }
}
