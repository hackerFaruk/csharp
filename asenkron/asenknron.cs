using System;
using System.Threading.Tasks;

class Program{

  static async Task Main(){
  // Task .Net frameworkunden gelme bir class asenkron için
  //
        Task numbersTask = PrintNumbersAsync();
        Task lettersTask = PrintLettersAsync();

        await Task.WhenAll(numbersTask, lettersTask);

        Console.WriteLine("Both tasks completed.");
  }


    static async Task PrintNumbersAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            await Task.Delay(1000); // Asynchronous delay for 1 second
        }
    }

    static async Task PrintLettersAsync()
    {
        char letter = 'A';
        for (int i = 0; i < 26; i++)
        {
            Console.WriteLine(letter);
            letter++;
            await Task.Delay(1000); // Asynchronous delay for 1 second
        }
    }





}

