using System;

class Learn
{


    static void Main()
    {

        // Using Dictionary initializer
        Dictionary<string, int> functionList = new Dictionary<string, int>()
        {
            {"alm", 1},
            {"arr", 2},
            {"Tokyo", 3}
        };

        Console.WriteLine("hey");
        Console.WriteLine("choose application");
        Console.WriteLine(functionList);
        string choice = Console.ReadLine();
        Console.WriteLine("given input is " + choice);



        switch (functionList[choice])
        {
            case 1:
                Console.WriteLine("Today is Saturday.");
                newFunc();
                break;
            case 2:
                Console.WriteLine("Today is Sunday.");
                arrayLogic();
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }

    }

    static void newFunc()
    {
        Console.WriteLine("hallo");
        Main();
    }

    static void arrayLogic()
    {
        int[] value = { 3, 4, 6 };
        Console.WriteLine("select a val between 0 and " + (value.Length - 1));
        string number = Console.ReadLine();
        Console.WriteLine(value[int.Parse(s: number)]);





    }
}