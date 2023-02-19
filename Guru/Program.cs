// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var arr = new int [4]{ 1, 2, 3, 4 };
int y = Addition(arr);

Console.WriteLine(y);


    static int Addition(params int[] ListNumbers)
    {
        int total = 0;
        foreach (var i in ListNumbers)
        {
            total += i;
        }
        return total;
    }
