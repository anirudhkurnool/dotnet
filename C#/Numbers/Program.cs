class Program
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static void IntegerOverflowDemo()
    {
        int a = 2100000000;
        int b = 2100000000;
        int c = a + b;
        //int is only 4 bytes and c needs more than 4 bytes to be represented
        Console.WriteLine(c);
    }

    public static void IntegerOverflowDemo1()
    {
        int a = 2100000000;
        int b = 2100000000;
        long c = a + b;
        //int is only 4 bytes and c has more than 4 bytes but
        //a and b here are still integers and are 32bit so when they are added overflow still happens
        Console.WriteLine(c);
    }

    public static void IntegerOverflowDemo1Solution()
    {
        int a = 2100000000;
        int b = 2100000000;
        long c = (long)a + (long)b; // explicit casting
        Console.WriteLine(c);
    }

    public static void AvoidOverflowDemo()
    {
        int a = 2100000000;
        int b = 2100000000;
        long c = checked(a + b);//this will throw a runtime error if there is a overflow
        Console.WriteLine(c);
    }

    public static void CastingDemo()
    {
	int a = (int)40.12;
	int b = (int)50.89;
	Console.WriteLine($"a = {a}; b = {b}");
	//basically the decimal parts are just dropped
	Console.WriteLine($"a + b = {a + b}");
    }

    public static void DoubleDemo() 
    {
	//all non Integers are considered double by default
	double a = 1.232;
	//float b = 1.1234;//this will give a error
    	float b = 1.1234F;
	Console.WriteLine($"a = {a}; b = {b}");
    }

    public static void DecimalDemo() {
	decimal a = 312.1423M;
	decimal b = 14412.124M;
	//decimal is more accurate than float and double 
	Console.WriteLine($"a = {a} ; b = {b}; a+b = {a + b}");
    	Console.WriteLine($"Max decimal = {decimal.MaxValue}");
	Console.WriteLine($"Min decimal = {decimal.MinValue}");
    }


    static void Main()
    {
        Console.WriteLine(add(1, 2));
        IntegerOverflowDemo();
        IntegerOverflowDemo1();
        IntegerOverflowDemo1Solution();
        //AvoidOverflowDemo();
	CastingDemo();
	DoubleDemo();
	DecimalDemo();
    }
}
