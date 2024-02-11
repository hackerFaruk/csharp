using System; 

class Learn{


    static void Main(){
        
          Console.WriteLine("hey");
        Console.WriteLine("choose application");
        string choice = Console.ReadLine();
        Console.WriteLine("given input is " + choice );

        if(choice == "alm"){ newFunc();}
        else if( choice =="arr"){arrayLogic();}
    }

    static void newFunc(){
        Console.WriteLine("hallo");
    }

    static void arrayLogic(){
        int[] value = { 3, 4, 6 };
        Console.WriteLine("select a val between 0 and " + (value.Length-1));
        string number = Console.ReadLine();
        Console.WriteLine(value[int.Parse(s: number)]);


      
    }
}