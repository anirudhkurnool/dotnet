class Program
{
    static void Main()
    {
        //Arrays
        var arr = new int[] { 1, 2, 3, 4, 5 };

        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("------------------------");

        Console.WriteLine($"arr.Length = {arr.Length}");

        //create a new array with a extra element

        arr = [.. arr, 6];




        //var = local variable type inference
        //var will do type inference for you
        var lst1 = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var num in lst1)
        {
            Console.WriteLine(num);
        }

        //Or

        Console.WriteLine("------------------------");

        List<int> lst2 = new List<int> { 2, 4, 6, 8, 10 };
        foreach (int num in lst2)
        {
            Console.WriteLine(num);
        }

        //OR
        List<int> lst3 = [3, 6, 9, 12, 15];

        //List methods
        //lists are mutable
        lst3.Add(18);//append
        Console.WriteLine(lst3);

        Console.WriteLine($"lst3 capacity = {lst3.Capacity}");
        Console.WriteLine("");
        //0-indexed
        Console.WriteLine($"lst3[0] = {lst3[0]}");
        Console.WriteLine($"Lenght of lst3 = {lst3.Count}");
        Console.WriteLine($"lst3[^1] = lst3[lst3.Count - 1] = {lst3[^1]}");

        foreach (int num in lst3[2..4])//list slicing - [2, 4)
        {
            Console.WriteLine(num);
        }

        //list sorting
        List<int> lst4 = [3, 41, 13, 4, 414, 423414, 1212];
        Console.WriteLine($"Index of 4 in lst4 = {lst4.IndexOf(4)}");
        lst4.Sort(); //inplace
        Console.WriteLine($"Index of 4 in lst4 = {lst4.IndexOf(4)}");
    }
}