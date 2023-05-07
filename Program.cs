using System;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 100, 500, 300, 200, 400 };
        string json = JsonConvert.SerializeObject(numbers);
        Console.WriteLine(json);
        Console.ReadKey();
    }
}