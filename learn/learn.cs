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
            {"help", 3}
        };

        Console.WriteLine("hey");
        Console.WriteLine("choose application or type help to see list ");
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
            case 3:
                helpList(functionList);
                break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }

 Main();
    }

    private static void helpList(Dictionary<string, int> functionList)
    {
        foreach (string key in functionList.Keys)
        {
            Console.WriteLine($" option: {key} ");
        }

    }

    static void newFunc()
    {
        Console.WriteLine("hallo");
       
    }

    static void arrayLogic()
    {
        int[] value = { 3, 4, 6 };
        Console.WriteLine("select a val between 0 and " + (value.Length - 1));
        string number = Console.ReadLine();
        Console.WriteLine(value[int.Parse(s: number)]);
    }

   
}