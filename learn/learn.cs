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
            {"help", 3},
            {"change",4},
            {"exit",5},

        };

        int[] value = { 3, 4, 6 };

        
        Console.WriteLine("choose application or type help to see list ");
       
        string choice ="help";     
        choice = Console.ReadLine();
      
        switch (functionList[choice])
        {
            case 1:
                Console.WriteLine("Today is Saturday.");
                newFunc();
                break;
            case 2:
                Console.WriteLine("Today is Sunday.");
                arrayLogic(value);
                break;
            case 3:
                helpList(functionList);
                break;
            case 4:
                changeList( value);
                break;
            case 5:
                // this is exit so it just returns 
                Console.WriteLine("Ending Program Have a nice day");
                 System.Environment.Exit(0);
                 break;
            default:
                Console.WriteLine("Looking forward to the Weekend.");
                break;
        }

 Main();
    }


    private static void changeList(int[] value)
    {
        foreach (int key in value)
        {
            Console.WriteLine(key);
        }
        
        Console.WriteLine("which index to cahnge");
       
        string choice = Console.ReadLine();
        int adress = int.Parse(choice);
        Console.WriteLine("new val");
        string choiceval = Console.ReadLine();
        int adressval = int.Parse(choiceval);
        value[adress] = adressval;


         foreach (int key in value)
        {
            Console.WriteLine($" option: {key} ");
        }



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

    static void arrayLogic(int[] value)
    {
        
        Console.WriteLine("select a val between 0 and " + (value.Length - 1));
        string number = Console.ReadLine();
        Console.WriteLine(value[int.Parse(s: number)]);
    }

   
}