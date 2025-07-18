class Program 
{

    public static void evenOrOdd(int num) {
	if (num % 2 == 0) {
	    Console.WriteLine("even");
	} else {
	    Console.WriteLine("odd");
	}
    }

    //boolean operators
    public static void booleanOperatorsDemo()
	{
		bool a = true;
		bool b = true;
		if (a && b) {
			Console.WriteLine("both true");
		} else if (a || b) {
			Console.WriteLine("one of them is true");
		} else {
			Console.WriteLine("none of them are true");
		}
    }

	public static void forLoopDemo()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(i);
		}
	}

	public static void whileLoopDemo()
	{
		int i = 10;
		while (i > 0)
		{
			Console.WriteLine(i);
			i--;
		}
	}

	public static void doWhileLoopDemo()
	{

		int i = 10;

		//execute the loop atleast once no matter what

		do
		{
			Console.WriteLine(i);
			i--;
		}
		while (i > 0);
	}

	static void Main()
	{
		evenOrOdd(2);
		evenOrOdd(3);
		booleanOperatorsDemo();
		forLoopDemo();
		whileLoopDemo();
		doWhileLoopDemo();
	}
}
